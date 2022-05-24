
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
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.InsiraDadosLabel = new System.Windows.Forms.Label();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AvisoAsteriscoLabel = new System.Windows.Forms.Label();
            this.MidiaLabel = new System.Windows.Forms.Label();
            this.CaminhoMidia1TextBox = new System.Windows.Forms.TextBox();
            this.DanosCheckBox = new System.Windows.Forms.CheckBox();
            this.DicaDanos = new System.Windows.Forms.ToolTip(this.components);
            this.TipoNecessidadeLabel = new System.Windows.Forms.Label();
            this.TipoNecessidadeComboBox = new System.Windows.Forms.ComboBox();
            this.SelecionarMidiaBotao = new System.Windows.Forms.Button();
            this.CaminhoMidia2TextBox = new System.Windows.Forms.TextBox();
            this.CaminhoMidia3TextBox = new System.Windows.Forms.TextBox();
            this.CnpjInstituicaoReclamadaLabel = new System.Windows.Forms.Label();
            this.CaracteresLbl = new System.Windows.Forms.Label();
            this.CaracteresAtualLbl = new System.Windows.Forms.Label();
            this.CaracteresMaxLbl = new System.Windows.Forms.Label();
            this.WppImageBox = new System.Windows.Forms.PictureBox();
            this.JpgImageBox = new System.Windows.Forms.PictureBox();
            this.PngImageBox = new System.Windows.Forms.PictureBox();
            this.CnpjInstituicaoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Mp4ImageBox = new System.Windows.Forms.PictureBox();
            this.MidiaPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DadosUsuarioPanel = new System.Windows.Forms.Panel();
            this.InsiraDadosPanel = new System.Windows.Forms.Panel();
            this.DadosLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BotaoEnviar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextoTextBox = new System.Windows.Forms.TextBox();
            this.TituloTextoTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.WppImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JpgImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PngImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mp4ImageBox)).BeginInit();
            this.MidiaPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DadosUsuarioPanel.SuspendLayout();
            this.InsiraDadosPanel.SuspendLayout();
            this.DadosLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomeTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeTextBox.Location = new System.Drawing.Point(79, 12);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(554, 33);
            this.NomeTextBox.TabIndex = 1;
            this.NomeTextBox.Text = "Insira o seu nome";
            this.NomeTextBox.Click += new System.EventHandler(this.NomeTextBox_Click);
            this.NomeTextBox.TextChanged += new System.EventHandler(this.NomeTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(79, 58);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(554, 33);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.Text = "Insira o seu e-mail";
            this.EmailTextBox.Click += new System.EventHandler(this.EmailTextBox_Click);
            // 
            // InsiraDadosLabel
            // 
            this.InsiraDadosLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InsiraDadosLabel.AutoSize = true;
            this.InsiraDadosLabel.BackColor = System.Drawing.Color.Transparent;
            this.InsiraDadosLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsiraDadosLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InsiraDadosLabel.Location = new System.Drawing.Point(466, 9);
            this.InsiraDadosLabel.Name = "InsiraDadosLabel";
            this.InsiraDadosLabel.Size = new System.Drawing.Size(662, 40);
            this.InsiraDadosLabel.TabIndex = 5;
            this.InsiraDadosLabel.Text = "Insira os dados abaixo para enviarmos o seu relato";
            // 
            // NomeLabel
            // 
            this.NomeLabel.AutoSize = true;
            this.NomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.NomeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NomeLabel.Location = new System.Drawing.Point(3, 12);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(71, 25);
            this.NomeLabel.TabIndex = 6;
            this.NomeLabel.Text = "Nome*";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(3, 58);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(74, 25);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "E-mail*";
            // 
            // AvisoAsteriscoLabel
            // 
            this.AvisoAsteriscoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AvisoAsteriscoLabel.AutoSize = true;
            this.AvisoAsteriscoLabel.BackColor = System.Drawing.Color.Transparent;
            this.AvisoAsteriscoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvisoAsteriscoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AvisoAsteriscoLabel.Location = new System.Drawing.Point(1060, 672);
            this.AvisoAsteriscoLabel.Name = "AvisoAsteriscoLabel";
            this.AvisoAsteriscoLabel.Size = new System.Drawing.Size(468, 25);
            this.AvisoAsteriscoLabel.TabIndex = 8;
            this.AvisoAsteriscoLabel.Text = "As opções marcadas com um * são obrigatórias";
            // 
            // MidiaLabel
            // 
            this.MidiaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MidiaLabel.AutoSize = true;
            this.MidiaLabel.BackColor = System.Drawing.Color.Transparent;
            this.MidiaLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidiaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MidiaLabel.Location = new System.Drawing.Point(3, 4);
            this.MidiaLabel.Name = "MidiaLabel";
            this.MidiaLabel.Size = new System.Drawing.Size(79, 30);
            this.MidiaLabel.TabIndex = 9;
            this.MidiaLabel.Text = "Mídias:";
            // 
            // CaminhoMidia1TextBox
            // 
            this.CaminhoMidia1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaminhoMidia1TextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaminhoMidia1TextBox.Location = new System.Drawing.Point(85, 12);
            this.CaminhoMidia1TextBox.Name = "CaminhoMidia1TextBox";
            this.CaminhoMidia1TextBox.ReadOnly = true;
            this.CaminhoMidia1TextBox.Size = new System.Drawing.Size(446, 35);
            this.CaminhoMidia1TextBox.TabIndex = 11;
            this.CaminhoMidia1TextBox.Text = "Caminho...";
            // 
            // DanosCheckBox
            // 
            this.DanosCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DanosCheckBox.AutoSize = true;
            this.DanosCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.DanosCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DanosCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanosCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DanosCheckBox.Location = new System.Drawing.Point(468, 106);
            this.DanosCheckBox.Name = "DanosCheckBox";
            this.DanosCheckBox.Size = new System.Drawing.Size(165, 29);
            this.DanosCheckBox.TabIndex = 13;
            this.DanosCheckBox.Text = "Danos sofridos?";
            this.DanosCheckBox.UseVisualStyleBackColor = false;
            this.DanosCheckBox.MouseHover += new System.EventHandler(this.DanosCheckBox_MouseHover);
            // 
            // TipoNecessidadeLabel
            // 
            this.TipoNecessidadeLabel.AutoSize = true;
            this.TipoNecessidadeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TipoNecessidadeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoNecessidadeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TipoNecessidadeLabel.Location = new System.Drawing.Point(3, 98);
            this.TipoNecessidadeLabel.Name = "TipoNecessidadeLabel";
            this.TipoNecessidadeLabel.Size = new System.Drawing.Size(172, 25);
            this.TipoNecessidadeLabel.TabIndex = 15;
            this.TipoNecessidadeLabel.Text = "Tipo Necessidade*:";
            // 
            // TipoNecessidadeComboBox
            // 
            this.TipoNecessidadeComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoNecessidadeComboBox.FormattingEnabled = true;
            this.TipoNecessidadeComboBox.Location = new System.Drawing.Point(185, 95);
            this.TipoNecessidadeComboBox.Name = "TipoNecessidadeComboBox";
            this.TipoNecessidadeComboBox.Size = new System.Drawing.Size(176, 33);
            this.TipoNecessidadeComboBox.TabIndex = 16;
            this.TipoNecessidadeComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoNecessidadeComboBox_SelectedIndexChanged);
            // 
            // SelecionarMidiaBotao
            // 
            this.SelecionarMidiaBotao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelecionarMidiaBotao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.SelecionarMidiaBotao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SelecionarMidiaBotao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelecionarMidiaBotao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelecionarMidiaBotao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelecionarMidiaBotao.Image = ((System.Drawing.Image)(resources.GetObject("SelecionarMidiaBotao.Image")));
            this.SelecionarMidiaBotao.Location = new System.Drawing.Point(554, 13);
            this.SelecionarMidiaBotao.Name = "SelecionarMidiaBotao";
            this.SelecionarMidiaBotao.Size = new System.Drawing.Size(44, 33);
            this.SelecionarMidiaBotao.TabIndex = 18;
            this.SelecionarMidiaBotao.UseVisualStyleBackColor = false;
            this.SelecionarMidiaBotao.Click += new System.EventHandler(this.SelecionarMidiaBotao_Click);
            this.SelecionarMidiaBotao.MouseHover += new System.EventHandler(this.SelecionarMidiaBotao_MouseHover);
            // 
            // CaminhoMidia2TextBox
            // 
            this.CaminhoMidia2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaminhoMidia2TextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaminhoMidia2TextBox.Location = new System.Drawing.Point(85, 57);
            this.CaminhoMidia2TextBox.Name = "CaminhoMidia2TextBox";
            this.CaminhoMidia2TextBox.ReadOnly = true;
            this.CaminhoMidia2TextBox.Size = new System.Drawing.Size(446, 35);
            this.CaminhoMidia2TextBox.TabIndex = 19;
            this.CaminhoMidia2TextBox.Text = "Caminho...";
            // 
            // CaminhoMidia3TextBox
            // 
            this.CaminhoMidia3TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaminhoMidia3TextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaminhoMidia3TextBox.Location = new System.Drawing.Point(85, 101);
            this.CaminhoMidia3TextBox.Name = "CaminhoMidia3TextBox";
            this.CaminhoMidia3TextBox.ReadOnly = true;
            this.CaminhoMidia3TextBox.Size = new System.Drawing.Size(446, 35);
            this.CaminhoMidia3TextBox.TabIndex = 21;
            this.CaminhoMidia3TextBox.Text = "Caminho...";
            // 
            // CnpjInstituicaoReclamadaLabel
            // 
            this.CnpjInstituicaoReclamadaLabel.AutoSize = true;
            this.CnpjInstituicaoReclamadaLabel.BackColor = System.Drawing.Color.Transparent;
            this.CnpjInstituicaoReclamadaLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnpjInstituicaoReclamadaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CnpjInstituicaoReclamadaLabel.Location = new System.Drawing.Point(3, 138);
            this.CnpjInstituicaoReclamadaLabel.Name = "CnpjInstituicaoReclamadaLabel";
            this.CnpjInstituicaoReclamadaLabel.Size = new System.Drawing.Size(151, 25);
            this.CnpjInstituicaoReclamadaLabel.TabIndex = 23;
            this.CnpjInstituicaoReclamadaLabel.Text = "CNPJ instituição:";
            this.CnpjInstituicaoReclamadaLabel.MouseHover += new System.EventHandler(this.CnpjInstituicaoReclamadaLabel_MouseHover);
            // 
            // CaracteresLbl
            // 
            this.CaracteresLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CaracteresLbl.AutoSize = true;
            this.CaracteresLbl.BackColor = System.Drawing.Color.Transparent;
            this.CaracteresLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaracteresLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CaracteresLbl.Location = new System.Drawing.Point(26, 670);
            this.CaracteresLbl.Name = "CaracteresLbl";
            this.CaracteresLbl.Size = new System.Drawing.Size(115, 30);
            this.CaracteresLbl.TabIndex = 26;
            this.CaracteresLbl.Text = "Caracteres:";
            // 
            // CaracteresAtualLbl
            // 
            this.CaracteresAtualLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CaracteresAtualLbl.AutoSize = true;
            this.CaracteresAtualLbl.BackColor = System.Drawing.Color.Transparent;
            this.CaracteresAtualLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaracteresAtualLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CaracteresAtualLbl.Location = new System.Drawing.Point(137, 671);
            this.CaracteresAtualLbl.Name = "CaracteresAtualLbl";
            this.CaracteresAtualLbl.Size = new System.Drawing.Size(24, 30);
            this.CaracteresAtualLbl.TabIndex = 27;
            this.CaracteresAtualLbl.Text = "0";
            // 
            // CaracteresMaxLbl
            // 
            this.CaracteresMaxLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CaracteresMaxLbl.AutoSize = true;
            this.CaracteresMaxLbl.BackColor = System.Drawing.Color.Transparent;
            this.CaracteresMaxLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaracteresMaxLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CaracteresMaxLbl.Location = new System.Drawing.Point(191, 671);
            this.CaracteresMaxLbl.Name = "CaracteresMaxLbl";
            this.CaracteresMaxLbl.Size = new System.Drawing.Size(71, 30);
            this.CaracteresMaxLbl.TabIndex = 28;
            this.CaracteresMaxLbl.Text = "/ 5000";
            // 
            // WppImageBox
            // 
            this.WppImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WppImageBox.BackColor = System.Drawing.Color.Transparent;
            this.WppImageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WppImageBox.BackgroundImage")));
            this.WppImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WppImageBox.Location = new System.Drawing.Point(13, 4);
            this.WppImageBox.Name = "WppImageBox";
            this.WppImageBox.Size = new System.Drawing.Size(25, 25);
            this.WppImageBox.TabIndex = 29;
            this.WppImageBox.TabStop = false;
            // 
            // JpgImageBox
            // 
            this.JpgImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.JpgImageBox.BackColor = System.Drawing.Color.Transparent;
            this.JpgImageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JpgImageBox.BackgroundImage")));
            this.JpgImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.JpgImageBox.Location = new System.Drawing.Point(60, 4);
            this.JpgImageBox.Name = "JpgImageBox";
            this.JpgImageBox.Size = new System.Drawing.Size(25, 25);
            this.JpgImageBox.TabIndex = 30;
            this.JpgImageBox.TabStop = false;
            // 
            // PngImageBox
            // 
            this.PngImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PngImageBox.BackColor = System.Drawing.Color.Transparent;
            this.PngImageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PngImageBox.BackgroundImage")));
            this.PngImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PngImageBox.Location = new System.Drawing.Point(111, 4);
            this.PngImageBox.Name = "PngImageBox";
            this.PngImageBox.Size = new System.Drawing.Size(25, 25);
            this.PngImageBox.TabIndex = 31;
            this.PngImageBox.TabStop = false;
            // 
            // CnpjInstituicaoMaskedTextBox
            // 
            this.CnpjInstituicaoMaskedTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnpjInstituicaoMaskedTextBox.Location = new System.Drawing.Point(159, 138);
            this.CnpjInstituicaoMaskedTextBox.Mask = "00,000,000/0000-00";
            this.CnpjInstituicaoMaskedTextBox.Name = "CnpjInstituicaoMaskedTextBox";
            this.CnpjInstituicaoMaskedTextBox.Size = new System.Drawing.Size(172, 33);
            this.CnpjInstituicaoMaskedTextBox.TabIndex = 32;
            this.CnpjInstituicaoMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Mp4ImageBox
            // 
            this.Mp4ImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Mp4ImageBox.BackColor = System.Drawing.Color.Transparent;
            this.Mp4ImageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mp4ImageBox.BackgroundImage")));
            this.Mp4ImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Mp4ImageBox.Location = new System.Drawing.Point(162, 4);
            this.Mp4ImageBox.Name = "Mp4ImageBox";
            this.Mp4ImageBox.Size = new System.Drawing.Size(25, 25);
            this.Mp4ImageBox.TabIndex = 33;
            this.Mp4ImageBox.TabStop = false;
            // 
            // MidiaPanel
            // 
            this.MidiaPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MidiaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.MidiaPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MidiaPanel.Controls.Add(this.panel1);
            this.MidiaPanel.Controls.Add(this.MidiaLabel);
            this.MidiaPanel.Controls.Add(this.CaminhoMidia1TextBox);
            this.MidiaPanel.Controls.Add(this.SelecionarMidiaBotao);
            this.MidiaPanel.Controls.Add(this.CaminhoMidia2TextBox);
            this.MidiaPanel.Controls.Add(this.CaminhoMidia3TextBox);
            this.MidiaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidiaPanel.Location = new System.Drawing.Point(775, 3);
            this.MidiaPanel.Name = "MidiaPanel";
            this.MidiaPanel.Size = new System.Drawing.Size(766, 185);
            this.MidiaPanel.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.JpgImageBox);
            this.panel1.Controls.Add(this.WppImageBox);
            this.panel1.Controls.Add(this.Mp4ImageBox);
            this.panel1.Controls.Add(this.PngImageBox);
            this.panel1.Location = new System.Drawing.Point(8, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 38);
            this.panel1.TabIndex = 43;
            // 
            // DadosUsuarioPanel
            // 
            this.DadosUsuarioPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.DadosUsuarioPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DadosUsuarioPanel.Controls.Add(this.CnpjInstituicaoMaskedTextBox);
            this.DadosUsuarioPanel.Controls.Add(this.NomeTextBox);
            this.DadosUsuarioPanel.Controls.Add(this.EmailTextBox);
            this.DadosUsuarioPanel.Controls.Add(this.NomeLabel);
            this.DadosUsuarioPanel.Controls.Add(this.EmailLabel);
            this.DadosUsuarioPanel.Controls.Add(this.DanosCheckBox);
            this.DadosUsuarioPanel.Controls.Add(this.TipoNecessidadeLabel);
            this.DadosUsuarioPanel.Controls.Add(this.CnpjInstituicaoReclamadaLabel);
            this.DadosUsuarioPanel.Controls.Add(this.TipoNecessidadeComboBox);
            this.DadosUsuarioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DadosUsuarioPanel.Location = new System.Drawing.Point(3, 3);
            this.DadosUsuarioPanel.Name = "DadosUsuarioPanel";
            this.DadosUsuarioPanel.Size = new System.Drawing.Size(766, 185);
            this.DadosUsuarioPanel.TabIndex = 35;
            // 
            // InsiraDadosPanel
            // 
            this.InsiraDadosPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InsiraDadosPanel.Controls.Add(this.InsiraDadosLabel);
            this.InsiraDadosPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsiraDadosPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsiraDadosPanel.Location = new System.Drawing.Point(0, 0);
            this.InsiraDadosPanel.Name = "InsiraDadosPanel";
            this.InsiraDadosPanel.Size = new System.Drawing.Size(1544, 57);
            this.InsiraDadosPanel.TabIndex = 38;
            // 
            // DadosLayoutPanel
            // 
            this.DadosLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DadosLayoutPanel.ColumnCount = 2;
            this.DadosLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DadosLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DadosLayoutPanel.Controls.Add(this.DadosUsuarioPanel, 0, 0);
            this.DadosLayoutPanel.Controls.Add(this.MidiaPanel, 1, 0);
            this.DadosLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DadosLayoutPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DadosLayoutPanel.Location = new System.Drawing.Point(0, 57);
            this.DadosLayoutPanel.Name = "DadosLayoutPanel";
            this.DadosLayoutPanel.RowCount = 1;
            this.DadosLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DadosLayoutPanel.Size = new System.Drawing.Size(1544, 191);
            this.DadosLayoutPanel.TabIndex = 39;
            // 
            // BotaoEnviar
            // 
            this.BotaoEnviar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotaoEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.BotaoEnviar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotaoEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotaoEnviar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoEnviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BotaoEnviar.Image = ((System.Drawing.Image)(resources.GetObject("BotaoEnviar.Image")));
            this.BotaoEnviar.Location = new System.Drawing.Point(10, 10);
            this.BotaoEnviar.Margin = new System.Windows.Forms.Padding(10);
            this.BotaoEnviar.Name = "BotaoEnviar";
            this.BotaoEnviar.Size = new System.Drawing.Size(1090, 34);
            this.BotaoEnviar.TabIndex = 2;
            this.BotaoEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotaoEnviar.UseVisualStyleBackColor = false;
            this.BotaoEnviar.Click += new System.EventHandler(this.BotaoEnviar_Click);
            this.BotaoEnviar.MouseHover += new System.EventHandler(this.BotaoEnviar_MouseHover);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BotaoEnviar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(219, 696);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1110, 57);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // TextoTextBox
            // 
            this.TextoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextoTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoTextBox.Location = new System.Drawing.Point(0, 39);
            this.TextoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TextoTextBox.Multiline = true;
            this.TextoTextBox.Name = "TextoTextBox";
            this.TextoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextoTextBox.Size = new System.Drawing.Size(1219, 358);
            this.TextoTextBox.TabIndex = 4;
            this.TextoTextBox.Text = "Escreva um texto com no máximo 5.000 caracteres.*";
            this.TextoTextBox.Click += new System.EventHandler(this.TextoTextBox_Click);
            this.TextoTextBox.TextChanged += new System.EventHandler(this.TextoTextBox_TextChanged);
            // 
            // TituloTextoTextBox
            // 
            this.TituloTextoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TituloTextoTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloTextoTextBox.Location = new System.Drawing.Point(0, 0);
            this.TituloTextoTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.TituloTextoTextBox.Name = "TituloTextoTextBox";
            this.TituloTextoTextBox.Size = new System.Drawing.Size(1219, 33);
            this.TituloTextoTextBox.TabIndex = 17;
            this.TituloTextoTextBox.Text = "Insira o título do seu texto*";
            this.TituloTextoTextBox.Click += new System.EventHandler(this.TituloTextoTextBox_Click);
            this.TituloTextoTextBox.TextChanged += new System.EventHandler(this.TituloTextoTextBox_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.TituloTextoTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TextoTextBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(174, 259);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1219, 397);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // ReclameAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1544, 761);
            this.Controls.Add(this.AvisoAsteriscoLabel);
            this.Controls.Add(this.CaracteresLbl);
            this.Controls.Add(this.CaracteresAtualLbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DadosLayoutPanel);
            this.Controls.Add(this.CaracteresMaxLbl);
            this.Controls.Add(this.InsiraDadosPanel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1560, 800);
            this.Name = "ReclameAcesso";
            this.Text = "Reclame Acesso";
            ((System.ComponentModel.ISupportInitialize)(this.WppImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JpgImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PngImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mp4ImageBox)).EndInit();
            this.MidiaPanel.ResumeLayout(false);
            this.MidiaPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.DadosUsuarioPanel.ResumeLayout(false);
            this.DadosUsuarioPanel.PerformLayout();
            this.InsiraDadosPanel.ResumeLayout(false);
            this.InsiraDadosPanel.PerformLayout();
            this.DadosLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label InsiraDadosLabel;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AvisoAsteriscoLabel;
        private System.Windows.Forms.Label MidiaLabel;
        private System.Windows.Forms.TextBox CaminhoMidia1TextBox;
        private System.Windows.Forms.CheckBox DanosCheckBox;
        private System.Windows.Forms.ToolTip DicaDanos;
        private System.Windows.Forms.Label TipoNecessidadeLabel;
        private System.Windows.Forms.ComboBox TipoNecessidadeComboBox;
        private System.Windows.Forms.Button SelecionarMidiaBotao;
        private System.Windows.Forms.TextBox CaminhoMidia2TextBox;
        private System.Windows.Forms.TextBox CaminhoMidia3TextBox;
        private System.Windows.Forms.Label CnpjInstituicaoReclamadaLabel;
        private System.Windows.Forms.Label CaracteresLbl;
        private System.Windows.Forms.Label CaracteresAtualLbl;
        private System.Windows.Forms.Label CaracteresMaxLbl;
        private System.Windows.Forms.PictureBox WppImageBox;
        private System.Windows.Forms.PictureBox JpgImageBox;
        private System.Windows.Forms.PictureBox PngImageBox;
        private System.Windows.Forms.MaskedTextBox CnpjInstituicaoMaskedTextBox;
        private System.Windows.Forms.PictureBox Mp4ImageBox;
        private System.Windows.Forms.Panel MidiaPanel;
        private System.Windows.Forms.Panel DadosUsuarioPanel;
        private System.Windows.Forms.Panel InsiraDadosPanel;
        private System.Windows.Forms.TableLayoutPanel DadosLayoutPanel;
        private System.Windows.Forms.Button BotaoEnviar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TextoTextBox;
        private System.Windows.Forms.TextBox TituloTextoTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
    }
}

