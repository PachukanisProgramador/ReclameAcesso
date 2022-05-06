
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
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.BotaoEnviar = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AvisoAsteriscoLabel = new System.Windows.Forms.Label();
            this.MidiaLabel = new System.Windows.Forms.Label();
            this.SelecionarMidiaBotao = new System.Windows.Forms.Button();
            this.CaminhoMidiaTextBox = new System.Windows.Forms.TextBox();
            this.TextoReclamacaoLabel = new System.Windows.Forms.Label();
            this.DanosCheckBox = new System.Windows.Forms.CheckBox();
            this.DicaDanos = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(103, 76);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(383, 20);
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
            this.EmailTextBox.Location = new System.Drawing.Point(103, 122);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(383, 20);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.Text = "Insira o seu e-mail";
            this.EmailTextBox.Click += new System.EventHandler(this.EmailTextBox_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 252);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1033, 330);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insira os seus dados";
            // 
            // NomeLabel
            // 
            this.NomeLabel.AutoSize = true;
            this.NomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLabel.Location = new System.Drawing.Point(27, 76);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(57, 20);
            this.NomeLabel.TabIndex = 6;
            this.NomeLabel.Text = "Nome*";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(27, 122);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(59, 20);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "E-mail*";
            // 
            // AvisoAsteriscoLabel
            // 
            this.AvisoAsteriscoLabel.AutoSize = true;
            this.AvisoAsteriscoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvisoAsteriscoLabel.Location = new System.Drawing.Point(539, 126);
            this.AvisoAsteriscoLabel.Name = "AvisoAsteriscoLabel";
            this.AvisoAsteriscoLabel.Size = new System.Drawing.Size(296, 16);
            this.AvisoAsteriscoLabel.TabIndex = 8;
            this.AvisoAsteriscoLabel.Text = "As opções marcadas com um * são obrigatórias";
            // 
            // MidiaLabel
            // 
            this.MidiaLabel.AutoSize = true;
            this.MidiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidiaLabel.Location = new System.Drawing.Point(27, 176);
            this.MidiaLabel.Name = "MidiaLabel";
            this.MidiaLabel.Size = new System.Drawing.Size(46, 20);
            this.MidiaLabel.TabIndex = 9;
            this.MidiaLabel.Text = "Mídia";
            // 
            // SelecionarMidiaBotao
            // 
            this.SelecionarMidiaBotao.Location = new System.Drawing.Point(280, 175);
            this.SelecionarMidiaBotao.Name = "SelecionarMidiaBotao";
            this.SelecionarMidiaBotao.Size = new System.Drawing.Size(206, 25);
            this.SelecionarMidiaBotao.TabIndex = 10;
            this.SelecionarMidiaBotao.Text = "Selecionar caminho";
            this.SelecionarMidiaBotao.UseVisualStyleBackColor = true;
            // 
            // CaminhoMidiaTextBox
            // 
            this.CaminhoMidiaTextBox.Location = new System.Drawing.Point(103, 178);
            this.CaminhoMidiaTextBox.Name = "CaminhoMidiaTextBox";
            this.CaminhoMidiaTextBox.Size = new System.Drawing.Size(171, 20);
            this.CaminhoMidiaTextBox.TabIndex = 11;
            this.CaminhoMidiaTextBox.Text = "Caminho...";
            // 
            // TextoReclamacaoLabel
            // 
            this.TextoReclamacaoLabel.AutoSize = true;
            this.TextoReclamacaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoReclamacaoLabel.Location = new System.Drawing.Point(27, 229);
            this.TextoReclamacaoLabel.Name = "TextoReclamacaoLabel";
            this.TextoReclamacaoLabel.Size = new System.Drawing.Size(48, 20);
            this.TextoReclamacaoLabel.TabIndex = 12;
            this.TextoReclamacaoLabel.Text = "Texto";
            // 
            // DanosCheckBox
            // 
            this.DanosCheckBox.AutoSize = true;
            this.DanosCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanosCheckBox.Location = new System.Drawing.Point(542, 176);
            this.DanosCheckBox.Name = "DanosCheckBox";
            this.DanosCheckBox.Size = new System.Drawing.Size(75, 24);
            this.DanosCheckBox.TabIndex = 13;
            this.DanosCheckBox.Text = "Danos";
            this.DanosCheckBox.UseVisualStyleBackColor = true;
            this.DanosCheckBox.MouseHover += new System.EventHandler(this.DanosCheckBox_MouseHover);
            // 
            // ReclameAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 633);
            this.Controls.Add(this.DanosCheckBox);
            this.Controls.Add(this.TextoReclamacaoLabel);
            this.Controls.Add(this.CaminhoMidiaTextBox);
            this.Controls.Add(this.SelecionarMidiaBotao);
            this.Controls.Add(this.MidiaLabel);
            this.Controls.Add(this.AvisoAsteriscoLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NomeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.BotaoEnviar);
            this.Controls.Add(this.NomeTextBox);
            this.Name = "ReclameAcesso";
            this.Text = "Reclame Acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.Button BotaoEnviar;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AvisoAsteriscoLabel;
        private System.Windows.Forms.Label MidiaLabel;
        private System.Windows.Forms.Button SelecionarMidiaBotao;
        private System.Windows.Forms.TextBox CaminhoMidiaTextBox;
        private System.Windows.Forms.Label TextoReclamacaoLabel;
        private System.Windows.Forms.CheckBox DanosCheckBox;
        private System.Windows.Forms.ToolTip DicaDanos;
    }
}

