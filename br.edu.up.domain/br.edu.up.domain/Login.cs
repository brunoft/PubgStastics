using System;
using System.Collections.Generic;
using System.Text;

namespace br.edu.up.domain
{
    class Login
    {
        public Login () { Clientes = new List<Cliente>(); }
        private int id { get; set; }
        private int idCliente { get; set; }
        private string senha { get; set; }
        private string estadoLogin { get; set; }
        private DateTime dataCadastro { get; set; }

        public Admin  Gerenciador { get; set; }

        public List<Cliente> Clientes { get; set; }


        void verificaLogin()
        {


        }


    }
}
