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

namespace RCFitness.UserControls
{
    public partial class USC_dadosAluno : UserControl
    {
        public USC_dadosAluno()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void USC_dadosAluno_Load(object sender, EventArgs e)
        {
            groupBox_Configurações.Visible = false;
            this.Visible = false;
        }

        private void cmbbox_aluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbox_aluno.SelectedIndex == 0)
            {
                lbl_id.Visible = false;
                lbl_idResult.Visible = false;
            }
            else
            {
                CS_Matriculados consultaComboBox = new CS_Matriculados();
                consultaComboBox.ConsultadoMatriculados(cmbbox_aluno.Text);
                cmbbox_aluno.Text = consultaComboBox.IDNOVOALUNO.ToString();
                lbl_idResult.Text = consultaComboBox.IDNOVOALUNO.ToString();
                lbl_id.Visible = true;
                lbl_idResult.Visible = true;
            }
        }

        private void cmbbox_aluno_MouseClick(object sender, MouseEventArgs e)
        {
            cmbbox_aluno.Items.Clear();
            cmbbox_aluno.Items.Add("");
            CS_Matriculados retornarItensArray = new CS_Matriculados();
            retornarItensArray.ConsultaParaComboBox();
            cmbbox_aluno.Items.AddRange(retornarItensArray.tabela.ToArray());
        }

        private void bnt_config_Click(object sender, EventArgs e)
        {
            groupBox_Configurações.Visible = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Deseja confirmar as alterações?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(confirmar == DialogResult.Yes)
            {
                groupBox_Configurações.Visible = false;
            }
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {

        }
    }
}
