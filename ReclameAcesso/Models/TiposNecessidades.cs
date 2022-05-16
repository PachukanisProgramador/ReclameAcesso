using ReclameAcesso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Models
{
    public class TiposNecessidades : Tabela
    {

        public int IdTiposNecessidades { get; set; }
        public string TipoNecessidade { get; set; }

        public TiposNecessidades() : base("tiposnecessidades", "IdTiposNecessidades, tipoNecessidade", "'', @tipoNecessidade")
        {

        }
    }
}
