using System;
using Business;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.SqlComandos.Consultar;
using Business.SqlComandos.Atualizar;
using Business.SqlComandos.Excluir;

namespace RCFitness.UserControls
{
    public partial class USC_matriculados : UserControl
    {
        public USC_matriculados()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void USC_matriculados_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void cmbbox_aluno_MouseClick(object sender, MouseEventArgs e)
        {
            cmbbox_aluno.Items.Clear();
            cmbbox_aluno.Items.Add("");
            CS_Matriculados retornarItensArray = new CS_Matriculados();
            retornarItensArray.ConsultaParaComboBox();

            cmbbox_aluno.Items.AddRange(retornarItensArray.tabela.ToArray());
        }

        private void cmbbox_aluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbox_aluno.SelectedIndex == 0)
            {
                EsconderCampos();
            }
            else
            {
                CS_DatarGridView_DadosPagamento populandoDataGridView = new CS_DatarGridView_DadosPagamento();
                CS_Matriculados consultandoComboBox = new CS_Matriculados();
                consultandoComboBox.ConsultadoMatriculados(cmbbox_aluno.Text);
                populandoDataGridView.ConsultandoDadosPagamento(consultandoComboBox.IDNOVOALUNO, dataGridView_DadosPagamento);
                AlterarNomesColunasDataGridView(dataGridView_DadosPagamento);

                lbl_idResult.Text = consultandoComboBox.IDNOVOALUNO.ToString();
                lbl_dtMatriculaResultado.Text = consultandoComboBox.DT_MATRÍC.ToShortDateString();

                switch(dataGridView_DadosPagamento.Rows.Count)
                {
                    case 1:
                        if(string.IsNullOrEmpty(dataGridView_DadosPagamento[2,0].Value.ToString()))
                        {
                           lbl_dtUltimoPagamentoResultado.Text = "A PAGAR";
                           cmbbox_Plano.Text = (dataGridView_DadosPagamento[0, dataGridView_DadosPagamento.RowCount - 1].Value).ToString();
                           lbl_próximoVencResultado.Text = Convert.ToDateTime(dataGridView_DadosPagamento[4, dataGridView_DadosPagamento.RowCount - 1].Value).ToShortDateString(); ;
                        }
                        else
                        {
                            lbl_dtUltimoPagamentoResultado.Text = Convert.ToDateTime(dataGridView_DadosPagamento[4, 0].Value).ToShortDateString();
                        }
                        break;
                    case 0:
                        MessageBox.Show("Nenhum pagamento foi cadastrado para esse aluno", "PAGAMENTO NÃO CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        lbl_dtUltimoPagamentoResultado.Text = Convert.ToDateTime(dataGridView_DadosPagamento[2, dataGridView_DadosPagamento.RowCount - 2].Value).ToShortDateString();
                        lbl_próximoVencResultado.Text = Convert.ToDateTime(dataGridView_DadosPagamento[4, dataGridView_DadosPagamento.RowCount - 1].Value).ToShortDateString();
                        cmbbox_Plano.Text = (dataGridView_DadosPagamento[0, dataGridView_DadosPagamento.RowCount - 1].Value).ToString();

                        if (DateTime.Today >= Convert.ToDateTime(dataGridView_DadosPagamento[4, dataGridView_DadosPagamento.RowCount - 1].Value))
                        {
                            lbl_statusResultado.ForeColor = Color.Red;
                            lbl_dtUltimoPagamentoResultado.Visible = false;
                            lbl_statusResultado.Text = "Inadimplente";
                            lbl_statusResultado.Visible = true;
                        }
                        else
                        {
                            lbl_statusResultado.ForeColor = Color.Green;
                            lbl_statusResultado.Text = "Adimplente";
                            lbl_statusResultado.Visible = true;
                        }
                        break;
                }
                    
                MostrarCampos();
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            UP_Matriculados atualizarPagamento = new UP_Matriculados();
            if (lbl_idResult.Text != "0" && lbl_idResult.Text != "ID:")
            {
                if (chckbox_pagarProxFatura.Checked == true)
                {
                    atualizarPagamento.AtualizarPagamento(int.Parse(lbl_idResult.Text));
                    atualizarPagamento.InserindoNovaFaturaMatriculados(int.Parse(lbl_idResult.Text), msktbox_Valor.Text, cmbbox_Plano.Text, "HAVER");
                }
                else
                {
                    MessageBox.Show("É necessário marcar como pago para atualizar", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar um aluno antes de atualizar", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            DL_Matriculados deletarCliente = new DL_Matriculados();
            if (lbl_idResult.Text != "0" && lbl_idResult.Text != "ID:")
            {
                DialogResult confirmar = MessageBox.Show("Você tem certeza que deseja excluir esse aluno do cadastro de clientes?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmar == DialogResult.Yes)
                {
                    deletarCliente.DeletarMatriculados(int.Parse(lbl_idResult.Text));
                    lbl_idResult.Text = "";
                    lbl_idResult.Visible = false;
                    panel_resultado.Controls.Clear();
                    cmbbox_aluno.Text = "";
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar um aluno antes de deletar", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AlterarNomesColunasDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns.Remove(dataGridView.Columns[0]);
            dataGridView.Columns[2].HeaderText = "DATA DE PAGAMENTO";
            dataGridView.Columns[4].HeaderText = "DATA DE VENCIMENTO";
            dataGridView.Columns[5].HeaderText = "PRÓXIMO PAGAMENTO";
            dataGridView.Columns[6].HeaderText = "ID DO ALUNO";
        }

        private void cmbbox_Plano_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbbox_Plano.SelectedIndex == 0)
            {
                msktbox_Valor.Mask = "$00.00";
                msktbox_Valor.Text = "70.00";
            }
            else if(cmbbox_Plano.SelectedIndex == 1)
            {
                msktbox_Valor.Mask = "$000.00";
                msktbox_Valor.Text = "180.00";
            }
            else
            {
                msktbox_Valor.Mask = "$000.00";
                msktbox_Valor.Text = "660.00";
            }
        }
        private void EsconderCampos()
        {
            lbl_dtMatriculaResultado.Visible = false;
            lbl_idResult.Visible = false;
            lbl_id.Visible = false;
            cmbbox_Plano.Visible = false;
            msktbox_Valor.Visible = false;
            lbl_dtUltimoPagamentoResultado.Visible = false;
            lbl_próximoVencResultado.Visible = false;
            lbl_statusResultado.Visible = false;
            dataGridView_DadosPagamento.Visible = false;
        }
        private void MostrarCampos()
        {
            chckbox_pagarProxFatura.Visible = true;
            lbl_dtMatriculaResultado.Visible = true;
            lbl_idResult.Visible = true;
            lbl_id.Visible = true;
            cmbbox_Plano.Visible = true;
            msktbox_Valor.Visible = true;
            lbl_dtUltimoPagamentoResultado.Visible = true;
            lbl_próximoVencResultado.Visible = true;
            dataGridView_DadosPagamento.Visible = true;
        }
    }
}
