using MySql.Data.MySqlClient;
using ReclameAcesso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Models
{
    public class Usuarios : Tabela
    {

        public int IdUsuarios { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Usuarios() : base("usuarios", "IdUsuarios, Nome, Email", "'', @Nome, @Email")
        {

        }
    }
}