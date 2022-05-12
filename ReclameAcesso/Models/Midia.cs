using ReclameAcesso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Models
{
    public class Midia : Tabela, ITabela
    {

        public int IdMidia { get; set; }
        public byte[] ArquivoMidia { get; set; }
        public int IdUsuario { get; set; }

        public Midia() : base("midia", "idMidia, arquivomidia, idUsuarios", "'', @ArquivoMidia, @IdUsuarios")
        {
            //DataReader GetBytes();
        }

        public List<string> LerColunas()
        {
            Colunas = new List<string>();
            Colunas.Add("@IdMidia");
            Colunas.Add("@ArquivoMidia");

            return Colunas;
        }

    }
}
