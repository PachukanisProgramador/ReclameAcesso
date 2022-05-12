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
    public class InstituicoesTabela : Dao, IInstituicoesTabela
    {
        Instituicoes instituicao;
        TabelaFactory tabelaFactory;

        ITabela getTabela;

        public InstituicoesTabela()
        {
            instituicao = new Instituicoes();

            tabelaFactory = new TabelaFactory();

            getTabela = tabelaFactory.GetTabela("instituicoes");
        }





        public void Inserir(List<Tabela> novaTabela)
        {

            try
            {
                using (comando = new MySqlCommand(instituicao.ComandoInserir, conexao))
                {

                    foreach (Instituicoes novaInstituicao in novaTabela)
                    {
                        comando.Parameters.AddWithValue("@Nome", novaInstituicao.Nome); ;
                        comando.Parameters.AddWithValue("@Endereco", novaInstituicao.Endereco);
                        comando.Parameters.AddWithValue("@Email", novaInstituicao.Email);
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Erro.\n\nNada foi inserido em Instituições.\n\n {e}", "Ops!", instituicao.BotaoOk);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }
        }


        public List<Instituicoes> Select()
        {

            List<Instituicoes> listaInstituicoes = new List<Instituicoes>();

            try
            {
                using (comando = new MySqlCommand(instituicao.ComandoSelect, conexao))
                {
                    comando.ExecuteNonQuery();
                    leitura = comando.ExecuteReader();

                    while (leitura.Read())
                    {
                        Instituicoes instituicaoConsultada = new Instituicoes();

                        instituicaoConsultada.IdInstituicoes = leitura.GetInt32("idInstituicoes");
                        instituicaoConsultada.Nome = leitura.GetString("nome");
                        instituicaoConsultada.Endereco = leitura.GetString("endereco");
                        instituicaoConsultada.Email = leitura.GetString("email");
                        instituicaoConsultada.IdTipoNecessidade = leitura.GetInt32("idTiposNecessidades");

                        listaInstituicoes.Add(instituicaoConsultada);
                    }
                }
            }
            catch (MySqlException e)
            {

                MessageBox.Show($"Erro.\n\nNada foi procurado em Instituições.\n\n{e}", "Ops!", instituicao.BotaoOk);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }
            return listaInstituicoes;
        }
    }
}
