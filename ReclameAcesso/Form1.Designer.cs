
namespace ReclameAcesso
{
    partial class ReclameAcesso
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReclameAcesso));
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.BotaoEnviar = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.TextoTextBox = new System.Windows.Forms.TextBox();
            this.InsiraDadosLabel = new System.Windows.Forms.Label();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AvisoAsteriscoLabel = new System.Windows.Forms.Label();
            this.MidiaLabel = new System.Windows.Forms.Label();
            this.CaminhoMidia1TextBox = new System.Windows.Forms.TextBox();
            this.TituloTextoReclamacaoLabel = new System.Windows.Forms.Label();
            this.DanosCheckBox = new System.Windows.Forms.CheckBox();
            this.DicaDanos = new System.Windows.Forms.ToolTip(this.components);
            this.TipoNecessidadeLabel = new System.Windows.Forms.Label();
            this.TipoNecessidadeComboBox = new System.Windows.Forms.ComboBox();
            this.TituloTextoTextBox = new System.Windows.Forms.TextBox();
            this.SelecionarMidia1Botao = new System.Windows.Forms.Button();
            this.SelecionarMidia2Botao = new System.Windows.Forms.Button();
            this.CaminhoMidia2TextBox = new System.Windows.Forms.TextBox();
            this.SelecionarMidia3Botao = new System.Windows.Forms.Button();
            this.CaminhoMidia3TextBox = new System.Windows.Forms.TextBox();
            this.CnpjInstituicaoReclamadaLabel = new System.Windows.Forms.Label();
            this.CaracteresLbl = new System.Windows.Forms.Label();
            this.CaracteresAtualLbl = new System.Windows.Forms.Label();
            this.CaracteresMaxLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CnpjInstituicaoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeTextBox.Location = new System.Drawing.Point(102, 79);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(391, 26);
            this.NomeTextBox.TabIndex = 1;
            this.NomeTextBox.Text = "Insira o seu nome";
            this.NomeTextBox.Click += new System.EventHandler(this.NomeTextBox_Click);
            this.NomeTextBox.TextChanged += new System.EventHandler(this.NomeTextBox_TextChanged);
            // 
            // BotaoEnviar
            // 
            this.BotaoEnviar.Location = new System.Drawing.Point(430, 588);
            this.BotaoEnviar.Name = "BotaoEnviar";
            this.BotaoEnviar.Size = new System.Drawing.Size(269, 33);
            this.BotaoEnviar.TabIndex = 2;
            this.BotaoEnviar.Text = "Enviar";
            this.BotaoEnviar.UseVisualStyleBackColor = true;
            this.BotaoEnviar.Click += new System.EventHandler(this.BotaoEnviar_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(102, 125);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(391, 26);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.Text = "Insira o seu e-mail";
            this.EmailTextBox.Click += new System.EventHandler(this.EmailTextBox_Click);
            // 
            // TextoTextBox
            // 
            this.TextoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoTextBox.Location = new System.Drawing.Point(31, 305);
            this.TextoTextBox.Multiline = true;
            this.TextoTextBox.Name = "TextoTextBox";
            this.TextoTextBox.Size = new System.Drawing.Size(1033, 277);
            this.TextoTextBox.TabIndex = 4;
            this.TextoTextBox.Text = "*Escreva um texto com no máximo 5.000 caracteres.";
            this.TextoTextBox.Click += new System.EventHandler(this.TextoTextBox_Click);
            this.TextoTextBox.TextChanged += new System.EventHandler(this.TextoTextBox_TextChanged);
            // 
            // InsiraDadosLabel
            // 
            this.InsiraDadosLabel.AutoSize = true;
            this.InsiraDadosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsiraDadosLabel.Location = new System.Drawing.Point(346, 9);
            this.InsiraDadosLabel.Name = "InsiraDadosLabel";
            this.InsiraDadosLabel.Size = new System.Drawing.Size(434, 24);
            this.InsiraDadosLabel.TabIndex = 5;
            this.InsiraDadosLabel.Text = "Insira os dados abaixo para enviarmos o seu relato";
            // 
            // NomeLabel
            // 
            this.NomeLabel.AutoSize = true;
            this.NomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLabel.Location = new System.Drawing.Point(26, 79);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(57, 20);
            this.NomeLabel.TabIndex = 6;
            this.NomeLabel.Text = "Nome*";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(26, 125);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(59, 20);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "E-mail*";
            // 
            // AvisoAsteriscoLabel
            // 
            this.AvisoAsteriscoLabel.AutoSize = true;
            this.AvisoAsteriscoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvisoAsteriscoLabel.Location = new System.Drawing.Point(768, 246);
            this.AvisoAsteriscoLabel.Name = "AvisoAsteriscoLabel";
            this.AvisoAsteriscoLabel.Size = new System.Drawing.Size(296, 16);
            this.AvisoAsteriscoLabel.TabIndex = 8;
            this.AvisoAsteriscoLabel.Text = "As opções marcadas com um * são obrigatórias";
            // 
            // MidiaLabel
            // 
            this.MidiaLabel.AutoSize = true;
            this.MidiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidiaLabel.Location = new System.Drawing.Point(613, 53);
            this.MidiaLabel.Name = "MidiaLabel";
            this.MidiaLabel.Size = new System.Drawing.Size(58, 20);
            this.MidiaLabel.TabIndex = 9;
            this.MidiaLabel.Text = "Mídias:";
            // 
            // CaminhoMidia1TextBox
            // 
            this.CaminhoMidia1TextBox.Location = new System.Drawing.Point(676, 79);
            this.CaminhoMidia1TextBox.Name = "CaminhoMidia1TextBox";
            this.CaminhoMidia1TextBox.Size = new System.Drawing.Size(171, 20);
            this.CaminhoMidia1TextBox.TabIndex = 11;
            this.CaminhoMidia1TextBox.Text = "Caminho...";
            this.CaminhoMidia1TextBox.TextChanged += new System.EventHandler(this.CaminhoMidia1TextBox_TextChanged);
            // 
            // TituloTextoReclamacaoLabel
            // 
            this.TituloTextoReclamacaoLabel.AutoSize = true;
            this.TituloTextoReclamacaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloTextoReclamacaoLabel.Location = new System.Drawing.Point(27, 274);
            this.TituloTextoReclamacaoLabel.Name = "TituloTextoReclamacaoLabel";
            this.TituloTextoReclamacaoLabel.Size = new System.Drawing.Size(96, 20);
            this.TituloTextoReclamacaoLabel.TabIndex = 12;
            this.TituloTextoReclamacaoLabel.Text = "Título texto*:";
            this.TituloTextoReclamacaoLabel.Click += new System.EventHandler(this.TituloTextoReclamacaoLabel_Click);
            // 
            // DanosCheckBox
            // 
            this.DanosCheckBox.AutoSize = true;
            this.DanosCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DanosCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanosCheckBox.Location = new System.Drawing.Point(349, 161);
            this.DanosCheckBox.Name = "DanosCheckBox";
            this.DanosCheckBox.Size = new System.Drawing.Size(144, 24);
            this.DanosCheckBox.TabIndex = 13;
            this.DanosCheckBox.Text = "Danos sofridos?";
            this.DanosCheckBox.UseVisualStyleBackColor = true;
            this.DanosCheckBox.CheckedChanged += new System.EventHandler(this.DanosCheckBox_CheckedChanged);
            this.DanosCheckBox.MouseHover += new System.EventHandler(this.DanosCheckBox_MouseHover);
            // 
            // TipoNecessidadeLabel
            // 
            this.TipoNecessidadeLabel.AutoSize = true;
            this.TipoNecessidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoNecessidadeLabel.Location = new System.Drawing.Point(26, 163);
            this.TipoNecessidadeLabel.Name = "TipoNecessidadeLabel";
            this.TipoNecessidadeLabel.Size = new System.Drawing.Size(145, 20);
            this.TipoNecessidadeLabel.TabIndex = 15;
            this.TipoNecessidadeLabel.Text = "*Tipo Necessidade:";
            // 
            // TipoNecessidadeComboBox
            // 
            this.TipoNecessidadeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoNecessidadeComboBox.FormattingEnabled = true;
            this.TipoNecessidadeComboBox.Location = new System.Drawing.Point(171, 162);
            this.TipoNecessidadeComboBox.Name = "TipoNecessidadeComboBox";
            this.TipoNecessidadeComboBox.Size = new System.Drawing.Size(163, 28);
            this.TipoNecessidadeComboBox.TabIndex = 16;
            this.TipoNecessidadeComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoNecessidadeComboBox_SelectedIndexChanged);
            // 
            // TituloTextoTextBox
            // 
            this.TituloTextoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloTextoTextBox.Location = new System.Drawing.Point(123, 276);
            this.TituloTextoTextBox.Name = "TituloTextoTextBox";
            this.TituloTextoTextBox.Size = new System.Drawing.Size(941, 26);
            this.TituloTextoTextBox.TabIndex = 17;
            this.TituloTextoTextBox.Text = "Insira o título do seu texto";
            this.TituloTextoTextBox.Click += new System.EventHandler(this.TituloTextoTextBox_Click);
            this.TituloTextoTextBox.TextChanged += new System.EventHandler(this.TituloTextoTextBox_TextChanged);
            // 
            // SelecionarMidia1Botao
            // 
            this.SelecionarMidia1Botao.Location = new System.Drawing.Point(857, 76);
            this.SelecionarMidia1Botao.Name = "SelecionarMidia1Botao";
            this.SelecionarMidia1Botao.Size = new System.Drawing.Size(206, 23);
            this.SelecionarMidia1Botao.TabIndex = 18;
            this.SelecionarMidia1Botao.Text = "Selecionar mídia";
            this.SelecionarMidia1Botao.UseVisualStyleBackColor = true;
            this.SelecionarMidia1Botao.Click += new System.EventHandler(this.SelecionarMidia1Botao_Click);
            // 
            // SelecionarMidia2Botao
            // 
            this.SelecionarMidia2Botao.Location = new System.Drawing.Point(857, 103);
            this.SelecionarMidia2Botao.Name = "SelecionarMidia2Botao";
            this.SelecionarMidia2Botao.Size = new System.Drawing.Size(206, 23);
            this.SelecionarMidia2Botao.TabIndex = 20;
            this.SelecionarMidia2Botao.Text = "Selecionar mídia";
            this.SelecionarMidia2Botao.UseVisualStyleBackColor = true;
            this.SelecionarMidia2Botao.Click += new System.EventHandler(this.SelecionarMidia2Botao_Click);
            // 
            // CaminhoMidia2TextBox
            // 
            this.CaminhoMidia2TextBox.Location = new System.Drawing.Point(676, 105);
            this.CaminhoMidia2TextBox.Name = "CaminhoMidia2TextBox";
            this.CaminhoMidia2TextBox.Size = new System.Drawing.Size(171, 20);
            this.CaminhoMidia2TextBox.TabIndex = 19;
            this.CaminhoMidia2TextBox.Text = "Caminho...";
            // 
            // SelecionarMidia3Botao
            // 
            this.SelecionarMidia3Botao.Location = new System.Drawing.Point(857, 129);
            this.SelecionarMidia3Botao.Name = "SelecionarMidia3Botao";
            this.SelecionarMidia3Botao.Size = new System.Drawing.Size(206, 23);
            this.SelecionarMidia3Botao.TabIndex = 22;
            this.SelecionarMidia3Botao.Text = "Selecionar mídia";
            this.SelecionarMidia3Botao.UseVisualStyleBackColor = true;
            this.SelecionarMidia3Botao.Click += new System.EventHandler(this.SelecionarMidia3Botao_Click);
            // 
            // CaminhoMidia3TextBox
            // 
            this.CaminhoMidia3TextBox.Location = new System.Drawing.Point(676, 131);
            this.CaminhoMidia3TextBox.Name = "CaminhoMidia3TextBox";
            this.CaminhoMidia3TextBox.Size = new System.Drawing.Size(171, 20);
            this.CaminhoMidia3TextBox.TabIndex = 21;
            this.CaminhoMidia3TextBox.Text = "Caminho...";
            // 
            // CnpjInstituicaoReclamadaLabel
            // 
            this.CnpjInstituicaoReclamadaLabel.AutoSize = true;
            this.CnpjInstituicaoReclamadaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnpjInstituicaoReclamadaLabel.Location = new System.Drawing.Point(26, 205);
            this.CnpjInstituicaoReclamadaLabel.Name = "CnpjInstituicaoReclamadaLabel";
            this.CnpjInstituicaoReclamadaLabel.Size = new System.Drawing.Size(128, 20);
            this.CnpjInstituicaoReclamadaLabel.TabIndex = 23;
            this.CnpjInstituicaoReclamadaLabel.Text = "CNPJ instituição:";
            this.CnpjInstituicaoReclamadaLabel.MouseHover += new System.EventHandler(this.CnpjInstituicaoReclamadaLabel_MouseHover);
            // 
            // CaracteresLbl
            // 
            this.CaracteresLbl.AutoSize = true;
            this.CaracteresLbl.Location = new System.Drawing.Point(28, 585);
            this.CaracteresLbl.Name = "CaracteresLbl";
            this.CaracteresLbl.Size = new System.Drawing.Size(61, 13);
            this.CaracteresLbl.TabIndex = 26;
            this.CaracteresLbl.Text = "Caracteres:";
            // 
            // CaracteresAtualLbl
            // 
            this.CaracteresAtualLbl.AutoSize = true;
            this.CaracteresAtualLbl.Location = new System.Drawing.Point(90, 585);
            this.CaracteresAtualLbl.Name = "CaracteresAtualLbl";
            this.CaracteresAtualLbl.Size = new System.Drawing.Size(13, 13);
            this.CaracteresAtualLbl.TabIndex = 27;
            this.CaracteresAtualLbl.Text = "0";
            this.CaracteresAtualLbl.Click += new System.EventHandler(this.CaracteresAtualLbl_Click);
            // 
            // CaracteresMaxLbl
            // 
            this.CaracteresMaxLbl.AutoSize = true;
            this.CaracteresMaxLbl.Location = new System.Drawing.Point(120, 585);
            this.CaracteresMaxLbl.Name = "CaracteresMaxLbl";
            this.CaracteresMaxLbl.Size = new System.Drawing.Size(39, 13);
            this.CaracteresMaxLbl.TabIndex = 28;
            this.CaracteresMaxLbl.Text = "/ 5000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(697, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(745, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(792, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // CnpjInstituicaoMaskedTextBox
            // 
            this.CnpjInstituicaoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnpjInstituicaoMaskedTextBox.Location = new System.Drawing.Point(171, 199);
            this.CnpjInstituicaoMaskedTextBox.Mask = "00.000.000/0000-00";
            this.CnpjInstituicaoMaskedTextBox.Name = "CnpjInstituicaoMaskedTextBox";
            this.CnpjInstituicaoMaskedTextBox.Size = new System.Drawing.Size(153, 26);
            this.CnpjInstituicaoMaskedTextBox.TabIndex = 32;
            this.CnpjInstituicaoMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // ReclameAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1097, 633);
            this.Controls.Add(this.CnpjInstituicaoMaskedTextBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CaracteresMaxLbl);
            this.Controls.Add(this.CaracteresAtualLbl);
            this.Controls.Add(this.CaracteresLbl);
            this.Controls.Add(this.CnpjInstituicaoReclamadaLabel);
            this.Controls.Add(this.SelecionarMidia3Botao);
            this.Controls.Add(this.CaminhoMidia3TextBox);
            this.Controls.Add(this.SelecionarMidia2Botao);
            this.Controls.Add(this.CaminhoMidia2TextBox);
            this.Controls.Add(this.SelecionarMidia1Botao);
            this.Controls.Add(this.TituloTextoTextBox);
            this.Controls.Add(this.TipoNecessidadeComboBox);
            this.Controls.Add(this.TipoNecessidadeLabel);
            this.Controls.Add(this.DanosCheckBox);
            this.Controls.Add(this.TituloTextoReclamacaoLabel);
            this.Controls.Add(this.CaminhoMidia1TextBox);
            this.Controls.Add(this.MidiaLabel);
            this.Controls.Add(this.AvisoAsteriscoLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NomeLabel);
            this.Controls.Add(this.InsiraDadosLabel);
            this.Controls.Add(this.TextoTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.BotaoEnviar);
            this.Controls.Add(this.NomeTextBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReclameAcesso";
            this.Text = "Reclame Acesso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.Button BotaoEnviar;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox TextoTextBox;
        private System.Windows.Forms.Label InsiraDadosLabel;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AvisoAsteriscoLabel;
        private System.Windows.Forms.Label MidiaLabel;
        private System.Windows.Forms.TextBox CaminhoMidia1TextBox;
        private System.Windows.Forms.Label TituloTextoReclamacaoLabel;
        private System.Windows.Forms.CheckBox DanosCheckBox;
        private System.Windows.Forms.ToolTip DicaDanos;
        private System.Windows.Forms.Label TipoNecessidadeLabel;
        private System.Windows.Forms.ComboBox TipoNecessidadeComboBox;
        private System.Windows.Forms.TextBox TituloTextoTextBox;
        private System.Windows.Forms.Button SelecionarMidia1Botao;
        private System.Windows.Forms.Button SelecionarMidia2Botao;
        private System.Windows.Forms.TextBox CaminhoMidia2TextBox;
        private System.Windows.Forms.Button SelecionarMidia3Botao;
        private System.Windows.Forms.TextBox CaminhoMidia3TextBox;
        private System.Windows.Forms.Label CnpjInstituicaoReclamadaLabel;
        private System.Windows.Forms.Label CaracteresLbl;
        private System.Windows.Forms.Label CaracteresAtualLbl;
        private System.Windows.Forms.Label CaracteresMaxLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MaskedTextBox CnpjInstituicaoMaskedTextBox;
    }
}

