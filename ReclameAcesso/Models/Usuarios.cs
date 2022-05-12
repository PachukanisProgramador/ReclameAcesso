using MySql.Data.MySqlClient;
using ReclameAcesso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Models
{
    public class Usuarios : Tabela, ITabela
    {

        public int IdUsuarios { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Usuarios() : base("usuarios", "IdUsuarios, Nome, Email", "'', @Nome, @Email")
        {

        }

        public List<string> LerColunas()
        {
            Colunas = new List<string>();
            Colunas.Add("@IdUsuarios");
            Colunas.Add("@Nome");
            Colunas.Add("@Email");

            return Colunas;
        }
    }
}