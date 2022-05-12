using ReclameAcesso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Interfaces
{
    interface IUsuariosTabela
    {      
        int Inserir(Usuarios novoUsuario);
        List<Tabela> Select();
        Usuarios ConsultarIdUsuarios(List<Tabela> ListaUsuario, string idValor);
    }
}
