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
    public partial class PaginaInicial : Form
    {
        ReclameAcesso pagina = new ReclameAcesso();
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void ContinuarBotao_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagina.Show();
            pagina.Closed += (s, args) => this.Close();
            pagina.Show();
            
        }
    }
}
