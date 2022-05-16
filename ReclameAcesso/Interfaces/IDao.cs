using ReclameAcesso.Models;
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
        void ComandoChecarConexaoAberta();
        void ComandoChecarConexaoFechada();
        void ComandoDBIniciarTransacaoILCommited();

    }
}
