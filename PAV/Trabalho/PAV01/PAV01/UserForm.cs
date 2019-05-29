using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PAV01.Negocio;
using Banco;

namespace PAV01
{
    public partial class UserForm : Form
    {
        private Lista C = new Lista();
        private User usuario = null;
        public UserForm(User u)
        {
            InitializeComponent();

            usuario = u;

            AtualizarAll();
            AtualizarFav(u);
        }

        private static UserForm _instancia = null;
        public static bool ExecuteUser(User u)
        {
            if (_instancia == null)
                _instancia = new UserForm(u);
            

            _instancia.AtualizarAll();
            _instancia.AtualizarFav(u);
            bool r = _instancia.ShowDialog() == DialogResult.OK;
            if (r)
            {
                _instancia.AtualizarAll();
                _instancia.AtualizarFav(u);
            }

            return r;

        }

        private void AtualizarAll()
        {
            string auxiliar = "";

            lvwAll.Items.Clear();
            int i = 1;
            foreach (Canal a in C.ObterCanais(auxiliar))
            {
                ListViewItem item = new ListViewItem(i.ToString("000"));
                item.Tag = a;
                item.SubItems.Add(a.Nome.ToString());
                item.SubItems.Add(a.Grupo.ToString());
                item.SubItems.Add(a.URL.ToString());
                lvwAll.Items.Add(item);
                i++;
            }
        }

        private void AtualizarFav(User u)
        {
            lvwFav.Items.Clear();
            int i = 1;
            foreach (Canal a in C.ObterCanaisFav(u))
            {
                ListViewItem item = new ListViewItem(i.ToString("000"));
                item.Tag = a;
                item.SubItems.Add(a.Nome.ToString());
                item.SubItems.Add(a.Grupo.ToString());
                item.SubItems.Add(a.URL.ToString());
                lvwFav.Items.Add(item);
                i++;
            }
        }

        private void Acao(object sender, EventArgs e)
        {
            if (sender == btnFav)
            {
                if (lvwAll.SelectedItems.Count != 1)
                    MessageBox.Show("Selecione um Canal da lista geral para tornar favorito", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Canal a = (Canal)lvwAll.SelectedItems[0].Tag;
                    if (MessageBox.Show("Tem certeza que deseja adicionar o Canal:" + a.Nome + " aos favoritos?", "Favoritar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        C.Favoritar(_instancia.usuario, a);
                        AtualizarAll();
                        AtualizarFav(_instancia.usuario);
                    }
                }
            }
            if (sender == btnUnfav)
            {
                if (lvwFav.SelectedItems.Count != 1)
                    MessageBox.Show("Selecione um Canal da lista de favoritos para remover", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Canal a = (Canal)lvwFav.SelectedItems[0].Tag;
                    if (MessageBox.Show("Tem certeza que deseja remover o Canal:" + a.Nome + " dos favoritos?", "Desfavoritar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        C.Desfavoritar(_instancia.usuario, a);
                        AtualizarAll();
                        AtualizarFav(_instancia.usuario);
                    }
                }
            }
            if (sender == btnRefresh)
            {
                AtualizarAll();
                AtualizarFav(_instancia.usuario);
            }
            if (sender == btnSair)
                Close();
        }

    }
}
