namespace RCFitness.UserControls
{
    partial class USC_matriculados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USC_matriculados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictbox_novoAluno = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new BotãoDinamico.CustomBotãoImage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbbox_aluno = new System.Windows.Forms.ComboBox();
            this.lbl_aluno = new System.Windows.Forms.Label();
            this.lbl_dtMatricula = new System.Windows.Forms.Label();
            this.lbl_dtUltimoPagamento = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_plano = new System.Windows.Forms.Label();
            this.lbl_próximoVenc = new System.Windows.Forms.Label();
            this.chckbox_pagarProxFatura = new System.Windows.Forms.CheckBox();
            this.lbl_dtMatriculaResultado = new System.Windows.Forms.Label();
            this.lbl_dtUltimoPagamentoResultado = new System.Windows.Forms.Label();
            this.lbl_próximoVencResultado = new System.Windows.Forms.Label();
            this.lbl_statusResultado = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_idResult = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.panel_resultado = new System.Windows.Forms.Panel();
            this.lbl_frequenciaResult = new System.Windows.Forms.Label();
            this.msktbox_Valor = new System.Windows.Forms.MaskedTextBox();
            this.cmbbox_Plano = new System.Windows.Forms.ComboBox();
            this.dataGridView_DadosPagamento = new System.Windows.Forms.DataGridView();
            this.btn_atualizar = new BotãoDinamico.CustomBotãoImage();
            this.lbl_frequencia = new System.Windows.Forms.Label();
            this.chckbox_ativo = new System.Windows.Forms.CheckBox();
            this.btn_frequencia = new BotãoDinamico.CustomBotãoImage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_novoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DadosPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_atualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_frequencia)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.cmbbox_aluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_aluno.FormattingEnabled = true;
            this.cmbbox_aluno.Items.AddRange(new object[] {
            "NENHUM"});
            this.cmbbox_aluno.Location = new System.Drawing.Point(156, 32);
            this.cmbbox_aluno.Name = "cmbbox_aluno";
            this.cmbbox_aluno.Size = new System.Drawing.Size(231, 21);
            this.cmbbox_aluno.TabIndex = 69;
            this.cmbbox_aluno.SelectedIndexChanged += new System.EventHandler(this.cmbbox_aluno_SelectedIndexChanged);
            this.cmbbox_aluno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbbox_aluno_MouseClick);
            // 
            // lbl_aluno
            // 
            this.lbl_aluno.AutoSize = true;
            this.lbl_aluno.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aluno.Location = new System.Drawing.Point(91, 34);
            this.lbl_aluno.Name = "lbl_aluno";
            this.lbl_aluno.Size = new System.Drawing.Size(68, 21);
            this.lbl_aluno.TabIndex = 68;
            this.lbl_aluno.Text = "ALUNO:";
            // 
            // lbl_dtMatricula
            // 
            this.lbl_dtMatricula.AutoSize = true;
            this.lbl_dtMatricula.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dtMatricula.Location = new System.Drawing.Point(91, 85);
            this.lbl_dtMatricula.Name = "lbl_dtMatricula";
            this.lbl_dtMatricula.Size = new System.Drawing.Size(103, 21);
            this.lbl_dtMatricula.TabIndex = 74;
            this.lbl_dtMatricula.Text = "DT. MATRÍC.:";
            // 
            // lbl_dtUltimoPagamento
            // 
            this.lbl_dtUltimoPagamento.AutoSize = true;
            this.lbl_dtUltimoPagamento.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dtUltimoPagamento.Location = new System.Drawing.Point(91, 187);
            this.lbl_dtUltimoPagamento.Name = "lbl_dtUltimoPagamento";
            this.lbl_dtUltimoPagamento.Size = new System.Drawing.Size(111, 21);
            this.lbl_dtUltimoPagamento.TabIndex = 75;
            this.lbl_dtUltimoPagamento.Text = "ÚLTIMO PAG.:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(91, 255);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(70, 21);
            this.lbl_status.TabIndex = 76;
            this.lbl_status.Text = "STATUS:";
            // 
            // lbl_plano
            // 
            this.lbl_plano.AutoSize = true;
            this.lbl_plano.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plano.Location = new System.Drawing.Point(91, 119);
            this.lbl_plano.Name = "lbl_plano";
            this.lbl_plano.Size = new System.Drawing.Size(66, 21);
            this.lbl_plano.TabIndex = 77;
            this.lbl_plano.Text = "PLANO:";
            // 
            // lbl_próximoVenc
            // 
            this.lbl_próximoVenc.AutoSize = true;
            this.lbl_próximoVenc.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_próximoVenc.Location = new System.Drawing.Point(91, 222);
            this.lbl_próximoVenc.Name = "lbl_próximoVenc";
            this.lbl_próximoVenc.Size = new System.Drawing.Size(135, 21);
            this.lbl_próximoVenc.TabIndex = 78;
            this.lbl_próximoVenc.Text = "PRÓXIMO VENC.:";
            // 
            // chckbox_pagarProxFatura
            // 
            this.chckbox_pagarProxFatura.AutoSize = true;
            this.chckbox_pagarProxFatura.Location = new System.Drawing.Point(95, 319);
            this.chckbox_pagarProxFatura.Name = "chckbox_pagarProxFatura";
            this.chckbox_pagarProxFatura.Size = new System.Drawing.Size(123, 17);
            this.chckbox_pagarProxFatura.TabIndex = 79;
            this.chckbox_pagarProxFatura.Text = "Pagar próxima fatura";
            this.chckbox_pagarProxFatura.UseVisualStyleBackColor = true;
            this.chckbox_pagarProxFatura.Visible = false;
            // 
            // lbl_dtMatriculaResultado
            // 
            this.lbl_dtMatriculaResultado.AutoSize = true;
            this.lbl_dtMatriculaResultado.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dtMatriculaResultado.Location = new System.Drawing.Point(17, 6);
            this.lbl_dtMatriculaResultado.Name = "lbl_dtMatriculaResultado";
            this.lbl_dtMatriculaResultado.Size = new System.Drawing.Size(103, 21);
            this.lbl_dtMatriculaResultado.TabIndex = 80;
            this.lbl_dtMatriculaResultado.Text = "DT. MATRÍC.:";
            this.lbl_dtMatriculaResultado.Visible = false;
            // 
            // lbl_dtUltimoPagamentoResultado
            // 
            this.lbl_dtUltimoPagamentoResultado.AutoSize = true;
            this.lbl_dtUltimoPagamentoResultado.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dtUltimoPagamentoResultado.Location = new System.Drawing.Point(17, 108);
            this.lbl_dtUltimoPagamentoResultado.Name = "lbl_dtUltimoPagamentoResultado";
            this.lbl_dtUltimoPagamentoResultado.Size = new System.Drawing.Size(111, 21);
            this.lbl_dtUltimoPagamentoResultado.TabIndex = 82;
            this.lbl_dtUltimoPagamentoResultado.Text = "ÚLTIMO PAG.:";
            this.lbl_dtUltimoPagamentoResultado.Visible = false;
            // 
            // lbl_próximoVencResultado
            // 
            this.lbl_próximoVencResultado.AutoSize = true;
            this.lbl_próximoVencResultado.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_próximoVencResultado.Location = new System.Drawing.Point(17, 143);
            this.lbl_próximoVencResultado.Name = "lbl_próximoVencResultado";
            this.lbl_próximoVencResultado.Size = new System.Drawing.Size(135, 21);
            this.lbl_próximoVencResultado.TabIndex = 83;
            this.lbl_próximoVencResultado.Text = "PRÓXIMO VENC.:";
            this.lbl_próximoVencResultado.Visible = false;
            // 
            // lbl_statusResultado
            // 
            this.lbl_statusResultado.AutoSize = true;
            this.lbl_statusResultado.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statusResultado.Location = new System.Drawing.Point(17, 176);
            this.lbl_statusResultado.Name = "lbl_statusResultado";
            this.lbl_statusResultado.Size = new System.Drawing.Size(70, 21);
            this.lbl_statusResultado.TabIndex = 84;
            this.lbl_statusResultado.Text = "STATUS:";
            this.lbl_statusResultado.Visible = false;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(91, 153);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(64, 21);
            this.lbl_valor.TabIndex = 85;
            this.lbl_valor.Text = "VALOR:";
            // 
            // lbl_idResult
            // 
            this.lbl_idResult.AutoSize = true;
            this.lbl_idResult.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idResult.Location = new System.Drawing.Point(455, 34);
            this.lbl_idResult.Name = "lbl_idResult";
            this.lbl_idResult.Size = new System.Drawing.Size(30, 21);
            this.lbl_idResult.TabIndex = 88;
            this.lbl_idResult.Text = "ID:";
            this.lbl_idResult.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(419, 34);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 21);
            this.lbl_id.TabIndex = 87;
            this.lbl_id.Text = "ID:";
            this.lbl_id.Visible = false;
            // 
            // panel_resultado
            // 
            this.panel_resultado.Controls.Add(this.lbl_frequenciaResult);
            this.panel_resultado.Controls.Add(this.msktbox_Valor);
            this.panel_resultado.Controls.Add(this.lbl_dtMatriculaResultado);
            this.panel_resultado.Controls.Add(this.cmbbox_Plano);
            this.panel_resultado.Controls.Add(this.lbl_dtUltimoPagamentoResultado);
            this.panel_resultado.Controls.Add(this.lbl_próximoVencResultado);
            this.panel_resultado.Controls.Add(this.lbl_statusResultado);
            this.panel_resultado.Location = new System.Drawing.Point(222, 79);
            this.panel_resultado.Name = "panel_resultado";
            this.panel_resultado.Size = new System.Drawing.Size(165, 235);
            this.panel_resultado.TabIndex = 89;
            // 
            // lbl_frequenciaResult
            // 
            this.lbl_frequenciaResult.AutoSize = true;
            this.lbl_frequenciaResult.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frequenciaResult.Location = new System.Drawing.Point(17, 206);
            this.lbl_frequenciaResult.Name = "lbl_frequenciaResult";
            this.lbl_frequenciaResult.Size = new System.Drawing.Size(109, 21);
            this.lbl_frequenciaResult.TabIndex = 92;
            this.lbl_frequenciaResult.Text = "FREQUÊNCIA:";
            this.lbl_frequenciaResult.Visible = false;
            // 
            // msktbox_Valor
            // 
            this.msktbox_Valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msktbox_Valor.Location = new System.Drawing.Point(21, 75);
            this.msktbox_Valor.Mask = "999.00";
            this.msktbox_Valor.Name = "msktbox_Valor";
            this.msktbox_Valor.Size = new System.Drawing.Size(121, 20);
            this.msktbox_Valor.TabIndex = 91;
            this.msktbox_Valor.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.msktbox_Valor.ValidatingType = typeof(System.DateTime);
            this.msktbox_Valor.Visible = false;
            // 
            // cmbbox_Plano
            // 
            this.cmbbox_Plano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_Plano.FormattingEnabled = true;
            this.cmbbox_Plano.Items.AddRange(new object[] {
            "MENSAL",
            "TRIMESTRAL",
            "ANUAL"});
            this.cmbbox_Plano.Location = new System.Drawing.Point(21, 43);
            this.cmbbox_Plano.Name = "cmbbox_Plano";
            this.cmbbox_Plano.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_Plano.TabIndex = 90;
            this.cmbbox_Plano.Visible = false;
            this.cmbbox_Plano.SelectedIndexChanged += new System.EventHandler(this.cmbbox_Plano_SelectedIndexChanged);
            // 
            // dataGridView_DadosPagamento
            // 
            this.dataGridView_DadosPagamento.AllowUserToAddRows = false;
            this.dataGridView_DadosPagamento.AllowUserToDeleteRows = false;
            this.dataGridView_DadosPagamento.AllowUserToResizeColumns = false;
            this.dataGridView_DadosPagamento.AllowUserToResizeRows = false;
            this.dataGridView_DadosPagamento.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_DadosPagamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_DadosPagamento.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView_DadosPagamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DadosPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_DadosPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_DadosPagamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_DadosPagamento.EnableHeadersVisualStyles = false;
            this.dataGridView_DadosPagamento.Location = new System.Drawing.Point(393, 79);
            this.dataGridView_DadosPagamento.Name = "dataGridView_DadosPagamento";
            this.dataGridView_DadosPagamento.ReadOnly = true;
            this.dataGridView_DadosPagamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_DadosPagamento.RowHeadersVisible = false;
            this.dataGridView_DadosPagamento.Size = new System.Drawing.Size(380, 227);
            this.dataGridView_DadosPagamento.TabIndex = 90;
            this.dataGridView_DadosPagamento.Visible = false;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_atualizar.Image")));
            this.btn_atualizar.ImageHover = ((System.Drawing.Image)(resources.GetObject("btn_atualizar.ImageHover")));
            this.btn_atualizar.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_atualizar.ImageNormal")));
            this.btn_atualizar.Location = new System.Drawing.Point(79, 395);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(176, 30);
            this.btn_atualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_atualizar.TabIndex = 71;
            this.btn_atualizar.TabStop = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // lbl_frequencia
            // 
            this.lbl_frequencia.AutoSize = true;
            this.lbl_frequencia.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frequencia.Location = new System.Drawing.Point(91, 285);
            this.lbl_frequencia.Name = "lbl_frequencia";
            this.lbl_frequencia.Size = new System.Drawing.Size(109, 21);
            this.lbl_frequencia.TabIndex = 92;
            this.lbl_frequencia.Text = "FREQUÊNCIA:";
            // 
            // chckbox_ativo
            // 
            this.chckbox_ativo.AutoSize = true;
            this.chckbox_ativo.Location = new System.Drawing.Point(95, 342);
            this.chckbox_ativo.Name = "chckbox_ativo";
            this.chckbox_ativo.Size = new System.Drawing.Size(95, 17);
            this.chckbox_ativo.TabIndex = 93;
            this.chckbox_ativo.Text = "FREQUENCIA";
            this.chckbox_ativo.UseVisualStyleBackColor = true;
            this.chckbox_ativo.Visible = false;
            // 
            // btn_frequencia
            // 
            this.btn_frequencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_frequencia.Image = ((System.Drawing.Image)(resources.GetObject("btn_frequencia.Image")));
            this.btn_frequencia.ImageHover = ((System.Drawing.Image)(resources.GetObject("btn_frequencia.ImageHover")));
            this.btn_frequencia.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_frequencia.ImageNormal")));
            this.btn_frequencia.Location = new System.Drawing.Point(261, 395);
            this.btn_frequencia.Name = "btn_frequencia";
            this.btn_frequencia.Size = new System.Drawing.Size(176, 30);
            this.btn_frequencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_frequencia.TabIndex = 94;
            this.btn_frequencia.TabStop = false;
            this.btn_frequencia.Click += new System.EventHandler(this.btn_frequencia_Click);
            // 
            // USC_matriculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_frequencia);
            this.Controls.Add(this.chckbox_ativo);
            this.Controls.Add(this.lbl_frequencia);
            this.Controls.Add(this.dataGridView_DadosPagamento);
            this.Controls.Add(this.lbl_idResult);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.chckbox_pagarProxFatura);
            this.Controls.Add(this.lbl_plano);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_dtUltimoPagamento);
            this.Controls.Add(this.lbl_dtMatricula);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.cmbbox_aluno);
            this.Controls.Add(this.lbl_aluno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_resultado);
            this.Controls.Add(this.lbl_próximoVenc);
            this.Name = "USC_matriculados";
            this.Size = new System.Drawing.Size(798, 455);
            this.Load += new System.EventHandler(this.USC_matriculados_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_novoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_resultado.ResumeLayout(false);
            this.panel_resultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DadosPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_atualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_frequencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictbox_novoAluno;
        private BotãoDinamico.CustomBotãoImage btn_voltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_aluno;
        private BotãoDinamico.CustomBotãoImage btn_atualizar;
        private System.Windows.Forms.Label lbl_dtMatricula;
        private System.Windows.Forms.Label lbl_dtUltimoPagamento;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_plano;
        private System.Windows.Forms.Label lbl_próximoVenc;
        private System.Windows.Forms.CheckBox chckbox_pagarProxFatura;
        private System.Windows.Forms.Label lbl_dtMatriculaResultado;
        private System.Windows.Forms.Label lbl_dtUltimoPagamentoResultado;
        private System.Windows.Forms.Label lbl_próximoVencResultado;
        private System.Windows.Forms.Label lbl_statusResultado;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_idResult;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Panel panel_resultado;
        private System.Windows.Forms.ComboBox cmbbox_Plano;
        private System.Windows.Forms.MaskedTextBox msktbox_Valor;
        private System.Windows.Forms.DataGridView dataGridView_DadosPagamento;
        private System.Windows.Forms.Label lbl_frequenciaResult;
        private System.Windows.Forms.Label lbl_frequencia;
        private System.Windows.Forms.CheckBox chckbox_ativo;
        private BotãoDinamico.CustomBotãoImage btn_frequencia;
        public System.Windows.Forms.ComboBox cmbbox_aluno;
    }
}
