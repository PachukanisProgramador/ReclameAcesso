using MySql.Data.MySqlClient;
using ReclameAcesso.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReclameAcesso.Tabelas
{
    class UsuariosTabela : Usuarios
    {

        private string ComandoInserir { get; set; }
        private string ComandoAtualizar { get; set; }
        private string ComandoDeletar { get; set; }

        private MessageBoxButtons BotaoOk { get; set; }
        private MessageBoxButtons BotaoCancel { get; set; }

        Dao dao;


        public UsuariosTabela()
        {
            dao = new Dao();
            BotaoOk = 0;
            BotaoCancel = (MessageBoxButtons)1;

            string nomeTabela = "usuarios";
            string valores = "IdUsuarios, Nome, Email";
            string referencias = "'', @Nome, @Email";

            ComandoInserir = $"INSERT INTO {nomeTabela} ({valores}) values ({referencias})";
            ComandoAtualizar = $"UPDATE {nomeTabela} SET @campo = '@novoDado' WHERE idusuarios = '@IdUsuarios' ";
            ComandoDeletar = $"DELETE FROM {nomeTabela} WHERE idusuarios = @IdUsuarios";

        }

        public List<Usuarios> RegistrarListaUsuario(string nome, string email)
        {

            try
            {
                List<Usuarios> novoUsuario = new List<Usuarios>();
                Usuarios usuario = new Usuarios();

                usuario.Nome = nome;
                usuario.Email = email;

                novoUsuario.Add(usuario);
                
                return novoUsuario;
            }
            catch (Exception erroMensagem)
            {
                Console.WriteLine($"Nada foi registrado na lista.\n\n{erroMensagem}");
            }

            return null;
        }

        public void Inserir(Usuarios novoUsuario)
        {
            try
            {
                using (dao.comando = new MySqlCommand(ComandoInserir, dao.conexao))
                {
                    
                    dao.ComandoDBIniciarTransacaoILCommited();

                    dao.comando.Parameters.AddWithValue("@Nome", novoUsuario.Nome);
                    dao.comando.Parameters.AddWithValue("@Email", novoUsuario.Email);

                    dao.comando.ExecuteNonQuery();
                    dao.transacao.Commit();
                    //novoUsuario.IdUsuarios = (int)dao.comando.ExecuteScalar();
                }

            }
            catch (MySqlException)
            {

                dao.transacao.Rollback();
                MessageBox.Show("Erro.\n\nNada foi inserido.", "Ops!", BotaoOk);
            }
            finally
            {
                dao.ComandoChecarConexaoAberta();
            }
        }

        public void Atualizar(string campo, string novoDado, Usuarios usuario)
        {
            try
            {

                using (dao.comando = new MySqlCommand(ComandoAtualizar, dao.conexao, dao.transacao))
                {
                    dao.ComandoDBIniciarTransacaoILCommited();

                    dao.comando.Parameters.AddWithValue("@campo", campo);
                    dao.comando.Parameters.AddWithValue("@novoDado", novoDado);
                    dao.comando.Parameters.AddWithValue("@idUsuarios", usuario.IdUsuarios);

                    dao.comando.ExecuteNonQuery();
                    dao.transacao.Commit();
                }

            }
            catch (MySqlException)
            {
                dao.transacao.Rollback();
                MessageBox.Show("Erro.\n\nNada foi modificado.", "Ops!", BotaoOk);
            }
            finally
            {
                dao.conexao.Close();
            }
        }

        public void Deletar(int idUsuarios)
        {
            try
            {
                dao.ComandoDBIniciarTransacaoILCommited();

                using (dao.comando = new MySqlCommand(ComandoDeletar, dao.conexao, dao.transacao))
                {
                    dao.comando.Parameters.AddWithValue("@IdUsuarios", idUsuarios);

                    dao.comando.ExecuteNonQuery();
                    dao.transacao.Commit();
                }


            }
            catch (MySqlException)
            {
                dao.transacao.Rollback();
                MessageBox.Show("Erro.\n\nNada foi deletado.", "Ops!", BotaoOk);
            }
            finally
            {
                dao.conexao.Close();
            }
        }

        public List<Usuarios> Consultar(Usuarios usuarios)
        {
            List<Usuarios> consultaUsuarios = new List<Usuarios>();

            try
            {

                using (dao.comando = new MySqlCommand(dao.ComandoDBSelecionarTudo("usuarios"), dao.conexao, dao.transacao))
                {
                    dao.comando.ExecuteNonQuery();

                    dao.leitura = dao.comando.ExecuteReader();

                    while (dao.leitura.Read())
                    {
                        Usuarios usuario = new Usuarios();
                        usuario.IdUsuarios = dao.leitura.GetInt32("idusuarios");
                        usuario.Nome = dao.leitura.GetString("nome");
                        usuario.Email = dao.leitura.GetString("email");

                        consultaUsuarios.Add(usuario);
                    }
                }
            }
            catch (MySqlException)
            {
                dao.conexao.Close();
                MessageBox.Show("Erro.\n\nNada foi procurado.", "Ops!", BotaoOk);
            }
            finally
            {
                dao.conexao.Close();
            }

            return consultaUsuarios;
        }

        public Usuarios ConsultarIndividual(string idValor)
        {
            try
            {

                using (dao.comando = new MySqlCommand(dao.ComandoDBSelecionarLinha("usuarios", "@IdUsuarios", idValor), dao.conexao, dao.transacao))
                {
                    dao.comando.Parameters.AddWithValue("@IdUsuarios", idValor);

                    dao.comando.ExecuteNonQuery();

                    dao.leitura = dao.comando.ExecuteReader();

                    while (dao.leitura.Read())
                    {
                        Usuarios usuarioConsultado = new Usuarios();
                        usuarioConsultado.IdUsuarios = dao.leitura.GetInt32("idusuarios");
                        usuarioConsultado.Nome = dao.leitura.GetString("nome");
                        usuarioConsultado.Email = dao.leitura.GetString("email");

                        return usuarioConsultado;
                    }
                }
            }
            catch (MySqlException)
            {

                MessageBox.Show("Erro.\n\nNada foi procurado.", "Ops!", BotaoOk);
            }
            finally
            {
                dao.conexao.Close();
            }

            return null;

        }
    }
}
