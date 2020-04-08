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

        public int id { get; set; }
        public string nomeCliente { get; set; }
        public DateTime dataNasc { get; set; }
        public string sexo { get; set; }
        public string email { get; set; }


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
