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
        public InstituicoesTabela()
        {
            instituicao = new Instituicoes();
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
                        Instituicoes instituicaoConsultada = new Instituicoes()
                        {
                            IdInstituicoes = leitura.GetInt32("idInstituicoes"),
                            Nome = leitura.GetString("nome"),
                            Endereco = leitura.GetString("endereco"),
                            Email = leitura.GetString("email"),
                            IdTipoNecessidade = leitura.GetInt32("idTiposNecessidades")
                        };



                        listaInstituicoes.Add(instituicaoConsultada);
                    }
                }
            }
            catch (MySqlException e)
            {

                MessageBox.Show($"Erro.\n\nNada foi procurado em Instituições.\n\n{e}", "Ops!", MessageBoxButtons.OK);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }
            return listaInstituicoes;
        }
    }
}
