using ReclameAcesso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Models
{
    public class Midia : Tabela
    {

        public int IdMidia { get; set; }
        public byte[] ArquivoMidia { get; set; }
        public int IdUsuarios { get; set; }
        public string CaminhoMidia { get; set; }

        public Midia() : base("midia", "idMidia, arquivomidia, idUsuarios, caminhoMidia", "'', @ArquivoMidia, @IdUsuarios, @CaminhoMidia")
        {

        }
    }
}
