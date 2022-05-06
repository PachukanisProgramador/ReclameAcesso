using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Interfaces
{
    interface IDao
    {

        void ComandoDBConectar();
        void ComandoDBIniciarTransacaoILCommited();
        string ComandoDBSelecionarTudo(string nomeTabela);
        string ComandoDBSelecionarLinha(string nomeTabela, string id, string idValor);
        //void ComandoDBJuntarTabelas();
        void ComandoChecarConexaoAberta();
        void ComandoChecarConexaoFechada();

    }
}
