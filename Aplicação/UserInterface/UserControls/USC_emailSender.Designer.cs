namespace RCFitness.UserControls
{
    partial class USC_dadosAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USC_dadosAluno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictbox_novoAluno = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new BotãoDinamico.CustomBotãoImage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbbox_aluno = new System.Windows.Forms.ComboBox();
            this.lbl_aluno = new System.Windows.Forms.Label();
            this.btn_gerarPDF = new BotãoDinamico.CustomBotãoImage();
            this.lbl_idResult = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.groupBox_Configurações = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.groupBox_ConfigureSuaMensagem = new System.Windows.Forms.GroupBox();
            this.textBox_anexo = new System.Windows.Forms.TextBox();
            this.btn_anexoBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_escreverEmail = new System.Windows.Forms.TextBox();
            this.textBox_assunto = new System.Windows.Forms.TextBox();
            this.lbl_escreverEmail = new System.Windows.Forms.Label();
            this.lbl_assunto = new System.Windows.Forms.Label();
            this.bnt_config = new BotãoDinamico.CustomBotãoImage();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.checkBox_cobrançaEmail = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_novoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_gerarPDF)).BeginInit();
            this.groupBox_Configurações.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox_ConfigureSuaMensagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_config)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.pictbox_novoAluno);
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 480);
            this.panel1.TabIndex = 3;
            // 
            // pictbox_novoAluno
            // 
            this.pictbox_novoAluno.Image = ((System.Drawing.Image)(resources.GetObject("pictbox_novoAluno.Image")));
            this.pictbox_novoAluno.Location = new System.Drawing.Point(3, 52);
            this.pictbox_novoAluno.Name = "pictbox_novoAluno";
            this.pictbox_novoAluno.Size = new System.Drawing.Size(67, 339);
            this.pictbox_novoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbox_novoAluno.TabIndex = 1;
            this.pictbox_novoAluno.TabStop = false;
            // 
            // btn_voltar
            // 
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
            // cmbbox_aluno
            // 
            this.cmbbox_aluno.FormattingEnabled = true;
            this.cmbbox_aluno.Location = new System.Drawing.Point(147, 32);
            this.cmbbox_aluno.Name = "cmbbox_aluno";
            this.cmbbox_aluno.Size = new System.Drawing.Size(231, 21);
            this.cmbbox_aluno.TabIndex = 71;
            this.cmbbox_aluno.SelectedIndexChanged += new System.EventHandler(this.cmbbox_aluno_SelectedIndexChanged);
            this.cmbbox_aluno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbbox_aluno_MouseClick);
            // 
            // lbl_aluno
            // 
            this.lbl_aluno.AutoSize = true;
            this.lbl_aluno.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aluno.Location = new System.Drawing.Point(82, 34);
            this.lbl_aluno.Name = "lbl_aluno";
            this.lbl_aluno.Size = new System.Drawing.Size(68, 21);
            this.lbl_aluno.TabIndex = 70;
            this.lbl_aluno.Text = "ALUNO:";
            // 
            // btn_gerarPDF
            // 
            this.btn_gerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gerarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btn_gerarPDF.Image")));
            this.btn_gerarPDF.ImageHover = ((System.Drawing.Image)(resources.GetObject("btn_gerarPDF.ImageHover")));
            this.btn_gerarPDF.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_gerarPDF.ImageNormal")));
            this.btn_gerarPDF.Location = new System.Drawing.Point(669, 28);
            this.btn_gerarPDF.Name = "btn_gerarPDF";
            this.btn_gerarPDF.Size = new System.Drawing.Size(89, 25);
            this.btn_gerarPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_gerarPDF.TabIndex = 72;
            this.btn_gerarPDF.TabStop = false;
            // 
            // lbl_idResult
            // 
            this.lbl_idResult.AutoSize = true;
            this.lbl_idResult.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idResult.Location = new System.Drawing.Point(434, 32);
            this.lbl_idResult.Name = "lbl_idResult";
            this.lbl_idResult.Size = new System.Drawing.Size(30, 21);
            this.lbl_idResult.TabIndex = 84;
            this.lbl_idResult.Text = "ID:";
            this.lbl_idResult.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(396, 32);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 21);
            this.lbl_id.TabIndex = 83;
            this.lbl_id.Text = "ID:";
            this.lbl_id.Visible = false;
            // 
            // groupBox_Configurações
            // 
            this.groupBox_Configurações.Controls.Add(this.checkBox_cobrançaEmail);
            this.groupBox_Configurações.Controls.Add(this.pictureBox2);
            this.groupBox_Configurações.Controls.Add(this.btn_salvar);
            this.groupBox_Configurações.Controls.Add(this.textBox_senha);
            this.groupBox_Configurações.Controls.Add(this.textBox_email);
            this.groupBox_Configurações.Controls.Add(this.lbl_Email);
            this.groupBox_Configurações.Controls.Add(this.lbl_senha);
            this.groupBox_Configurações.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Configurações.Location = new System.Drawing.Point(86, 295);
            this.groupBox_Configurações.Name = "groupBox_Configurações";
            this.groupBox_Configurações.Size = new System.Drawing.Size(624, 145);
            this.groupBox_Configurações.TabIndex = 91;
            this.groupBox_Configurações.TabStop = false;
            this.groupBox_Configurações.Text = "Configurações e Conta";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(264, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Location = new System.Drawing.Point(6, 94);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(233, 23);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(67, 45);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(191, 20);
            this.textBox_senha.TabIndex = 2;
            this.textBox_senha.UseSystemPasswordChar = true;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(67, 19);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(191, 20);
            this.textBox_email.TabIndex = 0;
            this.textBox_email.Text = "DIGITE O SEU EMAIL";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(4, 16);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(67, 21);
            this.lbl_Email.TabIndex = 10;
            this.lbl_Email.Text = "E-MAIL:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(4, 42);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(66, 21);
            this.lbl_senha.TabIndex = 11;
            this.lbl_senha.Text = "SENHA:";
            // 
            // groupBox_ConfigureSuaMensagem
            // 
            this.groupBox_ConfigureSuaMensagem.Controls.Add(this.btn_enviar);
            this.groupBox_ConfigureSuaMensagem.Controls.Add(this.textBox_anexo);
            this.groupBox_ConfigureSuaMensagem.Controls.Add(this.btn_anexoBuscar);
            this.groupBox_ConfigureSuaMensagem.Controls.Add(this.label3);
            this.groupBox_ConfigureSuaMensagem.Controls.Add(this.textBox_escreverEmail);
            this.groupBox_ConfigureSuaMensagem.Controls.Add(this.textBox_assunto);
            this.groupBox_ConfigureSuaMensagem.Controls.Add(this.lbl_escreverEmail);
            this.groupBox_ConfigureSuaMensagem.Controls.Add(this.lbl_assunto);
            this.groupBox_ConfigureSuaMensagem.Location = new System.Drawing.Point(86, 68);
            this.groupBox_ConfigureSuaMensagem.Name = "groupBox_ConfigureSuaMensagem";
            this.groupBox_ConfigureSuaMensagem.Size = new System.Drawing.Size(672, 221);
            this.groupBox_ConfigureSuaMensagem.TabIndex = 92;
            this.groupBox_ConfigureSuaMensagem.TabStop = false;
            this.groupBox_ConfigureSuaMensagem.Text = "Configure Sua Mensagem";
            // 
            // textBox_anexo
            // 
            this.textBox_anexo.Location = new System.Drawing.Point(186, 172);
            this.textBox_anexo.Name = "textBox_anexo";
            this.textBox_anexo.Size = new System.Drawing.Size(122, 20);
            this.textBox_anexo.TabIndex = 101;
            // 
            // btn_anexoBuscar
            // 
            this.btn_anexoBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anexoBuscar.Location = new System.Drawing.Point(314, 169);
            this.btn_anexoBuscar.Name = "btn_anexoBuscar";
            this.btn_anexoBuscar.Size = new System.Drawing.Size(89, 23);
            this.btn_anexoBuscar.TabIndex = 100;
            this.btn_anexoBuscar.Text = "BUSCAR";
            this.btn_anexoBuscar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 99;
            this.label3.Text = "ANEXO:";
            // 
            // textBox_escreverEmail
            // 
            this.textBox_escreverEmail.Location = new System.Drawing.Point(117, 44);
            this.textBox_escreverEmail.Multiline = true;
            this.textBox_escreverEmail.Name = "textBox_escreverEmail";
            this.textBox_escreverEmail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_escreverEmail.Size = new System.Drawing.Size(408, 122);
            this.textBox_escreverEmail.TabIndex = 97;
            // 
            // textBox_assunto
            // 
            this.textBox_assunto.Location = new System.Drawing.Point(117, 21);
            this.textBox_assunto.Name = "textBox_assunto";
            this.textBox_assunto.Size = new System.Drawing.Size(408, 20);
            this.textBox_assunto.TabIndex = 95;
            // 
            // lbl_escreverEmail
            // 
            this.lbl_escreverEmail.AutoSize = true;
            this.lbl_escreverEmail.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_escreverEmail.Location = new System.Drawing.Point(8, 41);
            this.lbl_escreverEmail.Name = "lbl_escreverEmail";
            this.lbl_escreverEmail.Size = new System.Drawing.Size(103, 21);
            this.lbl_escreverEmail.TabIndex = 98;
            this.lbl_escreverEmail.Text = "MENSAGEM:";
            // 
            // lbl_assunto
            // 
            this.lbl_assunto.AutoSize = true;
            this.lbl_assunto.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_assunto.Location = new System.Drawing.Point(24, 18);
            this.lbl_assunto.Name = "lbl_assunto";
            this.lbl_assunto.Size = new System.Drawing.Size(87, 21);
            this.lbl_assunto.TabIndex = 96;
            this.lbl_assunto.Text = "ASSUNTO:";
            // 
            // bnt_config
            // 
            this.bnt_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_config.Image = ((System.Drawing.Image)(resources.GetObject("bnt_config.Image")));
            this.bnt_config.ImageHover = ((System.Drawing.Image)(resources.GetObject("bnt_config.ImageHover")));
            this.bnt_config.ImageNormal = ((System.Drawing.Image)(resources.GetObject("bnt_config.ImageNormal")));
            this.bnt_config.Location = new System.Drawing.Point(716, 295);
            this.bnt_config.Name = "bnt_config";
            this.bnt_config.Size = new System.Drawing.Size(42, 37);
            this.bnt_config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_config.TabIndex = 93;
            this.bnt_config.TabStop = false;
            this.bnt_config.Click += new System.EventHandler(this.bnt_config_Click);
            // 
            // btn_enviar
            // 
            this.btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enviar.Location = new System.Drawing.Point(440, 169);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(85, 23);
            this.btn_enviar.TabIndex = 18;
            this.btn_enviar.Text = "ENVIAR";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // checkBox_cobrançaEmail
            // 
            this.checkBox_cobrançaEmail.AutoSize = true;
            this.checkBox_cobrançaEmail.Location = new System.Drawing.Point(8, 71);
            this.checkBox_cobrançaEmail.Name = "checkBox_cobrançaEmail";
            this.checkBox_cobrançaEmail.Size = new System.Drawing.Size(388, 17);
            this.checkBox_cobrançaEmail.TabIndex = 18;
            this.checkBox_cobrançaEmail.Text = "Ativar avisos automáticos de mensalidades e cobranças de faturas por email.";
            this.checkBox_cobrançaEmail.UseVisualStyleBackColor = true;
            // 
            // USC_dadosAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bnt_config);
            this.Controls.Add(this.groupBox_ConfigureSuaMensagem);
            this.Controls.Add(this.groupBox_Configurações);
            this.Controls.Add(this.lbl_idResult);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_gerarPDF);
            this.Controls.Add(this.cmbbox_aluno);
            this.Controls.Add(this.lbl_aluno);
            this.Controls.Add(this.panel1);
            this.Name = "USC_dadosAluno";
            this.Size = new System.Drawing.Size(805, 453);
            this.Load += new System.EventHandler(this.USC_dadosAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_novoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_gerarPDF)).EndInit();
            this.groupBox_Configurações.ResumeLayout(false);
            this.groupBox_Configurações.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox_ConfigureSuaMensagem.ResumeLayout(false);
            this.groupBox_ConfigureSuaMensagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_config)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictbox_novoAluno;
        private BotãoDinamico.CustomBotãoImage btn_voltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbbox_aluno;
        private System.Windows.Forms.Label lbl_aluno;
        private BotãoDinamico.CustomBotãoImage btn_gerarPDF;
        private System.Windows.Forms.Label lbl_idResult;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.GroupBox groupBox_Configurações;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.GroupBox groupBox_ConfigureSuaMensagem;
        private System.Windows.Forms.TextBox textBox_anexo;
        private System.Windows.Forms.Button btn_anexoBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_escreverEmail;
        private System.Windows.Forms.TextBox textBox_assunto;
        private System.Windows.Forms.Label lbl_escreverEmail;
        private System.Windows.Forms.Label lbl_assunto;
        private BotãoDinamico.CustomBotãoImage bnt_config;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.CheckBox checkBox_cobrançaEmail;
    }
}
