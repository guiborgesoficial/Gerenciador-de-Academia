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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cht_faturamento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbbox_FaturamentoCht = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cht_faturamento)).BeginInit();
            this.SuspendLayout();
            // 
            // cht_faturamento
            // 
            this.cht_faturamento.BorderlineWidth = 5;
            chartArea2.Name = "ChartArea1";
            this.cht_faturamento.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cht_faturamento.Legends.Add(legend2);
            this.cht_faturamento.Location = new System.Drawing.Point(0, 0);
            this.cht_faturamento.Name = "cht_faturamento";
            series6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series6.BackImageTransparentColor = System.Drawing.Color.White;
            series6.BackSecondaryColor = System.Drawing.Color.YellowGreen;
            series6.BorderColor = System.Drawing.Color.Black;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Green;
            series6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.Legend = "Legend1";
            series6.MarkerBorderColor = System.Drawing.Color.Black;
            series6.MarkerColor = System.Drawing.Color.Black;
            series6.MarkerSize = 7;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "Faturamento";
            series6.ShadowColor = System.Drawing.Color.Silver;
            series6.ShadowOffset = 5;
            series6.YValuesPerPoint = 2;
            series7.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series7.BackSecondaryColor = System.Drawing.Color.LightSeaGreen;
            series7.BorderColor = System.Drawing.Color.Black;
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.MediumTurquoise;
            series7.Legend = "Legend1";
            series7.Name = "Faturamento Hoje";
            series8.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series8.BackSecondaryColor = System.Drawing.Color.Indigo;
            series8.BorderColor = System.Drawing.Color.Black;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Ticket Médio";
            series8.ShadowColor = System.Drawing.Color.Silver;
            series8.ShadowOffset = 5;
            series8.YValuesPerPoint = 2;
            series9.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series9.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series9.BackSecondaryColor = System.Drawing.Color.Yellow;
            series9.BorderColor = System.Drawing.Color.Black;
            series9.ChartArea = "ChartArea1";
            series9.Color = System.Drawing.Color.DarkOrange;
            series9.Legend = "Legend1";
            series9.Name = "Contas a Receber";
            series9.YValuesPerPoint = 2;
            series10.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series10.BackSecondaryColor = System.Drawing.Color.Firebrick;
            series10.BorderColor = System.Drawing.Color.Black;
            series10.ChartArea = "ChartArea1";
            series10.Color = System.Drawing.Color.Crimson;
            series10.Legend = "Legend1";
            series10.Name = "Vencimentos Hoje";
            this.cht_faturamento.Series.Add(series6);
            this.cht_faturamento.Series.Add(series7);
            this.cht_faturamento.Series.Add(series8);
            this.cht_faturamento.Series.Add(series9);
            this.cht_faturamento.Series.Add(series10);
            this.cht_faturamento.Size = new System.Drawing.Size(453, 268);
            this.cht_faturamento.TabIndex = 0;
            this.cht_faturamento.Text = "cht_faturamento";
            this.cht_faturamento.UseWaitCursor = true;
            // 
            // cmbbox_FaturamentoCht
            // 
            this.cmbbox_FaturamentoCht.FormattingEnabled = true;
            this.cmbbox_FaturamentoCht.Items.AddRange(new object[] {
            "TOTAL",
            "ANUAL",
            "SEMESTRAL",
            "TRIMESTRAL",
            "MENSAL",
            "SEMANAL"});
            this.cmbbox_FaturamentoCht.Location = new System.Drawing.Point(307, 87);
            this.cmbbox_FaturamentoCht.Name = "cmbbox_FaturamentoCht";
            this.cmbbox_FaturamentoCht.Size = new System.Drawing.Size(116, 21);
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
