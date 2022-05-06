using ReclameAcesso.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Interfaces
{
    interface IInstituicoesTabela
    {
        List<Instituicoes> LerDados();
        void Inserir(Instituicoes novaInstituicao);
        void Atualizar(string campo, string novoDado, Instituicoes instituicao);
        void Deletar(Instituicoes instituicao);
        void Consultar(Instituicoes instituicoes);
        void ConsultarIndividual(Instituicoes instituicao, string id, string idValor);

    }
}
