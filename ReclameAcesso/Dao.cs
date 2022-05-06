﻿using MySql.Data.MySqlClient;
using ReclameAcesso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReclameAcesso
{
    class Dao : IDao
    {

        public MySqlCommand comando;
        public MySqlTransaction transacao;
        public MySqlConnection conexao;
        public MySqlDataReader leitura;
        public System.Data.ConnectionState estadoConexao;
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

        public string ComandoDBSelecionarTudo(string nomeTabela)
        {
            return $"SELECT * from {nomeTabela}";
        }

        public string ComandoDBSelecionarLinha(string nomeTabela, string id, string idValor)
        {
            return $"SELECT * from {nomeTabela} WHERE {id} = '{idValor}'";
        }
    }
}
