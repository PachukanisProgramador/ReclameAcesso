using ReclameAcesso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Models
{
    public class Instituicoes : Tabela, ITabela
    {

        public int IdInstituicoes { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public int IdTipoNecessidade { get; set; }


        public Instituicoes() : base("Instituicoes", "IdInstituicoes, Nome, Endereco, Email, idTiposNecessidades", "'', @Nome, @Endereco, @Email, @IdTiposNecessidades")
        {

        }

        public List<string> LerColunas()
        {
            Colunas = new List<string>();
            Colunas.Add("@Nome");
            Colunas.Add("@Endereco");
            Colunas.Add("@Email");



            return Colunas;
        }

        public List<Instituicoes> LerDados()
        {
            List<Instituicoes> instituicao = new List<Instituicoes>();

            return instituicao;
        }
    }
}
