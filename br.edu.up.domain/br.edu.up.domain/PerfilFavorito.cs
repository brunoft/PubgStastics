using System;
using System.Collections.Generic;
using System.Text;

namespace br.edu.up.domain
{
    class PerfilFavorito
    {
        public PerfilFavorito() { Clientes = new List<Cliente>(); }
        private int id { get; set; }
        private int idCliente { get; set; }
        private string nomeCliente { get; set; }
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
