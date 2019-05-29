using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAV01
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private static About _instancia = null;
        public static bool Go()
        {
            if (_instancia == null)
                _instancia = new About();

            bool r = _instancia.ShowDialog() == DialogResult.OK;
            return r;

        }
    }
}
