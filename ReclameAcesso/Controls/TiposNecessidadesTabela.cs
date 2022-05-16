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
        TiposNecessidades tiposNecessidades;

        public TiposNecessidadesTabela()
        {
            tiposNecessidades = new TiposNecessidades();
        }





        public List<TiposNecessidades> Select()
        {
            List<TiposNecessidades> ListaTiposnecessidades = new List<TiposNecessidades>();

            try
            {

                using (comando = new MySqlCommand(tiposNecessidades.ComandoSelect, conexao))
                {
                    comando.ExecuteNonQuery();
                    leitura = comando.ExecuteReader();

                    while (leitura.Read())
                    {
                        TiposNecessidades tipoNecessidade = new TiposNecessidades()
                        {
                            IdTiposNecessidades = leitura.GetInt32("IdTiposNecessidades"),
                            TipoNecessidade = leitura.GetString("tipoNecessidade")
                        };

                        ListaTiposnecessidades.Add(tipoNecessidade);
                    }
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show($"Erro.\n\nNada foi procurado.\n\n{erro.Message}", "Ops!", MessageBoxButtons.OK);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }

            return ListaTiposnecessidades;
        }

    }
}
