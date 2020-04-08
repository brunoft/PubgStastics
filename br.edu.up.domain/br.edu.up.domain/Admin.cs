using System;
using System.Collections.Generic;
using System.Text;

namespace br.edu.up.domain
{
    class Admin
    {
        public Admin() { ApisPubg = new List<ApiPubg>(); }

        private int id { get; set; }
        private int nomeAdm { get; set; }
        private string email { get; set; }

        public Login Login { get; set; }

        public List<ApiPubg> ApisPubg { get; set; }

        void excluirUsuario()
        {


        }
        void atualizarCadastro()
        {


        }

    }
}
