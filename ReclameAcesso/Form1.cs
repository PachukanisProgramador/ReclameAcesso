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

namespace ReclameAcesso
{
    public partial class ReclameAcesso : Form
    {
        private MessageBoxButtons BotaoOk { get; set; }
        private MessageBoxButtons BotaoCancel { get; set; }

        private bool ValidacaoNome { get; set; }
        private bool ValidacaoEmail { get; set; }
        private bool ValidacaoTituloTexto { get; set; }
        private bool ValidacaoTexto { get; set; }

        public ReclameAcesso()
        {
            InitializeComponent();
            CaminhoMidia1TextBox.Text = "";
            CaminhoMidia2TextBox.Text = "";
            CaminhoMidia3TextBox.Text = "";

            CarregarListaTiposNecessidades();

        }

        private void BotaoEnviar_Click(object sender, EventArgs e)
        {
            UsuariosTabela usuarioTabela = new UsuariosTabela();
            ReclamacoesTabela reclamacaoTabela = new ReclamacoesTabela();
            MidiaTabela midiaTabela = new MidiaTabela();

            try
            {
                if (NomeTextBox.Text == "Insira o seu nome" || NomeTextBox.Text == "" || EmailTextBox.Text == "Insira o seu e-mail" || EmailTextBox.Text == "" || TituloTextoTextBox.Text == "" || TituloTextoTextBox.Text == "Insira o título do seu texto" || ArmazenarDadosReclamacao() == null)
                {
                    MessageBox.Show("Insira um valor nos campos obrigatório", "Ops!", BotaoOk);
                }
                else
                {

                    int usuarioId = usuarioTabela.Inserir(ArmazenarDadosUsuario());

                    if (CaminhoMidia1TextBox.Text != "")
                    {
                        midiaTabela.Inserir(midiaTabela.CarregarMidia(CaminhoMidia1TextBox.Text), usuarioId);
                    }

                    if (CaminhoMidia2TextBox.Text != "")
                    {
                        midiaTabela.Inserir(midiaTabela.CarregarMidia(CaminhoMidia2TextBox.Text), usuarioId);
                    }
                    if (CaminhoMidia2TextBox.Text != "")
                    {
                        midiaTabela.Inserir(midiaTabela.CarregarMidia(CaminhoMidia3TextBox.Text), usuarioId);
                    }

                    reclamacaoTabela.Inserir(ArmazenarDadosReclamacao(), usuarioId);

                    string resultado = RelacaoInstituicoes(ArmazenarDadosReclamacao());

                    NomeTextBox.Clear();
                    EmailTextBox.Clear();
                    TituloTextoTextBox.Clear();
                    TextoTextBox.Clear();
                    CaminhoMidia1TextBox.Clear();
                    CaminhoMidia2TextBox.Clear();
                    CaminhoMidia3TextBox.Clear();


                    MessageBox.Show($"Sua reclamação foi enviada para as seguintes instituições:\n\n{resultado}\n\nAguarde uma resposta em seu e-mail!");

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro.\n\nForms1.\n\n{erro}", "Ops!", BotaoOk);
            }
            finally
            {
                //ArmazenarListaReclamacao(ArmazenarDadosReclamacao(idUsuario, idMidia)).Clear();
            }

        }

        private string RelacaoInstituicoes(Reclamacoes reclamacao)
        {
            InstituicoesTabela instituicaoTabela = new InstituicoesTabela();
            List<Instituicoes> listaInstituicao = new List<Instituicoes>();

            listaInstituicao = instituicaoTabela.Select();

            string lista = "";

            foreach (var item in listaInstituicao)
            {
                if (item.IdTipoNecessidade == reclamacao.TipoNecessidade || item.IdTipoNecessidade == 6)
                {
                    lista += $"\n {item.Nome} ({item.Email})\n";
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
            return usuario;
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
                    reclamacao.TipoNecessidade = 1;
                    break;
                case "Deficiência Física":
                    reclamacao.TipoNecessidade = 2;
                    break;
                case "Deficiência Mental":
                    reclamacao.TipoNecessidade = 3;
                    break;
                case "Deficiência Auditiva":
                    reclamacao.TipoNecessidade = 4;
                    break;
                case "Paralisia Cerebral":
                    reclamacao.TipoNecessidade = 5;
                    break;
                default:
                    reclamacao.TipoNecessidade = -1;
                    break;
            }
            if (reclamacao.TipoNecessidade == -1 || reclamacao.Texto == "" || reclamacao.Texto == "*Escreva um texto com no máximo 5.000 caracteres.")
            {

                return null;
            }
            else
            {
                return reclamacao;
            }

        }

        private List<Tabela> ArmazenarListaReclamacao(Reclamacoes reclamacao)
        {
            List<Reclamacoes> ListaReclamacao = new List<Reclamacoes>();

            ListaReclamacao.Add(reclamacao);

            return ListaReclamacao.ToList<Tabela>();
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

































        private void SelecionarMidia1Botao_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogoArquivo = new OpenFileDialog();

            try
            {
                dialogoArquivo.Filter = "Arquivos jpg(*.jpg)|*.jpg| Arquivos PNG(*.png)|*.png| Arquivos MP4(*.mp4)|*.mp4| Aúdio WhatsApp (*.opus)|*.opus";

                if (dialogoArquivo.ShowDialog() == DialogResult.OK)
                {
                    CaminhoMidia1TextBox.Text = dialogoArquivo.FileName.ToString();
                }
                else
                {
                    CaminhoMidia1TextBox.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro!", "Ops!", BotaoOk, MessageBoxIcon.Error);
            }
        }

        private void SelecionarMidia2Botao_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialogoArquivo = new OpenFileDialog();

                dialogoArquivo.Filter = "Arquivos jpg(*.jpg)|*.jpg| Arquivos PNG(*.png)|*.png| Arquivos MP4(*.mp4)|*.mp4| Aúdio WhatsApp (*.opus)|*.opus";

                if (dialogoArquivo.ShowDialog() == DialogResult.OK)
                {
                    CaminhoMidia2TextBox.Text = dialogoArquivo.FileName.ToString();
                }
                else
                {
                    CaminhoMidia2TextBox.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro!", "Ops!", BotaoOk, MessageBoxIcon.Error);
            }
        }

        private void SelecionarMidia3Botao_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialogoArquivo = new OpenFileDialog();

                dialogoArquivo.Filter = "Arquivos jpg(*.jpg)|*.jpg| Arquivos PNG(*.png)|*.png| Arquivos MP4(*.mp4)|*.mp4| Aúdio WhatsApp (*.opus)|*.opus";

                if (dialogoArquivo.ShowDialog() == DialogResult.OK)
                {
                    CaminhoMidia3TextBox.Text = dialogoArquivo.FileName.ToString();
                }
                else
                {
                    CaminhoMidia3TextBox.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro!", "Ops!", BotaoOk, MessageBoxIcon.Error);
            }
        }





        private void NomeTextBox_TextChanged(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios
            {
                Nome = NomeTextBox.Text
            };
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios
            {
                Email = EmailTextBox.Text
            };
        }
        private void TituloTextoTextBox_TextChanged(object sender, EventArgs e)
        {
            Reclamacoes reclamacao = new Reclamacoes
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
                MessageBox.Show("Limite de 5.000 caracteres atingido.", "Ops!", BotaoOk);
            }
            else
            {
                Reclamacoes reclamacao = new Reclamacoes
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
        private void DanosCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }










        private void TituloTextoReclamacaoLabel_Click(object sender, EventArgs e)
        {

        }
        private void CaminhoMidia1TextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void CnpjInstituicaoReclamadaLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip dicaCnpjInstituicaoReclamada = new ToolTip();

            dicaCnpjInstituicaoReclamada.Show("Caso saiba e queira, pode informar o CNPJ da empresa em que a situação a ser relatada ocorreu.", CnpjInstituicaoReclamadaLabel);
        }

        private void CaracteresAtualLbl_Click(object sender, EventArgs e)
        {

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
    }
}
