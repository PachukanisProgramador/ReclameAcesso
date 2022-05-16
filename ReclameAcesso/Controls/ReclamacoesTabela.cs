using MySql.Data.MySqlClient;
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
    public class ReclamacoesTabela : Dao, IReclamacoesTabela
    {
        Reclamacoes reclamacao;

        public ReclamacoesTabela()
        {
            reclamacao = new Reclamacoes();
        }





        public void Inserir(Reclamacoes novaReclamacao, int usuarioId)
        {
            try
            {
                if (novaReclamacao == null)
                {

                }
                else
                {
                    using (comando = new MySqlCommand(reclamacao.ComandoInserir, conexao))
                    {
                        ComandoDBIniciarTransacaoILCommited();

                        comando.Parameters.AddWithValue("@Texto", novaReclamacao.Texto);
                        comando.Parameters.AddWithValue("@TituloTexto", novaReclamacao.TituloTexto);
                        comando.Parameters.AddWithValue("@DanoSofrido", Convert.ToByte(novaReclamacao.DanoSofrido));
                        comando.Parameters.AddWithValue("@CnpjInstituicao", novaReclamacao.CnpjInstituicao);
                        comando.Parameters.AddWithValue("@IdUsuarios", usuarioId);
                        comando.Parameters.AddWithValue("@IdTipoNecessidade", novaReclamacao.IdTipoNecessidade);

                        comando.ExecuteNonQuery();
                        transacao.Commit();
                    }
                }

            }
            catch (MySqlException e)
            {

                transacao.Rollback();
                MessageBox.Show($"Erro.\n\nNada foi inserido em ReclamacoesTabela.\n\n{e}", "Ops!", MessageBoxButtons.OK);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }
        }





        public Reclamacoes SelectLinha(int idValor)
        {
            Reclamacoes reclamacao = new Reclamacoes();

            try
            {
                using (comando = new MySqlCommand($"SELECT * FROM Reclamacoes WHERE idUsuarios = '{idValor}'", conexao))
                {
                    comando.ExecuteNonQuery();
                    leitura = comando.ExecuteReader();

                    while (leitura.Read())
                    {
                        reclamacao.IdReclamacoes = leitura.GetInt32("idReclamacoes");
                        reclamacao.Texto = leitura.GetString("texto");
                        reclamacao.TituloTexto = leitura.GetString("tituloTexto");
                        reclamacao.DanoSofrido = leitura.GetBoolean("danoSofrido");
                        reclamacao.CnpjInstituicao = (long)leitura.GetDouble("CnpjInstituicao");
                        reclamacao.IdUsuarios = leitura.GetInt32("idusuarios");
                        reclamacao.IdTipoNecessidade = leitura.GetInt32("idTipoNecessidade");
                    }
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao ler reclamacoes.\n\n{erro.Message}", "Ops!", MessageBoxButtons.OK);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }
            return reclamacao;
        }
    }
}
