using System;
using System.Collections.Generic;
using System.Text;

namespace br.edu.up.domain
{
    class Admin
    {
        public Admin() { ApisPubg = new List<ApiPubg>(); }

        public int id { get; set; }
        public int nomeAdm { get; set; }
        public string email { get; set; }

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
