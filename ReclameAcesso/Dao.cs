using MySql.Data.MySqlClient;
using ReclameAcesso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso
{
    class Dao : IDao
    {

        MySqlConnection conexao;
        public Dao()
        {
            try
            {

                ComandoDBConectar();
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


    }
}
