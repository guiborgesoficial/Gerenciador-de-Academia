using System;
using Business;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.SqlComandos.Consultar;
using Business.SqlComandos.Consultar.Charts;

namespace RCFitness.UserControls.Charts
{
    public partial class USC_chtAlunos : UserControl
    {
        public USC_chtAlunos()
        {
            InitializeComponent();
        }

        private void USC_chtSistema_Load(object sender, EventArgs e)
        {
            PersonalizarChtAlunos();
            AtualizarChartAlunosMatriculados();
            AtualizarChartAlunosInadimplentes();
            AtualizarChartAlunosAdimplentes();
            AtualizarChartVencimentosHoje();
        }
        public void AtualizarTodosGraficosAluno()
        {
            PersonalizarChtAlunos();
            AtualizarChartAlunosMatriculados();
            AtualizarChartAlunosInadimplentes();
            AtualizarChartAlunosAdimplentes();
            AtualizarChartVencimentosHoje();
        }

        private void AtualizarChartAlunosMatriculados()
        {
            try
            {
                CS_ChtAlunosMatriculados dadosMatriculados = new CS_ChtAlunosMatriculados();
                dadosMatriculados.ConsultandoAlunosMatriculadosChtMasculinos();
                dadosMatriculados.ConsultandoAlunosMatriculadosChtFemininos();
                dadosMatriculados.ConsultandoAlunosMatriculadosChtOutros();

                int qtdMatriculados = (int.Parse(dadosMatriculados.QuantidadeMatriculadosFemininos) + int.Parse(dadosMatriculados.QuantidadeMatriculadosMasculinos) + int.Parse(dadosMatriculados.QuantidadeMatriculadosOutros));
                lbl_qtdMatriculados.Text = qtdMatriculados.ToString();

                if(qtdMatriculados != 0)
                {
                    cht_AlunosMatriculados.Visible = true;

                    if (!(dadosMatriculados.QuantidadeMatriculadosMasculinos.ToString().Contains("null")))
                        cht_AlunosMatriculados.Series["Alunos Matriculados"].Points.AddXY("Homens", dadosMatriculados.QuantidadeMatriculadosMasculinos.ToString());
                    if (!(dadosMatriculados.QuantidadeMatriculadosFemininos.ToString().Contains("null")))
                        cht_AlunosMatriculados.Series["Alunos Matriculados"].Points.AddXY("Mulheres", dadosMatriculados.QuantidadeMatriculadosFemininos.ToString());
                    if (!(dadosMatriculados.QuantidadeMatriculadosOutros.ToString().Contains("null")))
                        cht_AlunosMatriculados.Series["Alunos Matriculados"].Points.AddXY("Outros", dadosMatriculados.QuantidadeMatriculadosOutros.ToString());
                }
                else
                {
                    cht_AlunosMatriculados.Visible = false;
                    lbl_qtdMatriculados.Visible = false;
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao atualizar gráfico - UserInterface/UserControls/Charts/USC_chtAlunos - AtualizarChartAlunosMatriculados()" + erro, "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtualizarChartAlunosInadimplentes()
        {
            try
            {
                CS_ChtInadimplentes dadosInadimplentes = new CS_ChtInadimplentes();
                dadosInadimplentes.ConsultandoChtInadimplentesMasculino();
                dadosInadimplentes.ConsultandoChtInadimplentesFeminino();
                dadosInadimplentes.ConsultandoChtInadimplentesOutros();

                int qtdInadimplentes = (int.Parse(dadosInadimplentes.QuantidadeInadimplentesFemininos) + int.Parse(dadosInadimplentes.QuantidadeInadimplentesMasculinos) + int.Parse(dadosInadimplentes.QuantidadeInadimplentesOutros));
                lbl_qtdInadimplentes.Text = qtdInadimplentes.ToString();

                if (qtdInadimplentes != 0)
                {
                    cht_Inadimplentes.Visible = true;

                    if (!(dadosInadimplentes.QuantidadeInadimplentesMasculinos.ToString().Contains("null")))
                        cht_Inadimplentes.Series["Inadimplentes"].Points.AddXY("Homens", dadosInadimplentes.QuantidadeInadimplentesMasculinos.ToString());
                    if (!(dadosInadimplentes.QuantidadeInadimplentesFemininos.ToString().Contains("null")))
                        cht_Inadimplentes.Series["Inadimplentes"].Points.AddXY("Mulheres", dadosInadimplentes.QuantidadeInadimplentesFemininos.ToString());
                    if (!(dadosInadimplentes.QuantidadeInadimplentesOutros.ToString().Contains("null")))
                        cht_Inadimplentes.Series["Inadimplentes"].Points.AddXY("Outros", dadosInadimplentes.QuantidadeInadimplentesOutros.ToString());
                }
                else
                {
                    cht_Inadimplentes.Visible = false;
                    lbl_qtdInadimplentes.Visible = false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar gráfico - UserInterface/UserControls/Charts/USC_chtAlunos - AtualizarChartInadimplentes()" + erro, "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtualizarChartAlunosAdimplentes()
        {
            try
            {
                CS_ChtAdimplentes dadosAdimplentes = new CS_ChtAdimplentes();

                dadosAdimplentes.ConsultandoChtAdimplentesMasculinos();
                dadosAdimplentes.ConsultandoChtAdimplentesFemininos();
                dadosAdimplentes.ConsultandoChtAdimplenteOutros();

                int qtdAdimplentes = (int.Parse(dadosAdimplentes.QuantidadeAdimplentesMasculinos) + int.Parse(dadosAdimplentes.QuantidadeAdimplentesFemininos) + int.Parse(dadosAdimplentes.QuantidadeAdimplentesOutros));
                lbl_qtdAdimplentes.Text = qtdAdimplentes.ToString();

                if (qtdAdimplentes != 0)
                {
                    cht_Adimplentes.Visible = true;

                    if (!(dadosAdimplentes.QuantidadeAdimplentesMasculinos.ToString().Contains("null")))
                        cht_Adimplentes.Series["Adimplentes"].Points.AddXY("Homens", dadosAdimplentes.QuantidadeAdimplentesMasculinos.ToString());
                    if (!(dadosAdimplentes.QuantidadeAdimplentesFemininos.ToString().Contains("null")))
                        cht_Adimplentes.Series["Adimplentes"].Points.AddXY("Mulheres", dadosAdimplentes.QuantidadeAdimplentesFemininos.ToString());
                    if (!(dadosAdimplentes.QuantidadeAdimplentesOutros.ToString().Contains("null")))
                        cht_Adimplentes.Series["Adimplentes"].Points.AddXY("Outros", dadosAdimplentes.QuantidadeAdimplentesOutros.ToString());
                }
                else
                {
                    cht_Adimplentes.Visible = false;
                    lbl_qtdAdimplentes.Visible = false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar gráfico - UserInterface/UserControls/Charts/USC_chtAlunos - AtualizarChartAdimplentes()" + erro, "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtualizarChartVencimentosHoje()
        {
            try
            {
                CS_ChtVencimentoHoje dadosVencimentosHoje = new CS_ChtVencimentoHoje();
                dadosVencimentosHoje.ConsultandoChtVencimentoMasculino();
                dadosVencimentosHoje.ConsultandoChtVencimentoFeminino();
                dadosVencimentosHoje.ConsultandoChtVencimentoOutros();

                int qtdVencimentosHJ = (int.Parse(dadosVencimentosHoje.QuantidadeVencimentoMasculino) + int.Parse(dadosVencimentosHoje.QuantidadeVencimentoFeminino) + int.Parse(dadosVencimentosHoje.QuantidadeVencimentoOutros));
                lbl_qtdVencimentoHJ.Text = qtdVencimentosHJ.ToString();

                if (qtdVencimentosHJ != 0)
                {
                    cht_VencimentosHoje.Visible = true;

                    if (!(dadosVencimentosHoje.QuantidadeVencimentoMasculino.ToString().Contains("null")))
                        cht_VencimentosHoje.Series["Vencimentos Hoje"].Points.AddXY("Homens", dadosVencimentosHoje.QuantidadeVencimentoMasculino.ToString());
                    if (!(dadosVencimentosHoje.QuantidadeVencimentoFeminino.ToString().Contains("null")))
                        cht_VencimentosHoje.Series["Vencimentos Hoje"].Points.AddXY("Mulheres", dadosVencimentosHoje.QuantidadeVencimentoFeminino.ToString());              
                    if (!(dadosVencimentosHoje.QuantidadeVencimentoOutros.ToString().Contains("null")))
                        cht_VencimentosHoje.Series["Vencimentos Hoje"].Points.AddXY("Outros", dadosVencimentosHoje.QuantidadeVencimentoOutros.ToString());
              
                }
                else
                {
                    cht_VencimentosHoje.Visible = false;
                    lbl_qtdVencimentoHJ.Visible = false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar gráfico - UserInterface/UserControls/Charts/USC_chtAlunos - AtualizarChartVencimentosHoje()" + erro, "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PersonalizarChtAlunos()
        {
            cht_Adimplentes.Series.Clear();
            cht_Adimplentes.Titles.Clear();
            cht_Adimplentes.Series.Add("Adimplentes");
            cht_Adimplentes.Titles.Add("Adimplentes");
            cht_Adimplentes.Series["Adimplentes"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            cht_Adimplentes.Series["Adimplentes"].IsValueShownAsLabel = true;
            cht_Adimplentes.Series["Adimplentes"].BorderColor = Color.Black;
            cht_Adimplentes.Series["Adimplentes"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            cht_Adimplentes.Series["Adimplentes"].BorderWidth = 1;
            cht_Adimplentes.Series["Adimplentes"].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            cht_Adimplentes.Series["Adimplentes"].ShadowColor = Color.Silver;
            cht_Adimplentes.Series["Adimplentes"].ShadowOffset = 3;
            cht_Adimplentes.Series["Adimplentes"].BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            cht_Adimplentes.Series["Adimplentes"].BackSecondaryColor = Color.WhiteSmoke;
            cht_Adimplentes.Series["Adimplentes"].IsValueShownAsLabel = true;

            cht_Inadimplentes.Series.Clear();
            cht_Inadimplentes.Titles.Clear();
            cht_Inadimplentes.Series.Add("Inadimplentes");
            cht_Inadimplentes.Titles.Add("Inadimplentes");
            cht_Inadimplentes.Series["Inadimplentes"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            cht_Inadimplentes.Series["Inadimplentes"].IsValueShownAsLabel = true;
            cht_Inadimplentes.Series["Inadimplentes"].BorderColor = Color.Black;
            cht_Inadimplentes.Series["Inadimplentes"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            cht_Inadimplentes.Series["Inadimplentes"].BorderWidth = 1;
            cht_Inadimplentes.Series["Inadimplentes"].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            cht_Inadimplentes.Series["Inadimplentes"].ShadowColor = Color.Silver;
            cht_Inadimplentes.Series["Inadimplentes"].ShadowOffset = 3;
            cht_Inadimplentes.Series["Inadimplentes"].BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            cht_Inadimplentes.Series["Inadimplentes"].BackSecondaryColor = Color.WhiteSmoke;
            cht_Inadimplentes.Series["Inadimplentes"].IsValueShownAsLabel = true;

            cht_AlunosMatriculados.Series.Clear();
            cht_AlunosMatriculados.Titles.Clear();
            cht_AlunosMatriculados.Series.Add("Alunos Matriculados");
            cht_AlunosMatriculados.Titles.Add("Alunos Matriculados");
            cht_AlunosMatriculados.Series["Alunos Matriculados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            cht_AlunosMatriculados.Series["Alunos Matriculados"].IsValueShownAsLabel = true;
            cht_AlunosMatriculados.Series["Alunos Matriculados"].BorderColor = Color.Black;
            cht_AlunosMatriculados.Series["Alunos Matriculados"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            cht_AlunosMatriculados.Series["Alunos Matriculados"].BorderWidth = 1;
            cht_AlunosMatriculados.Series["Alunos Matriculados"].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            cht_AlunosMatriculados.Series["Alunos Matriculados"].ShadowColor = Color.Silver;
            cht_AlunosMatriculados.Series["Alunos Matriculados"].ShadowOffset = 3;
            cht_AlunosMatriculados.Series["Alunos Matriculados"].BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            cht_AlunosMatriculados.Series["Alunos Matriculados"].BackSecondaryColor = Color.WhiteSmoke;
            cht_AlunosMatriculados.Series["Alunos Matriculados"].IsValueShownAsLabel = true;

            cht_VencimentosHoje.Series.Clear();
            cht_VencimentosHoje.Titles.Clear();
            cht_VencimentosHoje.Series.Add("Vencimentos Hoje");
            cht_VencimentosHoje.Titles.Add("Vencimentos Hoje");
            cht_VencimentosHoje.Series["Vencimentos Hoje"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            cht_VencimentosHoje.Series["Vencimentos Hoje"].IsValueShownAsLabel = true;
            cht_VencimentosHoje.Series["Vencimentos Hoje"].BorderColor = Color.Black;
            cht_VencimentosHoje.Series["Vencimentos Hoje"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            cht_VencimentosHoje.Series["Vencimentos Hoje"].BorderWidth = 1;
            cht_VencimentosHoje.Series["Vencimentos Hoje"].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            cht_VencimentosHoje.Series["Vencimentos Hoje"].ShadowColor = Color.Silver;
            cht_VencimentosHoje.Series["Vencimentos Hoje"].ShadowOffset = 3;
            cht_VencimentosHoje.Series["Vencimentos Hoje"].BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            cht_VencimentosHoje.Series["Vencimentos Hoje"].BackSecondaryColor = Color.WhiteSmoke;
            cht_VencimentosHoje.Series["Vencimentos Hoje"].IsValueShownAsLabel = true;
        }
    }
}
