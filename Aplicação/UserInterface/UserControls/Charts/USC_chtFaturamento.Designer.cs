namespace RCFitness.UserControls.Charts
{
    partial class USC_chtFaturamento
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cht_faturamento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbbox_FaturamentoCht = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cht_faturamento)).BeginInit();
            this.SuspendLayout();
            // 
            // cht_faturamento
            // 
            this.cht_faturamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cht_faturamento.BorderlineWidth = 5;
            chartArea3.Name = "ChartArea1";
            this.cht_faturamento.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cht_faturamento.Legends.Add(legend3);
            this.cht_faturamento.Location = new System.Drawing.Point(0, 0);
            this.cht_faturamento.Name = "cht_faturamento";
            series11.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series11.BackImageTransparentColor = System.Drawing.Color.White;
            series11.BackSecondaryColor = System.Drawing.Color.YellowGreen;
            series11.BorderColor = System.Drawing.Color.Black;
            series11.ChartArea = "ChartArea1";
            series11.Color = System.Drawing.Color.Green;
            series11.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series11.Legend = "Legend1";
            series11.MarkerBorderColor = System.Drawing.Color.Black;
            series11.MarkerColor = System.Drawing.Color.Black;
            series11.MarkerSize = 7;
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series11.Name = "Faturamento";
            series11.ShadowColor = System.Drawing.Color.Silver;
            series11.ShadowOffset = 5;
            series11.YValuesPerPoint = 2;
            series12.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series12.BackSecondaryColor = System.Drawing.Color.LightSeaGreen;
            series12.BorderColor = System.Drawing.Color.Black;
            series12.ChartArea = "ChartArea1";
            series12.Color = System.Drawing.Color.MediumTurquoise;
            series12.Legend = "Legend1";
            series12.Name = "Faturamento Hoje";
            series13.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series13.BackSecondaryColor = System.Drawing.Color.Indigo;
            series13.BorderColor = System.Drawing.Color.Black;
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Ticket Médio";
            series13.ShadowColor = System.Drawing.Color.Silver;
            series13.ShadowOffset = 5;
            series13.YValuesPerPoint = 2;
            series14.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series14.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series14.BackSecondaryColor = System.Drawing.Color.Yellow;
            series14.BorderColor = System.Drawing.Color.Black;
            series14.ChartArea = "ChartArea1";
            series14.Color = System.Drawing.Color.DarkOrange;
            series14.Legend = "Legend1";
            series14.Name = "Contas a Receber";
            series14.YValuesPerPoint = 2;
            series15.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series15.BackSecondaryColor = System.Drawing.Color.Firebrick;
            series15.BorderColor = System.Drawing.Color.Black;
            series15.ChartArea = "ChartArea1";
            series15.Color = System.Drawing.Color.Crimson;
            series15.Legend = "Legend1";
            series15.Name = "Vencimentos Hoje";
            this.cht_faturamento.Series.Add(series11);
            this.cht_faturamento.Series.Add(series12);
            this.cht_faturamento.Series.Add(series13);
            this.cht_faturamento.Series.Add(series14);
            this.cht_faturamento.Series.Add(series15);
            this.cht_faturamento.Size = new System.Drawing.Size(437, 268);
            this.cht_faturamento.TabIndex = 0;
            this.cht_faturamento.Text = "cht_faturamento";
            this.cht_faturamento.UseWaitCursor = true;
            // 
            // cmbbox_FaturamentoCht
            // 
            this.cmbbox_FaturamentoCht.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbbox_FaturamentoCht.FormattingEnabled = true;
            this.cmbbox_FaturamentoCht.Items.AddRange(new object[] {
            "TOTAL",
            "ANUAL",
            "SEMESTRAL",
            "TRIMESTRAL",
            "MENSAL",
            "SEMANAL"});
            this.cmbbox_FaturamentoCht.Location = new System.Drawing.Point(291, 93);
            this.cmbbox_FaturamentoCht.Name = "cmbbox_FaturamentoCht";
            this.cmbbox_FaturamentoCht.Size = new System.Drawing.Size(118, 21);
            this.cmbbox_FaturamentoCht.TabIndex = 1;
            this.cmbbox_FaturamentoCht.SelectedIndexChanged += new System.EventHandler(this.cmbbox_FaturamentoCht_SelectedIndexChanged);
            // 
            // USC_chtFaturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbbox_FaturamentoCht);
            this.Controls.Add(this.cht_faturamento);
            this.Name = "USC_chtFaturamento";
            this.Size = new System.Drawing.Size(437, 271);
            this.Load += new System.EventHandler(this.USC_chtFaturamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cht_faturamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cht_faturamento;
        internal System.Windows.Forms.ComboBox cmbbox_FaturamentoCht;
    }
}
