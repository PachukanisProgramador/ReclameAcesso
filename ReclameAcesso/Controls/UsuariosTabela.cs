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
    public class UsuariosTabela : Dao, IUsuariosTabela
    {
        Usuarios usuario;

        public UsuariosTabela()
        {
            usuario = new Usuarios();
        }





        public int Inserir(Usuarios novoUsuario)
        {
            try
            {
                using (comando = new MySqlCommand(usuario.ComandoInserir + "; SELECT LAST_INSERT_ID()", conexao, transacao))
                {
                    ComandoDBIniciarTransacaoILCommited();

                    comando.Parameters.AddWithValue("@Nome", novoUsuario.Nome);
                    comando.Parameters.AddWithValue("@Email", novoUsuario.Email);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());
                    transacao.Commit();

                    return resultado;
                }
            }
            catch (MySqlException e)
            {

                transacao.Rollback();
                MessageBox.Show($"Erro.\n\nNada foi inserido em UsuáriosTabela.\n\n{e}", "Ops!", MessageBoxButtons.OK);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }

            return Convert.ToInt32(null);
        }





        public Usuarios SelectLinha(int idValor)
        {
            Usuarios usuario = new Usuarios();

            try
            {
                using (comando = new MySqlCommand($"SELECT * FROM Usuarios WHERE idUsuarios = '{idValor}'", conexao))
                {
                    comando.ExecuteNonQuery();
                    leitura = comando.ExecuteReader();

                    while (leitura.Read())
                    {
                        usuario.IdUsuarios = leitura.GetInt32("IdUsuarios");
                        usuario.Nome = leitura.GetString("Nome");
                        usuario.Email = leitura.GetString("Email");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao ler midia.\n\n{erro.Message}", "Ops!", MessageBoxButtons.OK);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }

            return usuario;
        }
    }
}