using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RCFitness
{
    public partial class frm_Sistema : Form
    {
        private bool statusMaxForm = false;
        public frm_Sistema()
        {
            InitializeComponent();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictbox_logo_Click(object sender, EventArgs e)
        {
            VisibleUserControl(usC_novoAluno1);
            usC_novoAluno1.Visible = false;

            VisibleTruePanel();
            usC_chtAlunos.AtualizarTodosGraficosAluno();
            usC_chtFaturamento1.AtualizarChartFaturamento();
        }
        private void btn_novoAluno_Click(object sender, EventArgs e)
        {
            VisibleFalsePanel();
            usC_novoAluno1.LimpaCampos();
            VisibleUserControl(usC_novoAluno1);
        }
        private void btn_alunoMatriculado_Click(object sender, EventArgs e)
        {
            VisibleFalsePanel();
            usC_matriculados1.cmbbox_aluno.SelectedItem = string.Empty;
            VisibleUserControl(usC_matriculados1);
        }
        private void btn_peso_Click(object sender, EventArgs e)
        {
            VisibleFalsePanel();
            usC_pesoAluno1.cmbbox_aluno.SelectedItem = string.Empty;
            VisibleUserControl(usC_pesoAluno1);
        }
        private void btn_fichaTreino_Click(object sender, EventArgs e)
        {
            VisibleFalsePanel();
            usC_fichaTreino1.cmbbox_aluno.SelectedItem = string.Empty;
            VisibleUserControl(usC_fichaTreino1);
        }
        private void btn_medidas_Click(object sender, EventArgs e)
        {
            VisibleFalsePanel();
            usC_medidasAluno1.cmbbox_aluno.SelectedItem = string.Empty;
            VisibleUserControl(usC_medidasAluno1);
        }
        private void btn_emailSender_Click(object sender, EventArgs e)
        {
            VisibleFalsePanel();
            USC_emailSender1.cmbbox_aluno.SelectedItem = string.Empty;
            USC_emailSender1.groupBox_Configurações.Visible = false;
            USC_emailSender1.groupbox_inadimplentes.Visible = false;
            USC_emailSender1.groupBox_ConfigureSuaMensagem.Visible = true;
            VisibleUserControl(USC_emailSender1);
        }
        private void VisibleUserControl(UserControl x)
        {
            usC_novoAluno1.Visible = false;
            usC_matriculados1.Visible = false;
            usC_pesoAluno1.Visible = false;
            usC_fichaTreino1.Visible = false;
            USC_emailSender1.Visible = false;
            usC_medidasAluno1.Visible = false;
            x.Visible = true;
        }
        private void VisibleTruePanel()
        {
            lbl_dataCurta.Visible = true;
            lbl_datalonga.Visible = true;
            lbl_longData.Visible = true;
            usC_chtAlunos.Visible = true;
            usC_chtFaturamento1.Visible = true;
            btn_gerarPDF.Visible = true;
        }
        private void VisibleFalsePanel()
        {
            lbl_dataCurta.Visible = false;
            lbl_datalonga.Visible = false;
            lbl_longData.Visible = false;
            usC_chtAlunos.Visible = false;
            usC_chtFaturamento1.Visible = false;
            btn_gerarPDF.Visible = false;
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if(statusMaxForm)
            {
                this.WindowState = FormWindowState.Normal;
                statusMaxForm = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                statusMaxForm = true;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
