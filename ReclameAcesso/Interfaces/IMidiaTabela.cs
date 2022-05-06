using ReclameAcesso.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Interfaces
{
    interface IMidiaTabela
    {
        List<Midia> LerDados();
        void Inserir(Midia novaMidia);
        void Atualizar(string campo, string novoDado, Midia midia);
        void Deletar(Midia midia);
        void Consultar(Midia midias);
        void ConsultarIndividual(Midia midia, string id, string idValor);
    }
}
