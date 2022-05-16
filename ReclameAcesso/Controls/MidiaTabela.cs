using MySql.Data.MySqlClient;
using ReclameAcesso.Interfaces;
using ReclameAcesso.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReclameAcesso.Controls
{
    public class MidiaTabela : Dao //IMidiaTabela
    {

        Midia midia;

        public MidiaTabela()
        {
            midia = new Midia();
        }





        public byte[] CarregarMidia(string caminhoMidia)
        {
            byte[] midiaData;

            if (caminhoMidia == "")
            {
                midiaData = null;
            }
            else
            {
                using (FileStream transmissao = new FileStream(caminhoMidia, FileMode.Open, FileAccess.Read))
                {
                    BinaryReader leitor = new BinaryReader(transmissao);

                    midiaData = leitor.ReadBytes((int)transmissao.Length);
                }
            }

            return midiaData;
        }





        public void Inserir(byte[] midiaData, int usuarioId, string caminhoMidia)
        {

            try
            {
                if (midiaData == null)
                {

                }
                else
                {
                    using (comando = new MySqlCommand(midia.ComandoInserir + "; SELECT last_insert_id()", conexao, transacao))
                    {
                        ComandoDBIniciarTransacaoILCommited();

                        comando.Parameters.Add(new MySqlParameter("@ArquivoMidia", midiaData));
                        comando.Parameters.AddWithValue("@IdUsuarios", usuarioId);
                        comando.Parameters.AddWithValue("@CaminhoMidia", caminhoMidia);

                        comando.ExecuteNonQuery();
                        transacao.Commit();

                    }
                }

            }
            catch (MySqlException e)
            {

                transacao.Rollback();
                MessageBox.Show($"Erro.\n\nNada foi inserido em Midia.\n\n{e}", "Ops!", MessageBoxButtons.OK);

            }
            finally
            {
                ComandoChecarConexaoAberta();
            }
        }





        public List<Midia> Select()
        {
            List<Midia> ListaMidia = new List<Midia>();
            try
            {
                using (comando = new MySqlCommand(midia.ComandoSelect, conexao))
                {
                    comando.ExecuteNonQuery();
                    leitura = comando.ExecuteReader();

                    while (leitura.Read())
                    {
                        Midia midiaConsultada = new Midia
                        {

                            IdMidia = leitura.GetInt32("IdMidia"),
                            IdUsuarios = leitura.GetInt32("IdUsuarios"),
                            CaminhoMidia = leitura.GetString("CaminhoMidia")
                        };
                        ListaMidia.Add(midiaConsultada);
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Erro.\n\nNada foi consultado em Midia.\n\n{e}", "Ops!", MessageBoxButtons.OK);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }

            return ListaMidia;
        }
    }
}
