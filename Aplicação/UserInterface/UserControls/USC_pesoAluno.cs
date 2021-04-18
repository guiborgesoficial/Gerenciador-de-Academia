using Business.SqlComandos.Cadastrar;
using Business.SqlComandos.Consultar;
using System;
using System.Drawing;
using System.Windows.Forms;
using UserInterface;

namespace RCFitness.UserControls
{
    public partial class USC_pesoAluno : UserControl
    {
        VerificadorDeCampos verificarCampos = new VerificadorDeCampos();
        public USC_pesoAluno()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void USC_pesoAluno_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void cmbbox_aluno_MouseClick(object sender, MouseEventArgs e)
        {
            cmbbox_aluno.Items.Clear();
            cmbbox_aluno.Items.Add("");
            CS_Matriculados retornandoItensArray = new CS_Matriculados();
            retornandoItensArray.ConsultaParaComboBox();

            cmbbox_aluno.Items.AddRange(retornandoItensArray.tabela.ToArray());
        }

        private void cmbbox_aluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbbox_aluno.SelectedIndex == 0)
            {
                lbl_id.Visible = false;
                lbl_idResult.Visible = false;
                msktbox_peso.Text = "";

                lbl_imc.Visible = false;
                lbl_imcResultado.Visible = false;
                lbl_resultadoIMC.Visible = false;
            }
            else
            {
                lbl_imc.Visible = false;
                lbl_imcResultado.Visible = false;
                lbl_resultadoIMC.Visible = false;
                CS_Matriculados consultandoParaComboBox = new CS_Matriculados();
                consultandoParaComboBox.ConsultadoMatriculados(cmbbox_aluno.Text);
                lbl_idResult.Text = consultandoParaComboBox.IDNOVOALUNO.ToString();
                lbl_id.Visible = true;
                lbl_idResult.Visible = true;
                msktbox_peso.Text = "";
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string dtAtual = DateTime.Now.ToShortDateString();
            CD_PesoAluno cadastroPesoAluno = new CD_PesoAluno();

            verificarCampos.VerificaCamposPreenchidos(this);

            if(lbl_idResult.Text != "0" && lbl_idResult.Text != "ID:")
            {
                if (msktbox_peso.Text != string.Empty)
                {
                    verificarCampos.VerificaCamposTempoReal.Stop();
                    msktbox_peso.Controls.Clear();
                    if (lbl_imcResultado.Text == "PESO:")
                    {
                        lbl_imcResultado.Text = "0";
                    }
                    cadastroPesoAluno.CadastroPesoAluno(dtAtual, msktbox_peso.Text, lbl_imcResultado.Text, int.Parse(lbl_idResult.Text));
                    DialogResult msg = MessageBox.Show("Deseja cadastrar uma ficha de treino para esse aluno?", "CADASTRE UMA FICHA DE TREINO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (msg == DialogResult.Yes)
                    {
                        this.Visible = false;
                        USC_fichaTreino TelaFicha = new USC_fichaTreino();
                        this.Parent.Controls.Add(TelaFicha);
                        TelaFicha.lbl_idResult.Text = lbl_idResult.Text;
                        TelaFicha.lbl_idResult.Visible = true;
                        TelaFicha.cmbbox_aluno.Text = cmbbox_aluno.Text.ToUpper();
                        TelaFicha.Visible = true;
                        TelaFicha.lbl_id.Visible = true;
                        TelaFicha.Visible = true;
                    }
                }
                else
                {
                    verificarCampos.VerificaCamposTempoReal.Stop();

                    MessageBox.Show("É preciso preencher o campo peso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Panel LarguraCampo = new Panel();
                    Panel AlturaCampo = new Panel();

                    msktbox_peso.Controls.Clear();
                    AlturaCampo.Height = msktbox_peso.Height;
                    AlturaCampo.Width = 1;
                    AlturaCampo.BackColor = Color.Red;
                    msktbox_peso.Controls.Add(AlturaCampo);

                    LarguraCampo.Width = msktbox_peso.Width;
                    LarguraCampo.Height = 1;
                    LarguraCampo.BackColor = Color.Red;
                    msktbox_peso.Controls.Add(LarguraCampo);
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar um aluno antes de cadastrar um peso", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void VerificaCamposTempoReal_Tick(object sender, EventArgs e)
        {
            verificarCampos.VerificaCamposPreenchidos(this);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if(lbl_idResult.Text != "0" && lbl_idResult.Text != "ID:")
            {
                CS_PesoAluno consultandoCadastrados = new CS_PesoAluno();
                consultandoCadastrados.ConsultandoPesoAluno(int.Parse(lbl_idResult.Text));

                CS_MedidasAluno retornAltura = new CS_MedidasAluno();
                retornAltura.ConsultandoMedidasAluno(int.Parse(lbl_idResult.Text));

                msktbox_peso.Text = consultandoCadastrados.PESOALUNO;

                if(consultandoCadastrados.PESOALUNO != null && retornAltura.ALTURA != null)
                {
                    double imc = double.Parse(msktbox_peso.Text) / (double.Parse(retornAltura.ALTURA) * double.Parse(retornAltura.ALTURA));
                    lbl_imcResultado.Text = imc.ToString();
                    if (imc < 18.5)
                    {
                        lbl_resultadoIMC.Text = "ABAIXO DO PESO";
                        lbl_resultadoIMC.ForeColor = Color.Red;
                    }
                    else if (imc >= 18.5 && imc < 24.9)
                    {
                        lbl_resultadoIMC.Text = "PESO NORMAL";
                        lbl_resultadoIMC.ForeColor = Color.Green;
                    }
                    else if (imc >= 25 && imc < 29.9)
                    {
                        lbl_resultadoIMC.Text = "SOBREPESO";
                        lbl_resultadoIMC.ForeColor = Color.Red;
                    }
                    else if (imc >= 30 && imc < 34.9)
                    {
                        lbl_resultadoIMC.Text = "OBESIDADE GRAU 1";
                        lbl_resultadoIMC.ForeColor = Color.Red;
                    }
                    else if (imc >= 35 && imc < 39.9)
                    {
                        lbl_resultadoIMC.Text = "OBESIDADE GRAU 2";
                        lbl_resultadoIMC.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbl_resultadoIMC.Text = "OBESIDADE GRAU 3";
                        lbl_resultadoIMC.ForeColor = Color.Red;
                    }

                    lbl_imc.Visible = true;
                    lbl_imcResultado.Visible = true;
                    lbl_resultadoIMC.Visible = true;
                }
                else
                {
                    MessageBox.Show("É necessário cadastrar um peso ou altura para esse aluno.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar um aluno para realizar a consulta.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
