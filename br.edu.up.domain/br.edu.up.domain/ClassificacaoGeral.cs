using System;
using System.Collections.Generic;
using System.Text;

namespace br.edu.up.domain
{
    class ClassificacaoGeral
    {
        public ClassificacaoGeral() { Clientes = new List<Cliente>(); }

        public int id { get; set; }
        public int idCliente { get; set; }
        public string nomeCliente { get; set; }

        public string dataClassificacao { get; set; }

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
