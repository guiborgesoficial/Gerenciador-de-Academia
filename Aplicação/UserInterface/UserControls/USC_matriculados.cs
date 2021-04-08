using Business.SqlComandos.Atualizar;
using Business.SqlComandos.Cadastrar;
using Business.SqlComandos.Consultar;
using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using UserInterface;

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

        public bool VerificaExistenciaPrimeiraFatura = true;
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
                        VerificaExistenciaPrimeiraFatura = true;
                        if (string.IsNullOrEmpty(dataGridView_DadosPagamento[2,0].Value.ToString()))
                        {
                           lbl_dtUltimoPagamentoResultado.Text = "A PAGAR";
                           cmbbox_Plano.Text = (dataGridView_DadosPagamento[0, dataGridView_DadosPagamento.RowCount - 1].Value).ToString();
                           lbl_próximoVencResultado.Text = Convert.ToDateTime(dataGridView_DadosPagamento[4, dataGridView_DadosPagamento.RowCount - 1].Value).ToShortDateString();
                           VerificaExistenciaPrimeiraFatura = true;
                        }
                        else
                        {
                            lbl_dtUltimoPagamentoResultado.Text = Convert.ToDateTime(dataGridView_DadosPagamento[4, 0].Value).ToShortDateString();
                        }
                        break;
                    case 0:
                        MessageBox.Show("Nenhum pagamento foi cadastrado para esse aluno", "PAGAMENTO NÃO CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        VerificaExistenciaPrimeiraFatura = false;
                        break;
                    default:
                        VerificaExistenciaPrimeiraFatura = true;
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

        VerificadorDeCampos verificador = new VerificadorDeCampos();
        
        private void VerificaCamposTempoReal_Tick(object sender, EventArgs e)
        {
            verificador.VerificaCamposPreenchidos(this);
        }
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            verificador.verificadorDeCamposPreenchidos = 0;

            if (lbl_idResult.Text != "0" && lbl_idResult.Text != "ID:")
            {
                if (chckbox_pagarProxFatura.Checked == true)
                {
                    verificador.VerificaCamposPreenchidos(panel_resultado);

                    if (VerificaExistenciaPrimeiraFatura)
                    {
                        if (verificador.verificadorDeCamposPreenchidos == 2)
                        {
                            verificador.VerificaCamposTempoReal.Stop();
                            UP_Matriculados atualizarPagamento = new UP_Matriculados();
                            atualizarPagamento.AtualizarPagamento(int.Parse(lbl_idResult.Text));
                            atualizarPagamento.InserindoNovaFaturaMatriculados(int.Parse(lbl_idResult.Text), msktbox_Valor.Text, cmbbox_Plano.Text, "HAVER");

                            int cmbAlunoIndex = cmbbox_aluno.SelectedIndex;
                            cmbbox_aluno.SelectedIndex = 0;
                            cmbbox_aluno.SelectedIndex = cmbAlunoIndex;
                        }
                        else
                        {
                            verificador.VerificaCamposTempoReal.Tick += VerificaCamposTempoReal_Tick;
                            MessageBox.Show("É necessário preencher os campos obrigatórios", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (verificador.verificadorDeCamposPreenchidos == 2)
                        {
                            verificador.VerificaCamposTempoReal.Stop();
                            CD_NovoAluno inserindoPrimeiraFatura = new CD_NovoAluno();
                            inserindoPrimeiraFatura.InserindoPagamento(SqlDateTime.Null, msktbox_Valor.Text, cmbbox_Plano.Text, "HAVER");
                            

                            UP_Matriculados AtualizandoPrimeiraFatura = new UP_Matriculados();
                            AtualizandoPrimeiraFatura.lbl_id2 = int.Parse(lbl_idResult.Text);
                            AtualizandoPrimeiraFatura.AtualizarPagamento(int.Parse(lbl_idResult.Text));
                            AtualizandoPrimeiraFatura.InserindoNovaFaturaMatriculados(int.Parse(lbl_idResult.Text), msktbox_Valor.Text, cmbbox_Plano.Text, "HAVER");

                            int cmbAlunoIndex = cmbbox_aluno.SelectedIndex;
                            cmbbox_aluno.SelectedIndex = 0;
                            cmbbox_aluno.SelectedIndex = cmbAlunoIndex;
                        }
                        else
                        {
                            verificador.VerificaCamposTempoReal.Tick += VerificaCamposTempoReal_Tick;
                            MessageBox.Show("É necessário preencher os campos obrigatórios", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    verificador.VerificaCamposTempoReal.Stop();
                    MessageBox.Show("É necessário marcar como pago para atualizar", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                verificador.VerificaCamposTempoReal.Stop();
                MessageBox.Show("É necessário selecionar um aluno antes de atualizar", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            lbl_idResult.Text = "ID:";
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
