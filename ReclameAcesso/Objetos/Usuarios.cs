using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Objetos
{
    class Usuarios
    {

        public int IdUsuarios { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Usuarios(string nomeTabela = "usuarios", string valores = "IdUsuarios, Nome, Email", string referencias = "'', @Nome, @Email")
        {

        }

    }
}