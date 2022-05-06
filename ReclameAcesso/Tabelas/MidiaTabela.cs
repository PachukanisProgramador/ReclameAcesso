using MySql.Data.MySqlClient;
using ReclameAcesso.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReclameAcesso.Tabelas
{
    class MidiaTabela : Midia
    {
        private string ComandoInserir { get; set; }
        private string ComandoAtualizar { get; set; }
        private string ComandoDeletar { get; set; }

        private MessageBoxButtons BotaoOk { get; set; }
        private MessageBoxButtons BotaoCancel { get; set; }

    }
}
