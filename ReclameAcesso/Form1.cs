using ReclameAcesso.Models;
using ReclameAcesso.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace ReclameAcesso
{
    public partial class ReclameAcesso : Form
    {

        private bool ValidacaoNome { get; set; }
        private bool ValidacaoEmail { get; set; }
        private bool ValidacaoTituloTexto { get; set; }
        private bool ValidacaoTexto { get; set; }
        private int UsuarioId { get; set; }

        private ToolTip DicaBotaoEnviar { get; set; }
        private ToolTip DicaSelecionarMidia { get; set; }

        private Color SetCorSelecionarMidiaBotao(OpenFileDialog dialogo)
        {
            if (dialogo.FileNames.Length < 3 && dialogo.FileNames.Length >= 1)
            {
                return Color.FromArgb(150, 255, 255, 51);
            }
            else
            {
                if (dialogo.FileNames.Length == 3)
                {
                    return Color.FromArgb(150, 255, 51, 51);
                }
                else
                {
                    return Color.FromArgb(150, 180, 200, 210);
                }
            }
        }
        public ReclameAcesso()
        {
            InitializeComponent();

            CarregarListaTiposNecessidades();

            DeterminarFormulario();

            DicaBotaoEnviar = new ToolTip();

            DicaSelecionarMidia = new ToolTip();
        }

        private void DeterminarFormulario()
        {
            this.Opacity = 0.98;
        }
        private void BotaoEnviar_Click(object sender, EventArgs e)
        {
            UsuariosTabela usuarioTabela = new UsuariosTabela();
            ReclamacoesTabela reclamacaoTabela = new ReclamacoesTabela();
            MidiaTabela midiaTabela = new MidiaTabela();

            try
            {
                if (ArmazenarDadosUsuario() == null || ArmazenarDadosReclamacao() == null)
                {
                    MessageBox.Show("Insira um valor nos campos obrigatório", "Ops!", MessageBoxButtons.OK);
                }
                else
                {
                    UsuarioId = usuarioTabela.Inserir(ArmazenarDadosUsuario());

                    if (CaminhoMidia1TextBox.Text != "Caminho...")
                    {
                        midiaTabela.Inserir(midiaTabela.CarregarMidia(CaminhoMidia1TextBox.Text), UsuarioId, CaminhoMidia1TextBox.Text);
                    }
                    if (CaminhoMidia2TextBox.Text != "Caminho...")
                    {
                        midiaTabela.Inserir(midiaTabela.CarregarMidia(CaminhoMidia2TextBox.Text), UsuarioId, CaminhoMidia2TextBox.Text);
                    }
                    if (CaminhoMidia3TextBox.Text != "Caminho...")
                    {
                        midiaTabela.Inserir(midiaTabela.CarregarMidia(CaminhoMidia3TextBox.Text), UsuarioId, CaminhoMidia3TextBox.Text);
                    }

                    reclamacaoTabela.Inserir(ArmazenarDadosReclamacao(), UsuarioId);

                    string resultado = RelacaoInstituicoes(ArmazenarDadosReclamacao());

                    NomeTextBox.Clear();
                    EmailTextBox.Clear();
                    TituloTextoTextBox.Clear();
                    TextoTextBox.Clear();
                    CaminhoMidia1TextBox.Clear();
                    CaminhoMidia2TextBox.Clear();
                    CaminhoMidia3TextBox.Clear();
                    DanosCheckBox.Checked = false;
                    TipoNecessidadeComboBox.SelectedIndex = -1;
                    SelecionarMidiaBotao.BackColor = Color.FromArgb(150, 180, 200, 210);
                    CnpjInstituicaoMaskedTextBox.Text = "";


                    EmailControl emailControl = new EmailControl();

                    emailControl.EnviarEmail(UsuarioId);


                    MessageBox.Show($"Seu relato foi enviado para as seguintes instituições:\n\n{resultado}\n\nAguarde uma resposta em seu e-mail!");

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro.\n\nForms1.\n\n{erro}", "Ops!", MessageBoxButtons.OK);
            }
            finally
            {
                //ArmazenarListaReclamacao(ArmazenarDadosReclamacao(idUsuario, idMidia)).Clear();
            }

        }

        private string RelacaoInstituicoes(Reclamacoes reclamacao)
        {
            InstituicoesTabela instituicaoTabela = new InstituicoesTabela();

            string lista = "";

            foreach (var instituicao in instituicaoTabela.Select())
            {
                if (instituicao.IdTipoNecessidade == reclamacao.IdTipoNecessidade || instituicao.IdTipoNecessidade == 6)
                {
                    lista += $"\n {instituicao.Nome} ({instituicao.Email})\n";
                }
            }
            return lista;
        }
        private Usuarios ArmazenarDadosUsuario()
        {
            Usuarios usuario = new Usuarios()
            {
                Nome = NomeTextBox.Text,
                Email = EmailTextBox.Text
            };
            if (usuario.Nome == "Insira o seu nome" || usuario.Nome == "" || usuario.Email == "Insira o seu e-mail" || usuario.Email == "")
            {
                return null;
            }
            else
            {
                return usuario;
            }

        }
        private Reclamacoes ArmazenarDadosReclamacao()
        {
            Reclamacoes reclamacao = new Reclamacoes();

            if (CnpjInstituicaoMaskedTextBox.Text == "")
            {
                reclamacao.TituloTexto = TituloTextoTextBox.Text;
                reclamacao.Texto = TextoTextBox.Text;
            }
            else
            {

                reclamacao.TituloTexto = TituloTextoTextBox.Text;
                reclamacao.Texto = TextoTextBox.Text;
                reclamacao.CnpjInstituicao = (long)Convert.ToDouble(CnpjInstituicaoMaskedTextBox.Text);

            }
            if (DanosCheckBox.Checked.ToString() == "True")
            {
                reclamacao.DanoSofrido = true;
            }
            else
            {
                reclamacao.DanoSofrido = false;
            }
            switch (TipoNecessidadeComboBox.SelectedItem)
            {
                case "Deficiência Visual":
                    reclamacao.IdTipoNecessidade = 1;
                    break;
                case "Deficiência Física":
                    reclamacao.IdTipoNecessidade = 2;
                    break;
                case "Deficiência Mental":
                    reclamacao.IdTipoNecessidade = 3;
                    break;
                case "Deficiência Auditiva":
                    reclamacao.IdTipoNecessidade = 4;
                    break;
                case "Paralisia Cerebral":
                    reclamacao.IdTipoNecessidade = 5;
                    break;
                default:
                    reclamacao.IdTipoNecessidade = -1;
                    break;
            }
            if (reclamacao.IdTipoNecessidade == -1 || reclamacao.Texto == "" || reclamacao.Texto == "Escreva um texto com no máximo 5.000 caracteres.*" || TituloTextoTextBox.Text == "" || TituloTextoTextBox.Text == "Insira o título do seu texto*")
            {
                return null;
            }
            else
            {
                return reclamacao;
            }

        }

        private void CarregarListaTiposNecessidades()
        {
            TiposNecessidadesTabela tiposNecessidadesTabela = new TiposNecessidadesTabela();

            foreach (TiposNecessidades item in tiposNecessidadesTabela.Select())
            {
                if (item.TipoNecessidade == "Geral")
                {

                }
                else
                {
                    TipoNecessidadeComboBox.Items.Add(item.TipoNecessidade);
                }

            }
        }
        private void SelecionarMidiaBotao_Click(object sender, EventArgs e)
        {
            List<string> listaCaminhos = new List<string>(3);

            CaminhoMidia1TextBox.Text = "Caminho...";
            CaminhoMidia2TextBox.Text = "Caminho...";
            CaminhoMidia3TextBox.Text = "Caminho...";

            OpenFileDialog dialogoArquivo = new OpenFileDialog
            {
                Title = "Selecione os seus arquivos",
                Filter = "Todos os arquivos(*.*)|*.*|Arquivos jpg(*.jpg)|*.jpg| Arquivos PNG(*.png)|*.png| Arquivos MP4(*.mp4)|*.mp4| Aúdio WhatsApp (*.opus)|*.opus",
                Multiselect = true,


            };

            int contador = 0;

            try
            {
                if (dialogoArquivo.ShowDialog() == DialogResult.OK)
                {
                    if (dialogoArquivo.FileNames.Length > 3)
                    {
                        MessageBox.Show("Desculpe. Não é possível escolher mais que 3 arquivos de mídia.", "Ops!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        foreach (string caminhoArquivo in dialogoArquivo.FileNames)
                        {
                                listaCaminhos.Add(caminhoArquivo);

                            contador++;
                        }

                        if (contador == 1)
                        {
                            CaminhoMidia1TextBox.Text = listaCaminhos[0];
                        }
                        if (contador == 2)
                        {
                            CaminhoMidia1TextBox.Text = listaCaminhos[0];
                            CaminhoMidia2TextBox.Text = listaCaminhos[1];
                        }
                        if (contador == 3)
                        {
                            CaminhoMidia1TextBox.Text = listaCaminhos[0];
                            CaminhoMidia2TextBox.Text = listaCaminhos[1];
                            CaminhoMidia3TextBox.Text = listaCaminhos[2];
                        }
                    }
                }

                SelecionarMidiaBotao.BackColor = SetCorSelecionarMidiaBotao(dialogoArquivo);
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro!\n\n{erro}", "Ops!", MessageBoxButtons.OK);
            }
        }
        private void NomeTextBox_TextChanged(object sender, EventArgs e)
        {
            _ = new Usuarios
            {
                Nome = NomeTextBox.Text
            };
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            _ = new Usuarios
            {
                Email = EmailTextBox.Text
            };
        }
        private void TituloTextoTextBox_TextChanged(object sender, EventArgs e)
        {
            _ = new Reclamacoes
            {
                TituloTexto = TituloTextoTextBox.Text
            };
        }
        private void TextoTextBox_TextChanged(object sender, EventArgs e)
        {
            TextoTextBox.MaxLength = 5000;

            CaracteresAtualLbl.Text = Convert.ToString(TextoTextBox.Text.Length);

            if (TextoTextBox.Text.Length == 5000)
            {
                MessageBox.Show("Limite de 5.000 caracteres atingido.", "Ops!", MessageBoxButtons.OK);
            }
            else
            {
                _ = new Reclamacoes
                {
                    Texto = TextoTextBox.Text
                };
            }

        }
        private void NomeTextBox_Click(object sender, EventArgs e)
        {
            if (ValidacaoNome == false)
            {
                NomeTextBox.Clear();
                ValidacaoNome = true;
            }
            else
            {

            }
        }
        private void EmailTextBox_Click(object sender, EventArgs e)
        {
            if (ValidacaoEmail == false)
            {
                EmailTextBox.Clear();
                ValidacaoEmail = true;
            }
            else
            {

            }
        }
        private void TituloTextoTextBox_Click(object sender, EventArgs e)
        {
            if (ValidacaoTituloTexto == false)
            {
                TituloTextoTextBox.Clear();
                ValidacaoTituloTexto = true;
            }
            else
            {

            }
        }
        private void TextoTextBox_Click(object sender, EventArgs e)
        {
            if (ValidacaoTexto == false)
            {
                TextoTextBox.Clear();
                ValidacaoTexto = true;
            }
            else
            {

            }
        }
        private void DanosCheckBox_MouseHover(object sender, EventArgs e)
        {
            DicaDanos.Show("A falta de acessibilidade que gerou a sua reclamação também resultou em algum dano sofrido pelo necessitado?", DanosCheckBox);
        }
        private void CnpjInstituicaoReclamadaLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip dicaCnpjInstituicaoReclamada = new ToolTip();

            dicaCnpjInstituicaoReclamada.Show("Caso saiba e queira, pode informar o CNPJ da empresa em que a situação a ser relatada ocorreu.", CnpjInstituicaoReclamadaLabel);
        }

        private void TipoNecessidadeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TiposNecessidadesTabela tiposNecessidadesTabela = new TiposNecessidadesTabela();

            List<int> listaId = new List<int>();

            foreach (TiposNecessidades item in tiposNecessidadesTabela.Select())
            {
                listaId.Add(item.IdTiposNecessidades);

            }
        }
        private void SelecionarMidiaBotao_MouseHover(object sender, EventArgs e)
        {
            DicaSelecionarMidia.Show("Selecione até 3 mídias dos tipos JPGE, PNG, MP4 ou OPUS.", this.SelecionarMidiaBotao);
        }

        private void BotaoEnviar_MouseHover(object sender, EventArgs e)
        {
            DicaBotaoEnviar.Show("Envie a sua mensagem! Assim que pressionado você receberá um aviso listando os destinatários.", this.BotaoEnviar);
        }
    }
}
