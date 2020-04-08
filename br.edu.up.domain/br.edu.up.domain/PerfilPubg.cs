using System;
using System.Collections.Generic;
using System.Text;

namespace br.edu.up.domain
{
    class PerfilPubg
    {
        public int id { get; set; }
        public string nomePerfil { get; set; }
        public DateTime dataCriacao { get; set; }
        public string vitorias { get; set; }
        public string totalMortes { get; set; }


        public int ClienteId { get; set; }
        public Cliente ClientePerfil { get; set; }

        void adicionarPerfil()
        {


        }


        void alterarPerfil()
        {

        }

        void deletarPerfil()
        {

        }

    }
}
