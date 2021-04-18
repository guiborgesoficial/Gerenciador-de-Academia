using Business.SqlComandos.Consultar;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RCFitness.UserControls.Charts
{
    public partial class USC_chtFaturamento : UserControl
    {
        public USC_chtFaturamento()
        {
            InitializeComponent();
        }

        private void USC_chtFaturamento_Load(object sender, EventArgs e)
        {
            cmbbox_FaturamentoCht.SelectedIndex = 0;
            AtualizarChartFaturamento();
        }
        CS_ChtFaturamento dadosFaturamento = new CS_ChtFaturamento();

        public void AtualizarChartFaturamento()
        {
            try
            {
                cht_faturamento.ResetAutoValues();
                dadosFaturamento.ConsultandoTicketMedio();
                dadosFaturamento.ConsultandoContasParaReceber();
                dadosFaturamento.ConsultandoValoresVencimentoHoje();
                dadosFaturamento.ConsultandoFaturamentoHoje();
                PersonalizarChtFaturamento();
                
              
                cht_faturamento.Series["Faturamento"].Points.AddXY("Dados Financeiros (em Reais)", dadosFaturamento.faturamento);
                cht_faturamento.Series["Ticket Médio"].Points.AddY(dadosFaturamento.ticketMédio);
                cht_faturamento.Series["Contas a Receber"].Points.AddY(dadosFaturamento.ContasParaReceber);
                cht_faturamento.Series["Vencimentos Hoje"].Points.AddY(dadosFaturamento.ValoresVencimentoHoje);
                cht_faturamento.Series["Faturamento Hoje"].Points.AddY(dadosFaturamento.FaturamentoHoje);

                if (dadosFaturamento.faturamento == 0 && dadosFaturamento.ticketMédio == 0 && dadosFaturamento.ContasParaReceber == 0 && dadosFaturamento.ValoresVencimentoHoje == 0 && dadosFaturamento.FaturamentoHoje == 0)
                    this.Visible = false;
                else
                    this.Visible = true;
                
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao atualizar gráfico UserInterface/UserControls/Charts/USC_chtFaturamento - AtualizarChartFaturamento()" + erro, "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PersonalizarChtFaturamento()
        {
            cht_faturamento.Series.Clear();
            cht_faturamento.Series.Add("Faturamento");
            cht_faturamento.Series["Faturamento"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            cht_faturamento.Series["Faturamento"].IsValueShownAsLabel = true;
            cht_faturamento.Series["Faturamento"].Color = Color.Green;
            cht_faturamento.Series["Faturamento"].BackSecondaryColor = Color.YellowGreen;
            cht_faturamento.Series["Faturamento"].BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            cht_faturamento.Series["Faturamento"].BorderColor = Color.Black;
            cht_faturamento.Series["Faturamento"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            cht_faturamento.Series["Faturamento"].BorderWidth = 1;
            cht_faturamento.Series["Faturamento"].ShadowColor = Color.Silver;
            cht_faturamento.Series["Faturamento"].ShadowOffset = 5;
            cht_faturamento.Series["Faturamento"].LabelBorderColor = Color.Black;
            cht_faturamento.Series["Faturamento"].LabelBackColor = Color.GreenYellow;

            cht_faturamento.Series.Add("Faturamento Hoje");
            cht_faturamento.Series["Faturamento Hoje"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            cht_faturamento.Series["Faturamento Hoje"].IsValueShownAsLabel = true;
            cht_faturamento.Series["Faturamento Hoje"].Color = Color.Turquoise;
            cht_faturamento.Series["Faturamento Hoje"].BackSecondaryColor = Color.LightSeaGreen;
            cht_faturamento.Series["Faturamento Hoje"].BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            cht_faturamento.Series["Faturamento Hoje"].BorderColor = Color.Black;
            cht_faturamento.Series["Faturamento Hoje"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            cht_faturamento.Series["Faturamento Hoje"].BorderWidth = 1;
            cht_faturamento.Series["Faturamento Hoje"].ShadowColor = Color.Silver;
            cht_faturamento.Series["Faturamento Hoje"].ShadowOffset = 5;
            cht_faturamento.Series["Faturamento Hoje"].LabelBorderColor = Color.Black;
            cht_faturamento.Series["Faturamento Hoje"].LabelBackColor = Color.MediumTurquoise;

            cht_faturamento.Series.Add("Ticket Médio");
            cht_faturamento.Series["Ticket Médio"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            cht_faturamento.Series["Ticket Médio"].IsValueShownAsLabel = true;
            cht_faturamento.Series["Ticket Médio"].Color = Color.Blue;
            cht_faturamento.Series["Ticket Médio"].BackSecondaryColor = Color.Indigo;
            cht_faturamento.Series["Ticket Médio"].BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            cht_faturamento.Series["Ticket Médio"].BorderColor = Color.Black;
            cht_faturamento.Series["Ticket Médio"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            cht_faturamento.Series["Ticket Médio"].BorderWidth = 1;
            cht_faturamento.Series["Ticket Médio"].ShadowColor = Color.Silver;
            cht_faturamento.Series["Ticket Médio"].ShadowOffset = 5;
            cht_faturamento.Series["Ticket Médio"].LabelBorderColor = Color.Black;
            cht_faturamento.Series["Ticket Médio"].LabelBackColor = Color.DeepSkyBlue;

            cht_faturamento.Series.Add("Contas a Receber");
            cht_faturamento.Series["Contas a Receber"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            cht_faturamento.Series["Contas a Receber"].IsValueShownAsLabel = true;
            cht_faturamento.Series["Contas a Receber"].Color = Color.DarkOrange;
            cht_faturamento.Series["Contas a Receber"].BackSecondaryColor = Color.Yellow;
            cht_faturamento.Series["Contas a Receber"].BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            cht_faturamento.Series["Contas a Receber"].BorderColor = Color.Black;
            cht_faturamento.Series["Contas a Receber"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            cht_faturamento.Series["Contas a Receber"].BorderWidth = 1;
            cht_faturamento.Series["Contas a Receber"].ShadowColor = Color.Silver;
            cht_faturamento.Series["Contas a Receber"].ShadowOffset = 5;
            cht_faturamento.Series["Contas a Receber"].LabelBorderColor = Color.Black;
            cht_faturamento.Series["Contas a Receber"].LabelBackColor = Color.Yellow;

            cht_faturamento.Series.Add("Vencimentos Hoje");
            cht_faturamento.Series["Vencimentos Hoje"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            cht_faturamento.Series["Vencimentos Hoje"].IsValueShownAsLabel = true;
            cht_faturamento.Series["Vencimentos Hoje"].Color = Color.Crimson;
            cht_faturamento.Series["Vencimentos Hoje"].BackSecondaryColor = Color.Firebrick;
            cht_faturamento.Series["Vencimentos Hoje"].BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            cht_faturamento.Series["Vencimentos Hoje"].BorderColor = Color.Black;
            cht_faturamento.Series["Vencimentos Hoje"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            cht_faturamento.Series["Vencimentos Hoje"].BorderWidth = 1;
            cht_faturamento.Series["Vencimentos Hoje"].ShadowColor = Color.Silver;
            cht_faturamento.Series["Vencimentos Hoje"].ShadowOffset = 5;
            cht_faturamento.Series["Vencimentos Hoje"].LabelBorderColor = Color.Black;
            cht_faturamento.Series["Vencimentos Hoje"].LabelBackColor = Color.OrangeRed;
        }
        private void cmbbox_FaturamentoCht_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificandoIntervalo(dadosFaturamento);
        }
        private void verificandoIntervalo(CS_ChtFaturamento ConsultandoIntervaloFaturamento)
        {
            DateTime intervalo = DateTime.Now;
            try
            {
                switch (cmbbox_FaturamentoCht.Text)
                {
                    case "TOTAL":
                        ConsultandoIntervaloFaturamento.ConsultandoFaturamentoCht("SELECT SUM(CAST(REPLACE(SUBSTRING(VALOR, 3, 7), ',' ,'.')AS decimal(18,2))) AS Faturamento FROM Pagamento WHERE DT_PAG IS NOT NULL");
                        AtualizarChartFaturamento();
                        break;
                    case "ANUAL":
                        ConsultandoIntervaloFaturamento.ConsultandoFaturamentoCht("SELECT SUM(CAST(REPLACE(SUBSTRING(VALOR, 3, 7), ',' ,'.')AS decimal(18,2))) AS Faturamento FROM Pagamento WHERE DT_PAG IS NOT NULL AND DT_PAG BETWEEN '" + intervalo.AddYears(-1).ToShortDateString() + "' AND  '" + DateTime.Now.ToShortDateString() + "'");
                        AtualizarChartFaturamento();
                        break;
                    case "SEMESTRAL":
                        ConsultandoIntervaloFaturamento.ConsultandoFaturamentoCht("SELECT SUM(CAST(REPLACE(SUBSTRING(VALOR, 3, 7), ',' ,'.')AS decimal(18,2))) AS Faturamento FROM Pagamento WHERE DT_PAG IS NOT NULL AND DT_PAG BETWEEN '" + intervalo.AddMonths(-6).ToShortDateString() + "' AND  '" + DateTime.Now.ToShortDateString() + "'");
                        AtualizarChartFaturamento();
                        break;
                    case "TRIMESTRAL":
                        ConsultandoIntervaloFaturamento.ConsultandoFaturamentoCht("SELECT SUM(CAST(REPLACE(SUBSTRING(VALOR, 3, 7), ',' ,'.')AS decimal(18,2))) AS Faturamento FROM Pagamento WHERE DT_PAG IS NOT NULL AND DT_PAG BETWEEN '" + intervalo.AddMonths(-3).ToShortDateString() + "' AND  '" + DateTime.Now.ToShortDateString() + "'");
                        AtualizarChartFaturamento();
                        break;
                    case "MENSAL":
                        ConsultandoIntervaloFaturamento.ConsultandoFaturamentoCht("SELECT SUM(CAST(REPLACE(SUBSTRING(VALOR, 3, 7), ',' ,'.')AS decimal(18,2))) AS Faturamento FROM Pagamento WHERE DT_PAG IS NOT NULL AND DT_PAG BETWEEN '" + intervalo.AddMonths(-1).ToShortDateString() + "' AND  '" + DateTime.Now.ToShortDateString() + "'");
                        AtualizarChartFaturamento();
                        break;
                    case "SEMANAL":
                        ConsultandoIntervaloFaturamento.ConsultandoFaturamentoCht("SELECT SUM(CAST(REPLACE(SUBSTRING(VALOR, 3, 7), ',' ,'.')AS decimal(18,2))) AS Faturamento FROM Pagamento WHERE DT_PAG IS NOT NULL AND DT_PAG BETWEEN '" + intervalo.AddDays(-7).ToShortDateString() + "' AND  '" + DateTime.Now.ToShortDateString() + "'");
                        AtualizarChartFaturamento();
                        break;
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao Consultar intervalo - UserInterface/UserControls/USC_chtFaturamento - verificandoIntervalo()" + erro);
            }
        }
    }
}
