﻿namespace RCFitness
{
    partial class frm_Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sistema));
            this.pnl_menuLateral = new System.Windows.Forms.Panel();
            this.customBotãoImage1 = new BotãoDinamico.CustomBotãoImage();
            this.btn_dados = new BotãoDinamico.CustomBotãoImage();
            this.btn_alunoMatriculado = new BotãoDinamico.CustomBotãoImage();
            this.btn_fichaTreino = new BotãoDinamico.CustomBotãoImage();
            this.btn_peso = new BotãoDinamico.CustomBotãoImage();
            this.btn_medidas = new BotãoDinamico.CustomBotãoImage();
            this.btn_novoAluno = new BotãoDinamico.CustomBotãoImage();
            this.pictbox_logo = new System.Windows.Forms.PictureBox();
            this.pnl_UserControl = new System.Windows.Forms.Panel();
            this.btn_gerarPDF = new BotãoDinamico.CustomBotãoImage();
            this.usC_chtFaturamento1 = new RCFitness.UserControls.Charts.USC_chtFaturamento();
            this.usC_chtAlunos = new RCFitness.UserControls.Charts.USC_chtAlunos();
            this.lbl_longData = new System.Windows.Forms.Label();
            this.lbl_datalonga = new System.Windows.Forms.Label();
            this.lbl_dataCurta = new System.Windows.Forms.Label();
            this.USC_emailSender1 = new RCFitness.UserControls.USC_emailSender();
            this.usC_medidasAluno1 = new RCFitness.UserControls.USC_medidasAluno();
            this.usC_fichaTreino1 = new RCFitness.UserControls.USC_fichaTreino();
            this.usC_pesoAluno1 = new RCFitness.UserControls.USC_pesoAluno();
            this.usC_matriculados1 = new RCFitness.UserControls.USC_matriculados();
            this.usC_novoAluno1 = new RCFitness.UserControls.USC_novoAluno();
            this.timer_dataCurta = new System.Windows.Forms.Timer(this.components);
            this.pnl_menuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customBotãoImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_alunoMatriculado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fichaTreino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_medidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_novoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_logo)).BeginInit();
            this.pnl_UserControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_gerarPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menuLateral
            // 
            this.pnl_menuLateral.BackColor = System.Drawing.Color.Goldenrod;
            this.pnl_menuLateral.Controls.Add(this.customBotãoImage1);
            this.pnl_menuLateral.Controls.Add(this.btn_dados);
            this.pnl_menuLateral.Controls.Add(this.btn_alunoMatriculado);
            this.pnl_menuLateral.Controls.Add(this.btn_fichaTreino);
            this.pnl_menuLateral.Controls.Add(this.btn_peso);
            this.pnl_menuLateral.Controls.Add(this.btn_medidas);
            this.pnl_menuLateral.Controls.Add(this.btn_novoAluno);
            this.pnl_menuLateral.Controls.Add(this.pictbox_logo);
            this.pnl_menuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnl_menuLateral.Name = "pnl_menuLateral";
            this.pnl_menuLateral.Size = new System.Drawing.Size(126, 451);
            this.pnl_menuLateral.TabIndex = 0;
            // 
            // customBotãoImage1
            // 
            this.customBotãoImage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customBotãoImage1.Image = ((System.Drawing.Image)(resources.GetObject("customBotãoImage1.Image")));
            this.customBotãoImage1.ImageHover = ((System.Drawing.Image)(resources.GetObject("customBotãoImage1.ImageHover")));
            this.customBotãoImage1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customBotãoImage1.ImageNormal")));
            this.customBotãoImage1.Location = new System.Drawing.Point(3, 417);
            this.customBotãoImage1.Name = "customBotãoImage1";
            this.customBotãoImage1.Size = new System.Drawing.Size(29, 31);
            this.customBotãoImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customBotãoImage1.TabIndex = 8;
            this.customBotãoImage1.TabStop = false;
            this.customBotãoImage1.Click += new System.EventHandler(this.customBotãoImage1_Click);
            // 
            // btn_dados
            // 
            this.btn_dados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dados.Image = ((System.Drawing.Image)(resources.GetObject("btn_dados.Image")));
            this.btn_dados.ImageHover = ((System.Drawing.Image)(resources.GetObject("btn_dados.ImageHover")));
            this.btn_dados.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_dados.ImageNormal")));
            this.btn_dados.Location = new System.Drawing.Point(34, 284);
            this.btn_dados.Name = "btn_dados";
            this.btn_dados.Size = new System.Drawing.Size(65, 49);
            this.btn_dados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_dados.TabIndex = 7;
            this.btn_dados.TabStop = false;
            this.btn_dados.Click += new System.EventHandler(this.btn_dados_Click);
            // 
            // btn_alunoMatriculado
            // 
            this.btn_alunoMatriculado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alunoMatriculado.Image = ((System.Drawing.Image)(resources.GetObject("btn_alunoMatriculado.Image")));
            this.btn_alunoMatriculado.ImageHover = ((System.Drawing.Image)(resources.GetObject("btn_alunoMatriculado.ImageHover")));
            this.btn_alunoMatriculado.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_alunoMatriculado.ImageNormal")));
            this.btn_alunoMatriculado.Location = new System.Drawing.Point(34, 119);
            this.btn_alunoMatriculado.Name = "btn_alunoMatriculado";
            this.btn_alunoMatriculado.Size = new System.Drawing.Size(65, 49);
            this.btn_alunoMatriculado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_alunoMatriculado.TabIndex = 6;
            this.btn_alunoMatriculado.TabStop = false;
            this.btn_alunoMatriculado.Click += new System.EventHandler(this.btn_alunoMatriculado_Click);
            // 
            // btn_fichaTreino
            // 
            this.btn_fichaTreino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fichaTreino.Image = ((System.Drawing.Image)(resources.GetObject("btn_fichaTreino.Image")));
            this.btn_fichaTreino.ImageHover = ((System.Drawing.Image)(resources.GetObject("btn_fichaTreino.ImageHover")));
            this.btn_fichaTreino.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_fichaTreino.ImageNormal")));
            this.btn_fichaTreino.Location = new System.Drawing.Point(34, 229);
            this.btn_fichaTreino.Name = "btn_fichaTreino";
            this.btn_fichaTreino.Size = new System.Drawing.Size(65, 49);
            this.btn_fichaTreino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_fichaTreino.TabIndex = 5;
            this.btn_fichaTreino.TabStop = false;
            this.btn_fichaTreino.Click += new System.EventHandler(this.btn_fichaTreino_Click);
            // 
            // btn_peso
            // 
            this.btn_peso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_peso.Image = ((System.Drawing.Image)(resources.GetObject("btn_peso.Image")));
            this.btn_peso.ImageHover = ((System.Drawing.Image)(resources.GetObject("btn_peso.ImageHover")));
            this.btn_peso.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_peso.ImageNormal")));
            this.btn_peso.Location = new System.Drawing.Point(34, 174);
            this.btn_peso.Name = "btn_peso";
            this.btn_peso.Size = new System.Drawing.Size(65, 49);
            this.btn_peso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_peso.TabIndex = 4;
            this.btn_peso.TabStop = false;
            this.btn_peso.Click += new System.EventHandler(this.btn_peso_Click);
            // 
            // btn_medidas
            // 
            this.btn_medidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_medidas.Image = ((System.Drawing.Image)(resources.GetObject("btn_medidas.Image")));
            this.btn_medidas.ImageHover = ((System.Drawing.Image)(resources.GetObject("btn_medidas.ImageHover")));
            this.btn_medidas.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_medidas.ImageNormal")));
            this.btn_medidas.Location = new System.Drawing.Point(26, 339);
            this.btn_medidas.Name = "btn_medidas";
            this.btn_medidas.Size = new System.Drawing.Size(66, 49);
            this.btn_medidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_medidas.TabIndex = 3;
            this.btn_medidas.TabStop = false;
            this.btn_medidas.Click += new System.EventHandler(this.btn_medidas_Click);
            // 
            // btn_novoAluno
            // 
            this.btn_novoAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novoAluno.Image = ((System.Drawing.Image)(resources.GetObject("btn_novoAluno.Image")));
            this.btn_novoAluno.ImageHover = ((System.Drawing.Image)(resources.GetObject("btn_novoAluno.ImageHover")));
            this.btn_novoAluno.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_novoAluno.ImageNormal")));
            this.btn_novoAluno.Location = new System.Drawing.Point(34, 64);
            this.btn_novoAluno.Name = "btn_novoAluno";
            this.btn_novoAluno.Size = new System.Drawing.Size(65, 49);
            this.btn_novoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_novoAluno.TabIndex = 2;
            this.btn_novoAluno.TabStop = false;
            this.btn_novoAluno.Click += new System.EventHandler(this.btn_novoAluno_Click);
            // 
            // pictbox_logo
            // 
            this.pictbox_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictbox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictbox_logo.Image")));
            this.pictbox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictbox_logo.Name = "pictbox_logo";
            this.pictbox_logo.Size = new System.Drawing.Size(126, 60);
            this.pictbox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbox_logo.TabIndex = 1;
            this.pictbox_logo.TabStop = false;
            this.pictbox_logo.Click += new System.EventHandler(this.pictbox_logo_Click);
            // 
            // pnl_UserControl
            // 
            this.pnl_UserControl.Controls.Add(this.btn_gerarPDF);
            this.pnl_UserControl.Controls.Add(this.usC_chtFaturamento1);
            this.pnl_UserControl.Controls.Add(this.usC_chtAlunos);
            this.pnl_UserControl.Controls.Add(this.lbl_longData);
            this.pnl_UserControl.Controls.Add(this.lbl_datalonga);
            this.pnl_UserControl.Controls.Add(this.lbl_dataCurta);
            this.pnl_UserControl.Controls.Add(this.USC_emailSender1);
            this.pnl_UserControl.Controls.Add(this.usC_medidasAluno1);
            this.pnl_UserControl.Controls.Add(this.usC_fichaTreino1);
            this.pnl_UserControl.Controls.Add(this.usC_pesoAluno1);
            this.pnl_UserControl.Controls.Add(this.usC_matriculados1);
            this.pnl_UserControl.Controls.Add(this.usC_novoAluno1);
            this.pnl_UserControl.Location = new System.Drawing.Point(125, 0);
            this.pnl_UserControl.Name = "pnl_UserControl";
            this.pnl_UserControl.Size = new System.Drawing.Size(782, 451);
            this.pnl_UserControl.TabIndex = 1;
            // 
            // btn_gerarPDF
            // 
            this.btn_gerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gerarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btn_gerarPDF.Image")));
            this.btn_gerarPDF.ImageHover = ((System.Drawing.Image)(resources.GetObject("btn_gerarPDF.ImageHover")));
            this.btn_gerarPDF.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_gerarPDF.ImageNormal")));
            this.btn_gerarPDF.Location = new System.Drawing.Point(681, 417);
            this.btn_gerarPDF.Name = "btn_gerarPDF";
            this.btn_gerarPDF.Size = new System.Drawing.Size(89, 25);
            this.btn_gerarPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_gerarPDF.TabIndex = 73;
            this.btn_gerarPDF.TabStop = false;
            this.btn_gerarPDF.Click += new System.EventHandler(this.btn_gerarPDF_Click);
            // 
            // usC_chtFaturamento1
            // 
            this.usC_chtFaturamento1.Location = new System.Drawing.Point(3, 49);
            this.usC_chtFaturamento1.Name = "usC_chtFaturamento1";
            this.usC_chtFaturamento1.Size = new System.Drawing.Size(429, 266);
            this.usC_chtFaturamento1.TabIndex = 11;
            // 
            // usC_chtAlunos
            // 
            this.usC_chtAlunos.Location = new System.Drawing.Point(435, 49);
            this.usC_chtAlunos.MaximumSize = new System.Drawing.Size(545, 389);
            this.usC_chtAlunos.Name = "usC_chtAlunos";
            this.usC_chtAlunos.Size = new System.Drawing.Size(335, 250);
            this.usC_chtAlunos.TabIndex = 9;
            // 
            // lbl_longData
            // 
            this.lbl_longData.AutoSize = true;
            this.lbl_longData.BackColor = System.Drawing.Color.Transparent;
            this.lbl_longData.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_longData.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_longData.Location = new System.Drawing.Point(7, 3);
            this.lbl_longData.Name = "lbl_longData";
            this.lbl_longData.Size = new System.Drawing.Size(72, 17);
            this.lbl_longData.TabIndex = 8;
            this.lbl_longData.Text = "dataLonga";
            // 
            // lbl_datalonga
            // 
            this.lbl_datalonga.AutoSize = true;
            this.lbl_datalonga.BackColor = System.Drawing.Color.Transparent;
            this.lbl_datalonga.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datalonga.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_datalonga.Location = new System.Drawing.Point(692, 3);
            this.lbl_datalonga.Name = "lbl_datalonga";
            this.lbl_datalonga.Size = new System.Drawing.Size(68, 25);
            this.lbl_datalonga.TabIndex = 7;
            this.lbl_datalonga.Text = "tempo";
            // 
            // lbl_dataCurta
            // 
            this.lbl_dataCurta.AutoSize = true;
            this.lbl_dataCurta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dataCurta.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataCurta.Location = new System.Drawing.Point(7, 19);
            this.lbl_dataCurta.Name = "lbl_dataCurta";
            this.lbl_dataCurta.Size = new System.Drawing.Size(70, 17);
            this.lbl_dataCurta.TabIndex = 6;
            this.lbl_dataCurta.Text = "data curta";
            // 
            // USC_emailSender1
            // 
            this.USC_emailSender1.Location = new System.Drawing.Point(0, 0);
            this.USC_emailSender1.Name = "USC_emailSender1";
            this.USC_emailSender1.Size = new System.Drawing.Size(668, 451);
            this.USC_emailSender1.TabIndex = 5;
            // 
            // usC_medidasAluno1
            // 
            this.usC_medidasAluno1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.usC_medidasAluno1.Location = new System.Drawing.Point(0, 0);
            this.usC_medidasAluno1.Name = "usC_medidasAluno1";
            this.usC_medidasAluno1.Size = new System.Drawing.Size(668, 451);
            this.usC_medidasAluno1.TabIndex = 4;
            // 
            // usC_fichaTreino1
            // 
            this.usC_fichaTreino1.Location = new System.Drawing.Point(0, 0);
            this.usC_fichaTreino1.Name = "usC_fichaTreino1";
            this.usC_fichaTreino1.Size = new System.Drawing.Size(668, 451);
            this.usC_fichaTreino1.TabIndex = 3;
            // 
            // usC_pesoAluno1
            // 
            this.usC_pesoAluno1.Location = new System.Drawing.Point(0, 0);
            this.usC_pesoAluno1.Name = "usC_pesoAluno1";
            this.usC_pesoAluno1.Size = new System.Drawing.Size(668, 451);
            this.usC_pesoAluno1.TabIndex = 2;
            // 
            // usC_matriculados1
            // 
            this.usC_matriculados1.Location = new System.Drawing.Point(0, 0);
            this.usC_matriculados1.Name = "usC_matriculados1";
            this.usC_matriculados1.Size = new System.Drawing.Size(668, 451);
            this.usC_matriculados1.TabIndex = 1;
            // 
            // usC_novoAluno1
            // 
            this.usC_novoAluno1.Location = new System.Drawing.Point(0, 0);
            this.usC_novoAluno1.Name = "usC_novoAluno1";
            this.usC_novoAluno1.Size = new System.Drawing.Size(668, 451);
            this.usC_novoAluno1.TabIndex = 0;
            // 
            // timer_dataCurta
            // 
            this.timer_dataCurta.Enabled = true;
            this.timer_dataCurta.Tick += new System.EventHandler(this.timer_dataCurta_Tick);
            // 
            // frm_Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.pnl_UserControl);
            this.Controls.Add(this.pnl_menuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Sistema";
            this.pnl_menuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customBotãoImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_alunoMatriculado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fichaTreino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_medidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_novoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_logo)).EndInit();
            this.pnl_UserControl.ResumeLayout(false);
            this.pnl_UserControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_gerarPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictbox_logo;
        private BotãoDinamico.CustomBotãoImage btn_alunoMatriculado;
        private BotãoDinamico.CustomBotãoImage btn_fichaTreino;
        private BotãoDinamico.CustomBotãoImage btn_peso;
        private BotãoDinamico.CustomBotãoImage btn_medidas;
        private BotãoDinamico.CustomBotãoImage btn_novoAluno;
        private BotãoDinamico.CustomBotãoImage btn_dados;
        private BotãoDinamico.CustomBotãoImage customBotãoImage1;
        private UserControls.USC_novoAluno usC_novoAluno1;
        public System.Windows.Forms.Panel pnl_UserControl;
        private UserControls.USC_matriculados usC_matriculados1;
        private UserControls.USC_pesoAluno usC_pesoAluno1;
        private UserControls.USC_fichaTreino usC_fichaTreino1;
        private UserControls.USC_medidasAluno usC_medidasAluno1;
        private UserControls.USC_emailSender USC_emailSender1;
        private System.Windows.Forms.Label lbl_dataCurta;
        private System.Windows.Forms.Timer timer_dataCurta;
        private System.Windows.Forms.Label lbl_datalonga;
        private System.Windows.Forms.Label lbl_longData;
        private UserControls.Charts.USC_chtAlunos usC_chtAlunos;
        protected System.Windows.Forms.Panel pnl_menuLateral;
        private UserControls.Charts.USC_chtFaturamento usC_chtFaturamento1;
        private BotãoDinamico.CustomBotãoImage btn_gerarPDF;
    }
}

