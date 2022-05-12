using ReclameAcesso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Interfaces
{
    interface ITiposNecessidadesTabela
    {
        void Inserir(List<Tabela> novaTabela);
        List<TiposNecessidades> Select();
    }
}
