using ReclameAcesso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReclameAcesso.Controls
{
    class EmailControl : Dao
    {

        private string DanoSofrido { get; set; }
        private string EmailRemetente { get; set; }
        private string SenhaRemetente { get; set; }

        ReclamacoesTabela reclamacaoTabela;
        MidiaTabela midiaTabela;
        UsuariosTabela usuariosTabela;

        MailMessage mensagemEmail;

        public EmailControl()
        {
            reclamacaoTabela = new ReclamacoesTabela();
            usuariosTabela = new UsuariosTabela();
            midiaTabela = new MidiaTabela();

            EmailRemetente = "reclameacesso@gmail.com";
            SenhaRemetente = "RA@@1515";
        }





        public void EnviarEmail(int idUsuario)
        {
            Usuarios usuario = usuariosTabela.SelectLinha(idUsuario);
            Reclamacoes reclamacao = reclamacaoTabela.SelectLinha(idUsuario);

            try
            {
                if (reclamacao.DanoSofrido == true)
                {
                    DanoSofrido = "Sim.";
                }
                else
                {
                    if (reclamacao.DanoSofrido == false)
                    {
                        DanoSofrido = "Não.";
                    }

                }

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    UseDefaultCredentials = false,
                    Timeout = 3600000,
                    Credentials = new NetworkCredential(EmailRemetente, SenhaRemetente), //Necessário informar endereço e senha do e-mail remetente.
                    EnableSsl = true
                };
                    mensagemEmail = new MailMessage(EmailRemetente, usuario.Email)
                    {
                        SubjectEncoding = Encoding.GetEncoding("UTF-8"),
                        BodyEncoding = Encoding.GetEncoding("UTF-8"),

                        Subject = $"[CÓPIA] {reclamacao.TituloTexto}",
                        Body = $"Olá, {char.ToUpper(usuario.Nome[0]) + usuario.Nome.Substring(1)}! Essa é uma cópia do e-mail que você enviou pelo Reclame Acesso!" +
                                        $"\n\n" +
                                        $"================================================================================" +
                                        $"\n\n" +
                                        $"CNPJ  da instituição: {reclamacao.CnpjInstituicao}\n" +
                                        $"Dano sofrido: {DanoSofrido}\n" +
                                        $"Tipo de necessidade: {PegarTipoNecessidade(reclamacao)}.\n\n" +
                                        $"{reclamacao.Texto}"
                    };

                    foreach (Midia midia in midiaTabela.Select())
                    {
                        if (reclamacao.IdUsuarios == midia.IdUsuarios)
                        {
                            Attachment anexo = new Attachment(midia.CaminhoMidia);
                            mensagemEmail.Attachments.Add(anexo);
                        }
                    }

                    smtpClient.Send(mensagemEmail);

            }
            catch (Exception e)
            {
                if (usuario.Email.Contains("@") == false)
                {
                    var mensagem = new Helper.EmailControllerHelper("Email não permitido.");
                }
                else
                {
                    MessageBox.Show("Erro ao enviar e-mail.\n\n" + e, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            finally
            {
                ComandoChecarConexaoAberta();
            }

        }





        public string PegarTipoNecessidade(Reclamacoes reclamacao)
        {
            TiposNecessidadesTabela tiposNecessidadesTabela = new TiposNecessidadesTabela();
            string resultado = "";

            foreach (TiposNecessidades tipoNecessidade in tiposNecessidadesTabela.Select())
            {
                if (reclamacao.IdTipoNecessidade == tipoNecessidade.IdTiposNecessidades)
                {
                    resultado = tipoNecessidade.TipoNecessidade;
                }
            }

            return resultado;
        }


    }
}
