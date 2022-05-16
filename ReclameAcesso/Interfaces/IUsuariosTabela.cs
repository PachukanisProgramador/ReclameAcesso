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
        Usuarios SelectLinha(int idValor);
    }
}
