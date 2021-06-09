namespace RCFitness.UserControls.Charts
{
    partial class USC_chtAlunos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_qtdMatriculados = new System.Windows.Forms.Label();
            this.cht_Adimplentes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cht_AlunosMatriculados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cht_Inadimplentes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cht_VencimentosHoje = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_qtdInadimplentes = new System.Windows.Forms.Label();
            this.lbl_qtdAdimplentes = new System.Windows.Forms.Label();
            this.lbl_qtdVencimentoHJ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Adimplentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_AlunosMatriculados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Inadimplentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_VencimentosHoje)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_qtdMatriculados
            // 
            this.lbl_qtdMatriculados.AutoSize = true;
            this.lbl_qtdMatriculados.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qtdMatriculados.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdMatriculados.Location = new System.Drawing.Point(262, 0);
            this.lbl_qtdMatriculados.Name = "lbl_qtdMatriculados";
            this.lbl_qtdMatriculados.Size = new System.Drawing.Size(75, 17);
            this.lbl_qtdMatriculados.TabIndex = 18;
            this.lbl_qtdMatriculados.Text = "AlunoCadR";
            // 
            // cht_Adimplentes
            // 
            chartArea1.Name = "ChartArea1";
            this.cht_Adimplentes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cht_Adimplentes.Legends.Add(legend1);
            this.cht_Adimplentes.Location = new System.Drawing.Point(172, 135);
            this.cht_Adimplentes.Name = "cht_Adimplentes";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cht_Adimplentes.Series.Add(series1);
            this.cht_Adimplentes.Size = new System.Drawing.Size(179, 119);
            this.cht_Adimplentes.TabIndex = 25;
            // 
            // cht_AlunosMatriculados
            // 
            chartArea2.Name = "ChartArea1";
            this.cht_AlunosMatriculados.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cht_AlunosMatriculados.Legends.Add(legend2);
            this.cht_AlunosMatriculados.Location = new System.Drawing.Point(172, 16);
            this.cht_AlunosMatriculados.Name = "cht_AlunosMatriculados";
            series2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series2.BackSecondaryColor = System.Drawing.Color.WhiteSmoke;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.ShadowColor = System.Drawing.Color.Silver;
            series2.ShadowOffset = 5;
            this.cht_AlunosMatriculados.Series.Add(series2);
            this.cht_AlunosMatriculados.Size = new System.Drawing.Size(179, 117);
            this.cht_AlunosMatriculados.TabIndex = 26;
            // 
            // cht_Inadimplentes
            // 
            chartArea3.Name = "ChartArea1";
            this.cht_Inadimplentes.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cht_Inadimplentes.Legends.Add(legend3);
            this.cht_Inadimplentes.Location = new System.Drawing.Point(0, 16);
            this.cht_Inadimplentes.Name = "cht_Inadimplentes";
            this.cht_Inadimplentes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.cht_Inadimplentes.Series.Add(series3);
            this.cht_Inadimplentes.Size = new System.Drawing.Size(179, 117);
            this.cht_Inadimplentes.TabIndex = 27;
            // 
            // cht_VencimentosHoje
            // 
            chartArea4.Name = "ChartArea1";
            this.cht_VencimentosHoje.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.cht_VencimentosHoje.Legends.Add(legend4);
            this.cht_VencimentosHoje.Location = new System.Drawing.Point(0, 137);
            this.cht_VencimentosHoje.Name = "cht_VencimentosHoje";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.cht_VencimentosHoje.Series.Add(series4);
            this.cht_VencimentosHoje.Size = new System.Drawing.Size(179, 117);
            this.cht_VencimentosHoje.TabIndex = 28;
            // 
            // lbl_qtdInadimplentes
            // 
            this.lbl_qtdInadimplentes.AutoSize = true;
            this.lbl_qtdInadimplentes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qtdInadimplentes.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdInadimplentes.Location = new System.Drawing.Point(81, 0);
            this.lbl_qtdInadimplentes.Name = "lbl_qtdInadimplentes";
            this.lbl_qtdInadimplentes.Size = new System.Drawing.Size(71, 17);
            this.lbl_qtdInadimplentes.TabIndex = 29;
            this.lbl_qtdInadimplentes.Text = "qtdInadim";
            // 
            // lbl_qtdAdimplentes
            // 
            this.lbl_qtdAdimplentes.AutoSize = true;
            this.lbl_qtdAdimplentes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qtdAdimplentes.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdAdimplentes.Location = new System.Drawing.Point(262, 119);
            this.lbl_qtdAdimplentes.Name = "lbl_qtdAdimplentes";
            this.lbl_qtdAdimplentes.Size = new System.Drawing.Size(61, 17);
            this.lbl_qtdAdimplentes.TabIndex = 30;
            this.lbl_qtdAdimplentes.Text = "qtdAdim";
            // 
            // lbl_qtdVencimentoHJ
            // 
            this.lbl_qtdVencimentoHJ.AutoSize = true;
            this.lbl_qtdVencimentoHJ.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qtdVencimentoHJ.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdVencimentoHJ.Location = new System.Drawing.Point(81, 119);
            this.lbl_qtdVencimentoHJ.Name = "lbl_qtdVencimentoHJ";
            this.lbl_qtdVencimentoHJ.Size = new System.Drawing.Size(72, 17);
            this.lbl_qtdVencimentoHJ.TabIndex = 31;
            this.lbl_qtdVencimentoHJ.Text = "qtdVencHJ";
            // 
            // USC_chtAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_qtdVencimentoHJ);
            this.Controls.Add(this.lbl_qtdAdimplentes);
            this.Controls.Add(this.lbl_qtdInadimplentes);
            this.Controls.Add(this.cht_Inadimplentes);
            this.Controls.Add(this.cht_Adimplentes);
            this.Controls.Add(this.lbl_qtdMatriculados);
            this.Controls.Add(this.cht_VencimentosHoje);
            this.Controls.Add(this.cht_AlunosMatriculados);
            this.Name = "USC_chtAlunos";
            this.Size = new System.Drawing.Size(337, 256);
            this.Load += new System.EventHandler(this.USC_chtSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cht_Adimplentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_AlunosMatriculados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Inadimplentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_VencimentosHoje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_qtdMatriculados;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Adimplentes;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_AlunosMatriculados;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Inadimplentes;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_VencimentosHoje;
        private System.Windows.Forms.Label lbl_qtdInadimplentes;
        private System.Windows.Forms.Label lbl_qtdAdimplentes;
        private System.Windows.Forms.Label lbl_qtdVencimentoHJ;
    }
}
