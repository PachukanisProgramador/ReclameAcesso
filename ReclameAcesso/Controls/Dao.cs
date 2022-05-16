using MySql.Data.MySqlClient;
using ReclameAcesso.Factories;
using ReclameAcesso.Interfaces;
using ReclameAcesso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReclameAcesso.Controls
{
    public abstract class Dao : IDao
    {

        protected MySqlCommand comando;
        protected MySqlTransaction transacao;
        protected MySqlConnection conexao;
        protected MySqlDataReader leitura;

        protected System.Data.ConnectionState estadoConexao;

        public Dao()
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=reclameAcesso;Uid=root;Pwd=;");
                estadoConexao = conexao.State;
                conexao.Open();
                Console.WriteLine("Bem vindo - Conexão extabelecida!\n\n");

            }
            catch (Exception mensagemErro)
            {

                conexao.Close();

                Console.WriteLine($"Erro de conexão com o banco de dados!\n\n{mensagemErro}");

            }


        }





        public void ComandoDBConectar()
        {
            conexao = new MySqlConnection("Server=localhost;Database=reclameAcessoNovo;Uid=root;Pwd=myPassword;");
            conexao.Open();
        }





        public void ComandoChecarConexaoAberta()
        {
            if (estadoConexao == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }





        public void ComandoChecarConexaoFechada()
        {
            if (estadoConexao == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
        }





        public void ComandoDBIniciarTransacaoILCommited()
        {
            transacao = conexao.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            comando.Transaction = transacao;
        }
    }
}

