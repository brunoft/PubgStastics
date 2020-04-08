using System;
using System.Collections.Generic;
using System.Text;

namespace br.edu.up.domain
{
    class ApiPubg
    {
        public ApiPubg() { Clientes = new List<Cliente>(); }

        public int id { get; set; }
        public string keyApi { get; set; }
        public int ClienteId { get; set; }

        public  Admin  adminApi { get; set; }
        public List<Cliente> Clientes { get; set; }

        void consultarJogadores()
        {


        }

        void pefilJogador()
        {


        }

        void classificao()
        {


        }

    }
}
