//fote de icones: https://pt.icons8.com/icon/set/right/all
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PAV01.Negocio;
using Banco;


namespace PAV01
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Lista C = new Lista();
		public MainForm()
		{
			
			InitializeComponent();

            #region População inicial para verificação(Comentado)

            /*Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Canal a = new Canal();
                a.Nome = "Nome " + (i + 11);//não sei oq ele está contatenando no campo
                a.Grupo = "Grupo " + (i + 11);
                a.URL = "URL " + (i + 11);
                C.Inserir(a);
            }*/

            #endregion

            Atualizar();
		}

        private static MainForm _instancia = null;
        public static bool Execute()
        {
            if (_instancia == null)
                _instancia = new MainForm();

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

            lvwCanais.Items.Clear();
            int i=1;
            foreach (Canal a in C.ObterCanais(edtFiltro.Text))
            {
                ListViewItem item = new ListViewItem(i.ToString("000"));
                item.Tag = a;
                item.SubItems.Add(a.Nome.ToString());
                item.SubItems.Add(a.Grupo.ToString());
                item.SubItems.Add(a.URL.ToString());
                lvwCanais.Items.Add(item);
                i++;
            }
        }
		
		private void Acao(object sender, EventArgs e)
        {
            if (sender == bntFiltro || sender == edtFiltro)
                Atualizar();
            else if (sender == bntVoltar)
            {
                Close();
            }
            else if (sender == bntAdd)
            {
                Canal x = new Canal();
                if (CanalForm.Executar(x))
                {
                    C.Inserir(x);
                    edtFiltro.Clear();
                    Atualizar();
                }
            }
            else if (sender == bntDel)
            {
                if (lvwCanais.SelectedItems.Count != 1)
                    MessageBox.Show("Selecione um Canal para remover", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Canal a = (Canal)lvwCanais.SelectedItems[0].Tag;
                    if (MessageBox.Show("Tem certeza que deseja remover o Canal:" + a.Nome + "?", "Remover Canal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        C.Remover(a.Nome);
                        Atualizar();
                    }
                }
            }
            else if (sender == btnAbrir)
            {
                if (lvwCanais.SelectedItems.Count != 1)
                    MessageBox.Show("Selecione um Canal para VER O VIDEO", "VER VIDEO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Canal a = (Canal)lvwCanais.SelectedItems[0].Tag;
                    Executar(a.URL);
                }
            }
            else if (sender == bntEdit)
            {
                if (lvwCanais.SelectedItems.Count != 1)
                    MessageBox.Show("Selecione um Canal para Editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Canal a = (Canal)lvwCanais.SelectedItems[0].Tag;
                    string NomeAnterior = a.Nome;
                    if (CanalForm.Executar(a))
                    {
                        C.Alterar(NomeAnterior, a);
                        edtFiltro.Clear();
                        Atualizar();
                    }
                }
            }


        }
		
		private void lvwCanais_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Acao(bntEdit, e);
        }
		void LvwCanaisSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}

        private void bntAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void lvwCanais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Executar(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception)
            { }
        }
    }
}

