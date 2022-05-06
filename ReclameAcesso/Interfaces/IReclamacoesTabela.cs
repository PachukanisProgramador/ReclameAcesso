using ReclameAcesso.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Interfaces
{
    interface IReclamacoesTabela
    {
        List<Reclamacoes> LerDados();
        void Inserir(Reclamacoes novaReclamacao);
        void Atualizar(string campo, string novoDado, Reclamacoes reclamacao);
        void Deletar(Reclamacoes reclamacao);
        void Consultar(Reclamacoes reclamacoes);
        void ConsultarIndividual(Reclamacoes reclamacao, string id, string idValor);
    }
}
