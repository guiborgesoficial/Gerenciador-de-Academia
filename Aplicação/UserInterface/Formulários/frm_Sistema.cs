using RCFitness.UserControls;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace RCFitness
{
    public partial class frm_Sistema : Form
    {
        public frm_Sistema()
        {
            InitializeComponent();
        }
        private void customBotãoImage1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictbox_logo_Click(object sender, EventArgs e)
        {
            pnl_UserControl.Controls.Clear();
            pnl_UserControl.Controls.Add(lbl_dataCurta);
            pnl_UserControl.Controls.Add(lbl_longData);
            pnl_UserControl.Controls.Add(lbl_datalonga);
            usC_chtAlunos.AtualizarTodosGraficosAluno();
            pnl_UserControl.Controls.Add(usC_chtAlunos);
            usC_chtFaturamento1.AtualizarChartFaturamento();
            pnl_UserControl.Controls.Add(usC_chtFaturamento1);
            pnl_UserControl.Controls.Add(btn_gerarPDF);
        }
        private void btn_novoAluno_Click(object sender, EventArgs e)
        {
            pnl_UserControl.Controls.Clear();
            pnl_UserControl.Controls.Add(usC_novoAluno1);
            usC_novoAluno1.LimpaCampos();
            usC_novoAluno1.Visible = true;
        }
        private void btn_alunoMatriculado_Click(object sender, EventArgs e)
        {
            pnl_UserControl.Controls.Clear();
            pnl_UserControl.Controls.Add(usC_matriculados1);
            usC_matriculados1.cmbbox_aluno.SelectedItem = string.Empty;
            usC_matriculados1.Visible = true;
        }
        private void btn_peso_Click(object sender, EventArgs e)
        {
            pnl_UserControl.Controls.Clear();
            pnl_UserControl.Controls.Add(usC_pesoAluno1);
            usC_pesoAluno1.cmbbox_aluno.SelectedItem = string.Empty;
            usC_pesoAluno1.Visible = true;
        }
        private void btn_fichaTreino_Click(object sender, EventArgs e)
        {
            pnl_UserControl.Controls.Clear();
            pnl_UserControl.Controls.Add(usC_fichaTreino1);
            usC_fichaTreino1.cmbbox_aluno.SelectedItem = string.Empty;
            usC_fichaTreino1.Visible = true;
        }
        private void btn_medidas_Click(object sender, EventArgs e)
        {
            pnl_UserControl.Controls.Clear();
            pnl_UserControl.Controls.Add(usC_medidasAluno1);
            usC_medidasAluno1.cmbbox_aluno.SelectedItem = string.Empty;
            usC_medidasAluno1.Visible = true;
        }
        private void btn_emailSender_Click(object sender, EventArgs e)
        {
            pnl_UserControl.Controls.Clear();
            pnl_UserControl.Controls.Add(USC_emailSender1);
            USC_emailSender1.cmbbox_aluno.SelectedItem = string.Empty;
            USC_emailSender1.Visible = true;
        }
        private void timer_dataCurta_Tick(object sender, EventArgs e)
        {
            DataHora();
        }
        private void DataHora()
        { 
            lbl_dataCurta.Text = DateTime.Now.ToShortDateString();
            lbl_datalonga.Text = DateTime.Now.ToLongTimeString();
            lbl_longData.Text = DateTime.Now.ToLongDateString().ToUpper();
        }

        private void btn_gerarPDF_Click(object sender, EventArgs e)
        {
            using (var image = new Bitmap(pnl_UserControl.Width, pnl_UserControl.Height))
            {
                pnl_UserControl.DrawToBitmap(image, new Rectangle(0, 0, image.Width, image.Height));
                image.Save(@"C:\Users\PICHAU\Desktop\" + "Gráficos" + ".png", ImageFormat.Png);
            }
        }
    }
}
