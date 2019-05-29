using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using PAV01.Negocio;


namespace Banco
{
    public class SQLite
    {
        private string _StrConexao;

        public SQLite(string Banco)
        {
            _StrConexao = string.Format("Data Source={0};Version=3", Banco);
            if (!System.IO.File.Exists(Banco))
                CriarBanco(Banco);
        }

        private void CriarBanco(string banco)
        {
            SQLiteConnection.CreateFile(banco);
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao))
            {
                conexao.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("create table canal ( id int primary key autoincrement not null, nome varchar(30) not null, grupo varchar(30), url varchar(150) not null)"))
                {
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }

        public IEnumerable<Canal> ObterCanais()
        {
            List<Canal> L = new List<Canal>();
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao))
            {
                conexao.Open();
                SQLiteCommand cmd = new SQLiteCommand("select id, nome, grupo, url from canal order by nome");
                cmd.Connection = conexao;
                using (SQLiteDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        Canal c = new Canal();
                        c.ID = r.GetInt32(0);
                        c.Nome = r.GetString(1);
                        c.Grupo = r.GetString(2);
                        c.URL = r.GetString(3);
                        L.Add(c);
                    }
                }
            }
            return L;
        }

        public Canal ObterCanal(String nome)
        {
            Canal c = null;
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao))
            {
                conexao.Open();
                SQLiteCommand cmd = new SQLiteCommand("select id, nome, grupo, url from canal where nome=@nome");
                cmd.Connection = conexao;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", nome);
                using (SQLiteDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        c = new Canal();
                        c.ID = r.GetInt32(0);
                        c.Nome = r.GetString(1);
                        c.Grupo = r.GetString(2);
                        c.URL = r.GetString(3);
                    }
                }
                conexao.Close();
            }
            return c;
        }
        public void RemoverTodos()
        {
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao))
            {
                conexao.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("delete from canal"))
                {
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }
        public void remover(string nome)
        {
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao))
            {
                conexao.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("delete from canal where nome=@nome"))
                {
                    cmd.Connection = conexao;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }
        public void inserir(Canal c)
        {
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao))
            {
                conexao.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("insert into canal (nome, grupo, url) values (@nome, @grupo, @url)"))
                {
                    cmd.Connection = conexao;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@nome", c.Nome);
                    cmd.Parameters.AddWithValue("@grupo", c.Grupo);
                    cmd.Parameters.AddWithValue("@url", c.URL);
                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }
        public void alterar(string nome, Canal c)
        {
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao))
            {
                conexao.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("update canal set nome=@nome, grupo=@grupo, url=@url where nome=@nomeAnterior"))
                {
                    cmd.Connection = conexao;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@nome", c.Nome);
                    cmd.Parameters.AddWithValue("@grupo", c.Grupo);
                    cmd.Parameters.AddWithValue("@url", c.URL);
                    cmd.Parameters.AddWithValue("@nomeAnterior", nome);
                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }

        //Fim de canal -- Início de usuário

        public IEnumerable<Canal> ObterCanaisFav(User u)
        {
            List<Canal> L = new List<Canal>();
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao))
            {
                conexao.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("select canal.ID, canal.nome, canal.grupo, canal.url from canal join (favoritos join login on favoritos.id_user = login.id) on canal.id = favoritos.id_canal where login.id = @user order by canal.nome"))
                {
                    cmd.Connection = conexao;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@user", u.ID);
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            Canal c = new Canal();
                            c.ID = r.GetInt32(0);
                            c.Nome = r.GetString(1);
                            c.Grupo = r.GetString(2);
                            c.URL = r.GetString(3);
                            L.Add(c);
                        }
                    }
                }
            }
            return L;
        }

        public User userLog(string log, string password)
        {
            User u = new User();
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao))
            {
                conexao.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("select id, nome, senha, status from login where nome=@log and senha=@password"))
                {
                    cmd.Connection = conexao;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@log", log);
                    cmd.Parameters.AddWithValue("@password", password);
                    if (cmd.ExecuteScalar() != null)
                    {
                        using (SQLiteDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                u.ID = r.GetInt32(0);
                                u.Nome = r.GetString(1);
                                u.Senha = r.GetString(2);
                                u.Status = r.GetString(3);
                            }
                        }
                    }
                    else
                        u = null;

                }
                conexao.Close();
            }

            return u;
        }

        public void Fav(User u, Canal a)
        {
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao))
            {
                conexao.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("insert into favoritos(id_user, id_canal) values (@user, @chanel)"))
                {
                    cmd.Connection = conexao;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@user", u.ID);
                    cmd.Parameters.AddWithValue("@chanel", a.ID);
                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }

        public void Unfav(User u, Canal a)
        {
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao))
            {
                conexao.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("delete from favoritos where id_user=@user and id_canal=@chanel"))
                {
                    cmd.Connection = conexao;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@user", u.ID);
                    cmd.Parameters.AddWithValue("@chanel", a.ID);
                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }

        public void signin(User u)
        {
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao))
            {
                conexao.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("insert into login (nome, senha, status) values (@nome, @grupo, 'u')"))
                {
                    cmd.Connection = conexao;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@nome", u.Nome);
                    cmd.Parameters.AddWithValue("@grupo", u.Senha);
                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }

    }
}