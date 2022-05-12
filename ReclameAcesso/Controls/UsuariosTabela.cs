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
    public class UsuariosTabela : Dao //IUsuariosTabela
    {
        Usuarios usuario;
        MidiaTabela midiaTabela;
        ReclamacoesTabela reclamacaoTabela;
        public UsuariosTabela()
        {
            usuario = new Usuarios();
            midiaTabela = new MidiaTabela();
            reclamacaoTabela = new ReclamacoesTabela();
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

                    midiaTabela.IdUsuario = Convert.ToInt32(comando.ExecuteScalar());
                    transacao.Commit();

                    return midiaTabela.IdUsuario;
                }
            }
            catch (MySqlException e)
            {

                transacao.Rollback();
                MessageBox.Show($"Erro.\n\nNada foi inserido em UsuáriosTabela.\n\n{e}", "Ops!", usuario.BotaoOk);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }

            return Convert.ToInt32(null);
        }

        public List<Usuarios> Select()
        {
            List<Usuarios> ListaUsuarios = new List<Usuarios>();

            try
            {

                using (comando = new MySqlCommand(ComandoDBSelecionarTudo("usuarios"), conexao))
                {
                    comando.ExecuteNonQuery();

                    leitura = comando.ExecuteReader();

                    while (leitura.Read())
                    {
                        Usuarios usuario = new Usuarios();
                        usuario.IdUsuarios = leitura.GetInt32("idusuarios");
                        usuario.Nome = leitura.GetString("nome");
                        usuario.Email = leitura.GetString("email");

                        ListaUsuarios.Add(usuario);
                    }
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Erro.\n\nNada foi procurado.", "Ops!", usuario.BotaoOk);
            }
            finally
            {
                ComandoChecarConexaoAberta();
            }

            return ListaUsuarios;
        }

        public Usuarios ConsultarIdUsuarios(List<Tabela> ListaUsuario, string idValor)
        {

            using (comando = new MySqlCommand(ComandoDBSelecionarLinha("usuarios", "IdUsuarios", idValor), conexao))
            {
                foreach (Usuarios usuarioAlvo in ListaUsuario)
                {
                    if (Convert.ToString(usuarioAlvo.IdUsuarios) == idValor)
                    {
                        return usuarioAlvo;
                    }
                }

            }
            return null;
        }

    }
}
//public List<Usuarios> RegistrarListaUsuario(string nome, string email)
//{

//    try
//    {
//        List<Usuarios> novoUsuario = new List<Usuarios>();
//        Usuarios usuario = new Usuarios();

//        usuario.Nome = nome;
//        usuario.Email = email;

//        novoUsuario.Add(usuario);

//        return novoUsuario;
//    }
//    catch (Exception erroMensagem)
//    {
//        Console.WriteLine($"Nada foi registrado na lista.\n\n{erroMensagem}");
//    }

//    return null;
//}
//public void Atualizar(string campo, string novoDado, Usuarios usuario)
//{
//    try
//    {

//        using (dao.comando = new MySqlCommand(ComandoAtualizar, dao.conexao, dao.transacao))
//        {
//            dao.ComandoDBIniciarTransacaoILCommited();

//            dao.comando.Parameters.AddWithValue("@campo", campo);
//            dao.comando.Parameters.AddWithValue("@novoDado", novoDado);
//            dao.comando.Parameters.AddWithValue("@idUsuarios", usuario.IdUsuarios);

//            dao.comando.ExecuteNonQuery();
//            dao.transacao.Commit();
//        }

//    }
//    catch (MySqlException)
//    {
//        dao.transacao.Rollback();
//        MessageBox.Show("Erro.\n\nNada foi modificado.", "Ops!", BotaoOk);
//    }
//    finally
//    {
//        dao.conexao.Close();
//    }
//}

//public void Deletar(int idUsuarios)
//{
//    try
//    {
//        dao.ComandoDBIniciarTransacaoILCommited();

//        using (dao.comando = new MySqlCommand(ComandoDeletar, dao.conexao, dao.transacao))
//        {
//            dao.comando.Parameters.AddWithValue("@IdUsuarios", idUsuarios);

//            dao.comando.ExecuteNonQuery();
//            dao.transacao.Commit();
//        }


//    }
//    catch (MySqlException)
//    {
//        dao.transacao.Rollback();
//        MessageBox.Show("Erro.\n\nNada foi deletado.", "Ops!", BotaoOk);
//    }
//    finally
//    {
//        dao.conexao.Close();
//    }
//}
