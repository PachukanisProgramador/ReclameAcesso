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
        public int IdMidia { get; set; }

        public ReclamacoesTabela()
        {
            reclamacao = new Reclamacoes();
        }

        public void Inserir(Reclamacoes novaReclamacao, int usuarioId)
        {
            MidiaTabela midiaTabela = new MidiaTabela();

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
                        comando.Parameters.AddWithValue("@TipoNecessidade", novaReclamacao.TipoNecessidade);

                        comando.ExecuteNonQuery();
                        transacao.Commit();
                    }
                }

            }
            catch (MySqlException e)
            {

                transacao.Rollback();
                MessageBox.Show($"Erro.\n\nNada foi inserido em ReclamacoesTabela.\n\n{e}", "Ops!", reclamacao.BotaoOk);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }
        }

        public List<Reclamacoes> Select()
        {
            List<Reclamacoes> ListaReclamacoes = new List<Reclamacoes>();

            try
            {
                using (comando = new MySqlCommand(ComandoDBSelecionarTudo("reclamacoes"), conexao))
                {
                    comando.ExecuteNonQuery();
                    leitura = comando.ExecuteReader();

                    while (leitura.Read())
                    {
                        Reclamacoes reclamacaoConsultada = new Reclamacoes();
                        reclamacaoConsultada.Texto = leitura.GetString("texto");
                        reclamacaoConsultada.TituloTexto = leitura.GetString("tituloTexto");
                        reclamacaoConsultada.DanoSofrido = leitura.GetBoolean("danoSofrido");
                        reclamacaoConsultada.CnpjInstituicao = (long)leitura.GetDouble("CnpjInstituicaoReclamada");
                    }
                }
            }
            catch (MySqlException e)
            {
                transacao.Rollback();
                MessageBox.Show($"Erro.\n\nNada foi cconsultado em Reclamacoes.\n\n{e}", "Ops!", reclamacao.BotaoOk);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }
            return ListaReclamacoes;
        }

    }
}
