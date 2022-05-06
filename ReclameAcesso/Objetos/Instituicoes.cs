using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Objetos
{
    class Instituicoes
    {

        public int IdInstituicoes { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        public Instituicoes(string nomeTabela = "instituicoes", string valores = "IdInstituicoes, Nome, Endereco, Email", string referencias = "'', @Nome, @Endereco, @Email")
        {

        }

    }
}
