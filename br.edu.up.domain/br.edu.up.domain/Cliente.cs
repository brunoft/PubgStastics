using System;
using System.Collections.Generic;
using System.Text;

namespace br.edu.up.domain
{
    class Cliente
    {
       
        public Cliente() { 
            PerfilFavoritos = new List<PerfilFavorito>();
            ClassificacoesGerais = new List<ClassificacaoGeral>();
        }

        private int id { get; set; }
        private string nomeCliente { get; set; }
        private DateTime dataNasc { get; set; }
        private string sexo { get; set; }
        private string email { get; set; }


        public Login MeuLogin { get; set; }
        public PerfilPubg MeuPerfil { get; set; }
        public ApiPubg Api { get; set; }

        public List<PerfilFavorito> PerfilFavoritos { get; set; }
        public List<ClassificacaoGeral> ClassificacoesGerais { get; set; }

        void cadastrarUsuario()
        {


        }

        void deletarUsuario()
        {

        }

        void alterarUsuario()
        {

        }

    }
}
