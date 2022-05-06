using ReclameAcesso.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Interfaces
{
    interface IUsuariosTabela
    {
        List<Usuarios> LerDados();        
        void Inserir(Usuarios novoUsuario);
        void Atualizar(string campo, string novoDado, Usuarios usuario);
        void Deletar(Usuarios usuario);
        void Consultar(Usuarios usuarios);
        void ConsultarIndividual(Usuarios usuario, string id, string idValor);
    }
}
