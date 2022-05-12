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
        public string ComandoAtualizar { get; set; }
        public string ComandoDeletar { get; set; }
        public string ComandoSelect { get; set; }

        public List<string> Colunas { get; set; }
        public List<string> Linhas { get; set; }


        public MessageBoxButtons BotaoOk { get; set; }
        public MessageBoxButtons BotaoCancel { get; set; }

        public Tabela(string nomeTabela, string parametros, string valores)
        {
            BotaoOk = 0;
            BotaoCancel = (MessageBoxButtons)1;
            
            ComandoInserir = $"INSERT INTO {nomeTabela} ({parametros}) values ({valores})";
            ComandoSelect = $"SELECT * FROM {nomeTabela}";

            //FACTORY AQUI
            Colunas = new List<string>();

            Colunas.Add("@Nome");
            Colunas.Add("@Endereco");
            Colunas.Add("@Email");

        }

    }
}
