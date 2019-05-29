using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Banco;

namespace PAV01.Negocio
{
    public class Canal
    {

        private int _ID;//ID do canal
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Nome;//nome do canal
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
        private string _Grupo;//tipo de canal
        public string Grupo
        {
            get { return _Grupo; }
            set { _Grupo = value; }
        }
        private string _URL;
        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
        }
    }
}
