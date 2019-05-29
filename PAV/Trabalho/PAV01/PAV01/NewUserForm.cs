using System;
using System.Drawing;
using System.Windows.Forms;
using PAV01.Negocio;
using Banco;

namespace PAV01
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private static NewUserForm _instancia = null;
        public static bool Run(User u)
        {
            if (_instancia == null)
                _instancia = new NewUserForm();
            
            bool r = _instancia.ShowDialog() == DialogResult.OK;
            if (r)
                _instancia.AtualizarUsuario(u);
            return r;

        }

        private void AtualizarUsuario(User u)
        {
            u.Nome = txtNome.Text;
            u.Senha = txtSenha.Text;
        }

    }
}
