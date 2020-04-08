using System;
using System.Collections.Generic;
using System.Text;

namespace br.edu.up.domain
{
    class PerfilFavorito
    {
        public PerfilFavorito() { Clientes = new List<Cliente>(); }
        public int id { get; set; }
        public int idCliente { get; set; }
        public string nomeCliente { get; set; }
        public List<Cliente> Clientes { get; set; }

        void adicionarFavorito()
        {


        }

        void alterarFavorito()
        {

        }

        void deletarFavorito()
        {

        }

    }
}
