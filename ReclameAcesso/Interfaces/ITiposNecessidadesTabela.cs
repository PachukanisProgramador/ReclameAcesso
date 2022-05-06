using ReclameAcesso.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Interfaces
{
    interface ITiposNecessidadesTabela
    {
        List<TiposNecessidades> LerDados();
        void Inserir(TiposNecessidades novoTipoNecessidade);
        void Atualizar(string campo, string novoDado, TiposNecessidades tipoNecessidade);
        void Deletar(TiposNecessidades tipoNecessidade);
        void Consultar(TiposNecessidades TiposNecessidades);
        void ConsultarIndividual(TiposNecessidades tipoNecessidade, string id, string idValor);

    }
}
