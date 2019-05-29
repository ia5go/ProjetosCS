using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Banco;

namespace PAV01.Negocio
{
    public class Lista : IEnumerable<Canal>
    {
        //private List<Canal> _lista;
        private SQLite _BD;
        public Lista()
        {
            //_lista = new List<Canal>();
            _BD = new SQLite("dados.db");
        }

        public void Inserir(Canal a)
        {
            //_lista.Add(a);
            _BD.inserir(a);
        }

        public void Remover(string Nome)
        {
            
            _BD.remover(Nome);
        }

        public Canal ObterCanal(string Nome)
        {
            return _BD.ObterCanal(Nome);
        }

        public void Alterar(string Nome, Canal a)
        {
           
            _BD.alterar(Nome, a);
        }

        public IEnumerator<Canal> GetEnumerator()
        {
            //return _lista.GetEnumerator();
            return _BD.ObterCanais().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //return _lista.GetEnumerator();
            return _BD.ObterCanais().GetEnumerator();
        }

        public IEnumerable<Canal> ObterCanais(string Filtro)
        {
            Filtro = Filtro.ToLower().Trim();
            if (string.IsNullOrEmpty(Filtro))
                return _BD.ObterCanais();
            else
            {
                List<Canal> aux = new List<Canal>();
                foreach (Canal a in _BD.ObterCanais())
                    if (Valido(a, Filtro))
                        aux.Add(a);
                return aux;
            }
        }

        private bool Valido(Canal a, string Filtro)
        {
            return a.Nome.ToLower().Contains(Filtro) || a.Grupo.ToString().Contains(Filtro) || a.URL.ToString().Contains(Filtro);
        }

        public User logar(string nome, string senha)
        {
            if(_BD.userLog(nome, senha) != null)
                return _BD.userLog(nome, senha);
            else
                return null;
        }

        public IEnumerable<Canal> ObterCanaisFav(User u)
        {
            return _BD.ObterCanaisFav(u);   
        }

        public void Favoritar(User u, Canal a)
        {
            _BD.Fav(u, a);
        }

        public void Desfavoritar(User u, Canal a)
        {
            _BD.Unfav(u, a);
        }

        public void Cadastro(User u)
        {
            _BD.signin(u);
        }

    }
}

