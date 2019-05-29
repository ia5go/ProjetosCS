using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Banco;

namespace PAV01.Negocio
{
    public class User
    {
        private int _ID;//id do usuário
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Nome;//nome do usuário
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _senha;//nome do canal
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        private string _status;//nome do canal
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
