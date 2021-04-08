using System;
using Business;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCFitness.UserControls;
using System.Data.SqlClient;
using System.Windows.Forms;
using Business.SqlComandos.Consultar;
using RCFitness.UserControls.Charts;
using Business.SqlComandos.Consultar.Charts;
using System.Drawing.Imaging;

namespace RCFitness
{
    public partial class frm_Sistema : Form
    {
        public frm_Sistema()
        {
            InitializeComponent();
        }
        private void frm_Sistema_Load(object sender, EventArgs e)
        {
            
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
        }
        private void btn_novoAluno_Click(object sender, EventArgs e)
        {
            pnl_UserControl.Controls.Clear();
            USC_novoAluno telaAluno = new USC_novoAluno();
            pnl_UserControl.Controls.Add(telaAluno);
            telaAluno.Visible = true;
        }
        private void btn_alunoMatriculado_Click(object sender, EventArgs e)
        {
            pnl_UserControl.Controls.Clear();
            USC_matriculados TelaMatriculado = new USC_matriculados();
            pnl_UserControl.Controls.Add(TelaMatriculado);
            TelaMatriculado.Visible = true;
        }
        private void btn_peso_Click(object sender, EventArgs e)
        {
            pnl_UserControl.Controls.Clear();
            USC_pesoAluno TelaPeso = new USC_pesoAluno();
            pnl_UserControl.Controls.Add(TelaPeso);
            TelaPeso.Visible = true;
        }
        private void btn_fichaTreino_Click(object sender, EventArgs e)
        {
            pnl_UserControl.Controls.Clear();
            USC_fichaTreino TelaFichaTreino = new USC_fichaTreino();
            pnl_UserControl.Controls.Add(TelaFichaTreino);
            TelaFichaTreino.Visible = true;
        }
        private void btn_medidas_Click(object sender, EventArgs e)
        {
            pnl_UserControl.Controls.Clear();
            USC_medidasAluno TelaMedidas = new USC_medidasAluno();
            pnl_UserControl.Controls.Add(TelaMedidas);
            TelaMedidas.Visible = true;
        }
        private void btn_dados_Click(object sender, EventArgs e)
        {
            pnl_UserControl.Controls.Clear();
            USC_emailSender TelaDados = new USC_emailSender();
            pnl_UserControl.Controls.Add(TelaDados);
            TelaDados.Visible = true;
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
        private void usC_chtAlunosCadastrados1_Load(object sender, EventArgs e)
        {

        }
        private void pnl_menuLateral_Paint(object sender, PaintEventArgs e)
        {

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
