using System;
using System.Collections.Generic;
using System.Text;

namespace br.edu.up.domain
{
    class ClassificacaoGeral
    {
        public ClassificacaoGeral() { Clientes = new List<Cliente>(); }

        private int id { get; set; }
        private int idCliente { get; set; }
        private string nomeCliente { get; set; }

        private string dataClassificacao { get; set; }

        public List<Cliente> Clientes { get; set; }
        void cadastrarClassificacao()
        {


        }

        void consultarClassificacao()
        {

        }

        void deletarClassificacao()
        {

        }

    }
}
