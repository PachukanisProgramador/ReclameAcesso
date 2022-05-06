using ReclameAcesso.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReclameAcesso
{
    public partial class ReclameAcesso : Form
    {
        private MessageBoxButtons BotaoOk { get; set; }
        private MessageBoxButtons BotaoCancel { get; set; }

        public ReclameAcesso()
        {
            UsuariosTabela usuario = new UsuariosTabela();
            InitializeComponent();
        }

        private void NomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomeTextBox_Click(object sender, EventArgs e)
        {
            NomeTextBox.Clear();
        }

        private void EmailTextBox_Click(object sender, EventArgs e)
        {
            EmailTextBox.Clear();
        }

        private void BotaoEnviar_Click(object sender, EventArgs e)
        {
            UsuariosTabela usuario = new UsuariosTabela
            {
                Nome = NomeTextBox.Text,
                Email = EmailTextBox.Text
            };

            if (usuario.Nome == "Insira o seu nome" || usuario.Nome == "" || usuario.Email == "Insira o seu e-mail" || usuario.Email == "")
            {
                MessageBox.Show("Insira um valor nos campos obrigatório", "Ops!", BotaoOk);
            }
            else
            {

                usuario.Inserir(usuario);
                NomeTextBox.Clear();
                EmailTextBox.Clear();
            }


        }

        private void DanosCheckBox_MouseHover(object sender, EventArgs e)
        {
            DicaDanos.Show("A falta de acessibilidade que gerou a sua reclamação também resultou em algum dano sofrido pelo necessitado?", DanosCheckBox);
        }
    }
}
