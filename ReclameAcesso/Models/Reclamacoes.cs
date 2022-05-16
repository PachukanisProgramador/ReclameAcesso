using ReclameAcesso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Models
{
    public class Reclamacoes : Tabela
    {

        public int IdReclamacoes { get; set; }
        public string Texto { get; set; }
        public string TituloTexto { get; set; }
        public bool DanoSofrido { get; set; }
        public long CnpjInstituicao { get; set; }
        public int IdUsuarios { get; set; }
        public int IdTipoNecessidade { get; set; }

        public Reclamacoes() : base("reclamacoes", "IdReclamacoes, Texto, TituloTexto, DanoSofrido, CnpjInstituicao, IdUsuarios, IdTipoNecessidade", "'', @Texto, @TituloTexto, @DanoSofrido, @CnpjInstituicao, @IdUsuarios, @IdTipoNecessidade")
        {

        }
    }
}
