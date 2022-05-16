using ReclameAcesso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Interfaces
{
    interface IReclamacoesTabela
    {
        void Inserir(Reclamacoes novaReclamacao, int usuarioId);
        Reclamacoes SelectLinha(int idValor);
    }
}
