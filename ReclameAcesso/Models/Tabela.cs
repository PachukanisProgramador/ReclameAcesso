using ReclameAcesso.Controls;
using ReclameAcesso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReclameAcesso.Models
{
    public class Tabela
    {
        public string ComandoInserir { get; set; }
        public string ComandoSelect { get; set; }

        public Tabela(string nomeTabela, string parametros, string valores)
        {
            ComandoInserir = $"INSERT INTO {nomeTabela} ({parametros}) values ({valores})";
            ComandoSelect = $"SELECT * FROM {nomeTabela}";
        }

    }
}
