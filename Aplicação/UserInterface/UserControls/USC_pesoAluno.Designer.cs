namespace RCFitness.UserControls
{
    partial class USC_pesoAluno
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USC_pesoAluno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictbox_novoAluno = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new BotãoDinamico.CustomBotãoImage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_consultar = new BotãoDinamico.CustomBotãoImage();
            this.btn_cadastrar = new BotãoDinamico.CustomBotãoImage();
            this.cmbbox_aluno = new System.Windows.Forms.ComboBox();
            this.lbl_aluno = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.lbl_imcResultado = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_idResult = new System.Windows.Forms.Label();
            this.lbl_resultadoIMC = new System.Windows.Forms.Label();
            this.msktbox_peso = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_novoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_consultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cadastrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.pictbox_novoAluno);
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 480);
            this.panel1.TabIndex = 2;
            // 
            // pictbox_novoAluno
            // 
            this.pictbox_novoAluno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictbox_novoAluno.Image = ((System.Drawing.Image)(resources.GetObject("pictbox_novoAluno.Image")));
            this.pictbox_novoAluno.Location = new System.Drawing.Point(3, 53);
            this.pictbox_novoAluno.Name = "pictbox_novoAluno";
            this.pictbox_novoAluno.Size = new System.Drawing.Size(67, 338);
            this.pictbox_novoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbox_novoAluno.TabIndex = 1;
            this.pictbox_novoAluno.TabStop = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageHover = ((System.Drawing.Image)(resources.GetObject("btn_voltar.ImageHover")));
            this.btn_voltar.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_voltar.ImageNormal")));
            this.btn_voltar.Location = new System.Drawing.Point(7, 395);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(57, 55);
            this.btn_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_voltar.TabIndex = 2;
            this.btn_voltar.TabStop = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultar.Image")));
            this.btn_consultar.ImageHover = ((System.Drawing.Image)(resources.GetObject("btn_consultar.ImageHover")));
            this.btn_consultar.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_consultar.ImageNormal")));
            this.btn_consultar.Location = new System.Drawing.Point(261, 395);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(174, 30);
            this.btn_consultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_consultar.TabIndex = 64;
            this.btn_consultar.TabStop = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.Image")));
            this.btn_cadastrar.ImageHover = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.ImageHover")));
            this.btn_cadastrar.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.ImageNormal")));
            this.btn_cadastrar.Location = new System.Drawing.Point(79, 395);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(176, 30);
            this.btn_cadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cadastrar.TabIndex = 62;
            this.btn_cadastrar.TabStop = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // cmbbox_aluno
            // 
            this.cmbbox_aluno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbbox_aluno.FormattingEnabled = true;
            this.cmbbox_aluno.Location = new System.Drawing.Point(197, 154);
            this.cmbbox_aluno.MinimumSize = new System.Drawing.Size(231, 0);
            this.cmbbox_aluno.Name = "cmbbox_aluno";
            this.cmbbox_aluno.Size = new System.Drawing.Size(231, 21);
            this.cmbbox_aluno.TabIndex = 0;
            this.cmbbox_aluno.SelectedIndexChanged += new System.EventHandler(this.cmbbox_aluno_SelectedIndexChanged);
            this.cmbbox_aluno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbbox_aluno_MouseClick);
            // 
            // lbl_aluno
            // 
            this.lbl_aluno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_aluno.AutoSize = true;
            this.lbl_aluno.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aluno.Location = new System.Drawing.Point(132, 156);
            this.lbl_aluno.MinimumSize = new System.Drawing.Size(68, 21);
            this.lbl_aluno.Name = "lbl_aluno";
            this.lbl_aluno.Size = new System.Drawing.Size(68, 21);
            this.lbl_aluno.TabIndex = 66;
            this.lbl_aluno.Text = "ALUNO:";
            // 
            // lbl_peso
            // 
            this.lbl_peso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peso.Location = new System.Drawing.Point(132, 189);
            this.lbl_peso.MinimumSize = new System.Drawing.Size(52, 21);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(52, 21);
            this.lbl_peso.TabIndex = 68;
            this.lbl_peso.Text = "PESO:";
            // 
            // lbl_imc
            // 
            this.lbl_imc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imc.Location = new System.Drawing.Point(132, 220);
            this.lbl_imc.MinimumSize = new System.Drawing.Size(44, 21);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(44, 21);
            this.lbl_imc.TabIndex = 70;
            this.lbl_imc.Text = "IMC:";
            this.lbl_imc.Visible = false;
            // 
            // lbl_imcResultado
            // 
            this.lbl_imcResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_imcResultado.AutoSize = true;
            this.lbl_imcResultado.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imcResultado.Location = new System.Drawing.Point(193, 220);
            this.lbl_imcResultado.MinimumSize = new System.Drawing.Size(52, 21);
            this.lbl_imcResultado.Name = "lbl_imcResultado";
            this.lbl_imcResultado.Size = new System.Drawing.Size(52, 21);
            this.lbl_imcResultado.TabIndex = 2;
            this.lbl_imcResultado.Text = "PESO:";
            this.lbl_imcResultado.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(132, 117);
            this.lbl_id.MinimumSize = new System.Drawing.Size(30, 21);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 21);
            this.lbl_id.TabIndex = 72;
            this.lbl_id.Text = "ID:";
            this.lbl_id.Visible = false;
            // 
            // lbl_idResult
            // 
            this.lbl_idResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_idResult.AutoSize = true;
            this.lbl_idResult.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idResult.Location = new System.Drawing.Point(193, 117);
            this.lbl_idResult.MinimumSize = new System.Drawing.Size(30, 21);
            this.lbl_idResult.Name = "lbl_idResult";
            this.lbl_idResult.Size = new System.Drawing.Size(30, 21);
            this.lbl_idResult.TabIndex = 73;
            this.lbl_idResult.Text = "ID:";
            this.lbl_idResult.Visible = false;
            // 
            // lbl_resultadoIMC
            // 
            this.lbl_resultadoIMC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_resultadoIMC.AutoSize = true;
            this.lbl_resultadoIMC.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultadoIMC.Location = new System.Drawing.Point(132, 254);
            this.lbl_resultadoIMC.MinimumSize = new System.Drawing.Size(101, 21);
            this.lbl_resultadoIMC.Name = "lbl_resultadoIMC";
            this.lbl_resultadoIMC.Size = new System.Drawing.Size(101, 21);
            this.lbl_resultadoIMC.TabIndex = 3;
            this.lbl_resultadoIMC.Text = "RESULTADO:";
            this.lbl_resultadoIMC.Visible = false;
            // 
            // msktbox_peso
            // 
            this.msktbox_peso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msktbox_peso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msktbox_peso.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.msktbox_peso.Location = new System.Drawing.Point(197, 189);
            this.msktbox_peso.MinimumSize = new System.Drawing.Size(231, 20);
            this.msktbox_peso.Name = "msktbox_peso";
            this.msktbox_peso.Size = new System.Drawing.Size(231, 20);
            this.msktbox_peso.TabIndex = 92;
            this.msktbox_peso.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktbox_peso.ValidatingType = typeof(System.DateTime);
            // 
            // USC_pesoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.msktbox_peso);
            this.Controls.Add(this.lbl_resultadoIMC);
            this.Controls.Add(this.lbl_idResult);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_imcResultado);
            this.Controls.Add(this.lbl_imc);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.cmbbox_aluno);
            this.Controls.Add(this.lbl_aluno);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.panel1);
            this.Name = "USC_pesoAluno";
            this.Size = new System.Drawing.Size(804, 454);
            this.Load += new System.EventHandler(this.USC_pesoAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_novoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_consultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cadastrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictbox_novoAluno;
        private BotãoDinamico.CustomBotãoImage btn_voltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BotãoDinamico.CustomBotãoImage btn_consultar;
        private BotãoDinamico.CustomBotãoImage btn_cadastrar;
        private System.Windows.Forms.Label lbl_aluno;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.Label lbl_imcResultado;
        private System.Windows.Forms.Label lbl_resultadoIMC;
        public System.Windows.Forms.ComboBox cmbbox_aluno;
        public System.Windows.Forms.Label lbl_idResult;
        public System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.MaskedTextBox msktbox_peso;
    }
}
