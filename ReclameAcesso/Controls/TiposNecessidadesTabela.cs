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
    public class TiposNecessidadesTabela : Dao, ITiposNecessidadesTabela
    {
        TiposNecessidades tipoNecessidade;
        public TiposNecessidadesTabela()
        {
            tipoNecessidade = new TiposNecessidades();
        }

        public void Inserir(List<Tabela> novaTabela)
        {
            try
            {
                using (comando = new MySqlCommand(tipoNecessidade.ComandoInserir, conexao))
                {
                    foreach (TiposNecessidades novoTipoNecessidade in novaTabela)
                    {
                        ComandoDBIniciarTransacaoILCommited();

                        comando.Parameters.AddWithValue("@tipoNecessidade", novoTipoNecessidade.TipoNecessidade);

                        comando.ExecuteNonQuery();
                        transacao.Commit();
                    }

                }
            }
            catch (MySqlException e)
            {

                throw;
            }
        }

        public List<TiposNecessidades> Select()
        {
            List<TiposNecessidades> ListaTiposnecessidades = new List<TiposNecessidades>();

            try
            {

                using (comando = new MySqlCommand(ComandoDBSelecionarTudo("Tiposnecessidades"), conexao))
                {
                    comando.ExecuteNonQuery();
                    leitura = comando.ExecuteReader();

                    while (leitura.Read())
                    {
                        TiposNecessidades tiponecessidade = new TiposNecessidades();
                        tiponecessidade.TipoNecessidade = leitura.GetString("tipoNecessidade");

                        ListaTiposnecessidades.Add(tiponecessidade);
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro.\n\nNada foi procurado.", "Ops!", tipoNecessidade.BotaoOk);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }

            return ListaTiposnecessidades;
        }

    }
}
