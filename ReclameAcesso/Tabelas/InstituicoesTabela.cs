using MySql.Data.MySqlClient;
using ReclameAcesso.Interfaces;
using ReclameAcesso.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReclameAcesso.Tabelas
{
    class InstituicoesTabela : Instituicoes //IInstituicoesTabela
    {
        private string ComandoInserir { get; set; }
        private string ComandoAtualizar { get; set; }
        private string ComandoDeletar { get; set; }

        private MessageBoxButtons BotaoOk { get; set; }
        private MessageBoxButtons BotaoCancel { get; set; }

        Dao dao;


        public InstituicoesTabela(string nomeTabela, string valores, string referencias) : base(nomeTabela, valores, referencias)
        {
            dao = new Dao();
            BotaoOk = 0;
            BotaoCancel = (MessageBoxButtons)1;

            ComandoInserir = $"INSERT INTO {nomeTabela} ({valores}) values ({referencias})";
            ComandoAtualizar = $"UPDATE {nomeTabela} SET @campo = '@novoDado' WHERE idinstituicoes = '@IdInstituicoes' ";
            ComandoDeletar = $"DELETE FROM {nomeTabela} WHERE idinstituicoes = @IdInstituicoes";

        }

    }
}
