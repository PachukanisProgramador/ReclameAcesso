using ReclameAcesso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Models
{
    public class Reclamacoes : Tabela, ITabela
    {

        public int IdReclamacoes { get; set; }
        public string Texto { get; set; }
        public string TituloTexto { get; set; }
        public bool DanoSofrido { get; set; }
        public long CnpjInstituicao { get; set; }
        public int IdUsuarios { get; set; }
        public int IdMidia { get; set; }
        public int TipoNecessidade { get; set; }

        public Reclamacoes() : base("reclamacoes", "IdReclamacoes, Texto, TituloTexto, DanoSofrido, CnpjInstituicao, IdUsuarios, TipoNecessidade", "'', @Texto, @TituloTexto, @DanoSofrido, @CnpjInstituicao, @IdUsuarios, @TipoNecessidade")
        {

        }

        public List<string> LerColunas()
        {
            Colunas = new List<string>();
            Colunas.Add("@IdReclamacoes");
            Colunas.Add("@Texto");
            Colunas.Add("@TituloTexto");
            Colunas.Add("@DanoSofrido");
            Colunas.Add("@CnpjInstituicaoReclamada");
            Colunas.Add("@IdUsuarios");

            return Colunas;
        }
    }
}
