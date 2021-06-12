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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea1.Name = "ChartArea1";
            this.cht_faturamento.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cht_faturamento.Legends.Add(legend1);
            this.cht_faturamento.Location = new System.Drawing.Point(0, 0);
            this.cht_faturamento.Name = "cht_faturamento";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.BackImageTransparentColor = System.Drawing.Color.White;
            series1.BackSecondaryColor = System.Drawing.Color.YellowGreen;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Green;
            series1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Faturamento";
            series1.ShadowColor = System.Drawing.Color.Silver;
            series1.ShadowOffset = 5;
            series1.YValuesPerPoint = 2;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series2.BackSecondaryColor = System.Drawing.Color.LightSeaGreen;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.MediumTurquoise;
            series2.Legend = "Legend1";
            series2.Name = "Faturamento Hoje";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series3.BackSecondaryColor = System.Drawing.Color.Indigo;
            series3.BorderColor = System.Drawing.Color.Black;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Ticket Médio";
            series3.ShadowColor = System.Drawing.Color.Silver;
            series3.ShadowOffset = 5;
            series3.YValuesPerPoint = 2;
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series4.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series4.BackSecondaryColor = System.Drawing.Color.Yellow;
            series4.BorderColor = System.Drawing.Color.Black;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.DarkOrange;
            series4.Legend = "Legend1";
            series4.Name = "Contas a Receber";
            series4.YValuesPerPoint = 2;
            series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series5.BackSecondaryColor = System.Drawing.Color.Firebrick;
            series5.BorderColor = System.Drawing.Color.Black;
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Crimson;
            series5.Legend = "Legend1";
            series5.Name = "Vencimentos Hoje";
            this.cht_faturamento.Series.Add(series1);
            this.cht_faturamento.Series.Add(series2);
            this.cht_faturamento.Series.Add(series3);
            this.cht_faturamento.Series.Add(series4);
            this.cht_faturamento.Series.Add(series5);
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
