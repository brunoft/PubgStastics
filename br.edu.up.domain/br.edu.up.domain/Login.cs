using System;
using System.Collections.Generic;
using System.Text;

namespace br.edu.up.domain
{
    class Login
    {
        public Login () { Clientes = new List<Cliente>(); }
        public int id { get; set; }
        public int idCliente { get; set; }
        public string senha { get; set; }
        public string estadoLogin { get; set; }
        public DateTime dataCadastro { get; set; }

        public Admin  Gerenciador { get; set; }

        public List<Cliente> Clientes { get; set; }


        void verificaLogin()
        {


        }


    }
}
