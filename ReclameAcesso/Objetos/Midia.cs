using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Objetos
{
    class Midia 
{

        public int IdMidia { get; set; }
        public byte[] Foto { get; set; }
        public byte[] Audio { get; set; }
        public byte[] Video { get; set; }

        public Midia(string nomeTabela = "midia")
        {

            //DataReader GetBytes();

        }

    }
}
