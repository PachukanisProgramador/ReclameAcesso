using ReclameAcesso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Interfaces
{
    interface IMidiaTabela
    {

        byte[] CarregarMidia(string caminhoMidia);
        void Inserir(byte[] midiaData, int usuarioId);

    }
}

//List<Midia> LerDados();
//void Atualizar(string campo, string novoDado, Midia midia);
//void Deletar(Midia midia);
//void Consultar(Midia midias);
//void ConsultarIndividual(Midia midia, string id, string idValor);
