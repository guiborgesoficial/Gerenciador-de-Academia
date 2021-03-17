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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_novoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_gerarPDF)).BeginInit();
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
            // USC_dadosAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
