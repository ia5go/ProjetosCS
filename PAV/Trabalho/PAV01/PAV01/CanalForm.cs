using System;
using System.Drawing;
using System.Windows.Forms;
using PAV01.Negocio;
using Banco;

namespace PAV01
{
	public partial class CanalForm : Form
	{
		public CanalForm()
		{
			InitializeComponent();
		}
		
        private static CanalForm _instancia=null;
        public static bool Executar(Canal a)
        {
            if (_instancia == null)
                _instancia = new CanalForm();

            _instancia.AtualizarTela(a);
            bool r = _instancia.ShowDialog() == DialogResult.OK;
            if (r)
                _instancia.AtualizarCanal(a);
            return r;

        }

        private void AtualizarTela(Canal a)
        {
            txtNome.Text = a.Nome;
            txtGrupo.Text = a.Grupo;
            txtURL.Text = a.URL;
        }

        private void AtualizarCanal(Canal a)
        {
            a.Nome = txtNome.Text;
            a.Grupo = txtGrupo.Text;
            a.URL = txtURL.Text;
        }
		
	}
}
