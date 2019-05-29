using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PAV01.Negocio;
using Banco;

namespace PAV01
{
    public partial class StartForm : Form
    {
        private Lista C = new Lista();
        public StartForm()
        {
            InitializeComponent();

            Atualizar();
        }

        private static StartForm _instancia = new StartForm();
        public static bool ExecuteStart()
        {
            if (_instancia == null)
                _instancia = new StartForm();

            _instancia.Atualizar();
            bool r = _instancia.ShowDialog() == DialogResult.OK;
            if (r)
                _instancia.Atualizar();

            return r;

        }

        private static void Shut()
        {
            if (_instancia != null)
                _instancia = null;
        }

        private void Atualizar()
        {
            string auxiliar = "";

            lvwStart.Items.Clear();
            int i = 1;
            foreach (Canal a in C.ObterCanais(auxiliar))
            {
                ListViewItem item = new ListViewItem(i.ToString("000"));
                item.Tag = a;
                item.SubItems.Add(a.Nome.ToString());
                item.SubItems.Add(a.Grupo.ToString());
                item.SubItems.Add(a.URL.ToString());
                lvwStart.Items.Add(item);
                i++;
            }
        }

        private void Acao(object sender, EventArgs e)
        {
            if (sender == btnLogin)
            {
                if (C.logar(LogNome.ToString(), LogSenha.ToString()) != null)
                {
                    MessageBox.Show("Bem vindo, " + LogNome.ToString() + "!", "Bem vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    User u = C.logar(LogNome.ToString(), LogSenha.ToString());
                    if (u.Status == "a")
                    {
                        this.Hide();
                        MainForm.Execute();
                        this.Show();
                    }
                    else if (u.Status == "u")
                    {
                        this.Hide();
                        UserForm.ExecuteUser(u);
                        this.Show();
                    }
                    else
                        MessageBox.Show("Usuário inválido!/n/nChecar banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Nome e/ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (sender == btnSair)
                Application.Exit();

            if(sender == btnSignin)
            {
                User u = new User();
                if (NewUserForm.Run(u))
                {
                    C.Cadastro(u);
                    MessageBox.Show("Usuário registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (sender == btnSobre)
            {
                About.Go();
            }

        }

        public static string getNome()
        {
            return _instancia.LogNome.ToString();
        }

        public static string getPass()
        {
            return _instancia.LogSenha.ToString();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
