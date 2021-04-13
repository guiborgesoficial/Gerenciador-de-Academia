using Business.SqlComandos.Atualizar;
using Business.SqlComandos.Cadastrar;
using Business.SqlComandos.Consultar;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using UserInterface;

namespace RCFitness.UserControls
{
    public partial class USC_medidasAluno : UserControl
    {
        VerificadorDeCampos verificador = new VerificadorDeCampos();
        public USC_medidasAluno()
        {
            InitializeComponent();
        }

        private void USC_medidasAluno_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void cmbbox_aluno_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbbox_aluno.SelectedIndex == 0)
            {
                lbl_id.Visible = false;
                lbl_idResult.Visible = false;
                lbl_idResult.Text = "";
            }
            else
            {
                CS_Matriculados consultaParaComboBox = new CS_Matriculados();
                consultaParaComboBox.ConsultadoMatriculados(cmbbox_aluno.Text);
                cmbbox_aluno.Text = consultaParaComboBox.IDNOVOALUNO.ToString();
                lbl_idResult.Text = consultaParaComboBox.IDNOVOALUNO.ToString();
                lbl_id.Visible = true;
                lbl_idResult.Visible = true;
                LimpaCampos();
            }
        }

        private void cmbbox_aluno_MouseClick(object sender, MouseEventArgs e)
        {
            cmbbox_aluno.Items.Clear();
            cmbbox_aluno.Items.Add("");
            CS_Matriculados novo = new CS_Matriculados();
            novo.ConsultaParaComboBox();
            cmbbox_aluno.Items.AddRange(novo.tabela.ToArray());
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            verificador.verificadorDeCamposPreenchidos = 0;
            verificador.VerificaCamposPreenchidos(pnl_print);

            if(verificador.verificadorDeCamposPreenchidos == 23)
            {
                verificador.VerificarCamposNuméricos(pnl_print);

                if(verificador.verificadorQtdInputsNumericosValidados == 23)
                {
                    verificador.VerificaCamposTempoReal.Stop();
                    verificador.VerificaCamposNuméricosTempoReal.Stop();
                    CD_MedidasAluno cadastrarMedidas = new CD_MedidasAluno();
                    cadastrarMedidas.InserindoMedidasAluno(int.Parse(lbl_idResult.Text), txtbox_altura.Text, txtbox_torax.Text, txtbox_abdomen.Text, txtbox_cintura.Text, txtbox_quadril.Text, txtbox_bracoDireito.Text, txtbox_bracoEsquerdo.Text, txtbox_antebracoDireito.Text, txtbox_antebracoEsquerdo.Text, txtbox_Dproximal.Text, txtbox_Dmedial.Text, txtbox_Ddistal.Text, txtbox_Eproximal.Text, txtbox_Emedial.Text, txtbox_Edistal.Text, txtbox_pernaDireita.Text, txtbox_pernaEsquerda.Text, txtbox_ombros.Text, txtbox_pescoco.Text, txtbox_punho.Text, txtbox_joelho.Text, txtbox_tornozelo.Text);
                    DialogResult msg = MessageBox.Show("Deseja cadastrar o peso desse aluno?", "CADASTRE O PESO DO ALUNO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (msg == DialogResult.Yes)
                    {
                        this.Visible = false;
                        USC_pesoAluno TelaPeso = new USC_pesoAluno();
                        this.Parent.Controls.Add(TelaPeso);
                        TelaPeso.lbl_idResult.Text = lbl_idResult.Text;
                        TelaPeso.lbl_idResult.Visible = true;
                        TelaPeso.cmbbox_aluno.Text = cmbbox_aluno.Text.ToUpper();
                        TelaPeso.Visible = true;
                        TelaPeso.lbl_id.Visible = true;
                    }
                }
                else
                {
                    verificador.VerificaCamposNuméricosTempoReal.Tick += VerificaCamposNuméricosTempoReal_Tick;
                    MessageBox.Show("Esses campos são numéricos", "Preencha com números", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                verificador.VerificaCamposTempoReal.Tick += VerificaCamposTempoReal_Tick;
                MessageBox.Show("O preenchimento dos campos é obrigatório!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void VerificaCamposTempoReal_Tick(object sender, EventArgs e)
        {
            verificador.VerificaCamposPreenchidos(pnl_print);
        }
        private void VerificaCamposNuméricosTempoReal_Tick(object sender, EventArgs e)
        {
            verificador.VerificarCamposNuméricos(pnl_print);
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            UP_MedidasAluno atualizarMedidas = new UP_MedidasAluno();

            verificador.verificadorDeCamposPreenchidos = 0;
            verificador.VerificaCamposPreenchidos(pnl_print);

            if (lbl_idResult.Text != "0" && lbl_idResult.Text != "ID:")
            {
                if (verificador.verificadorDeCamposPreenchidos == 23)
                {
                    verificador.VerificaCamposTempoReal.Stop();
                    atualizarMedidas.AtualizarMedidasAluno(int.Parse(lbl_idResult.Text), txtbox_altura.Text, txtbox_torax.Text, txtbox_abdomen.Text, txtbox_cintura.Text, txtbox_quadril.Text, txtbox_bracoDireito.Text, txtbox_bracoEsquerdo.Text, txtbox_antebracoDireito.Text, txtbox_antebracoEsquerdo.Text, txtbox_Dproximal.Text, txtbox_Dmedial.Text, txtbox_Ddistal.Text, txtbox_Eproximal.Text, txtbox_Emedial.Text, txtbox_Edistal.Text, txtbox_pernaDireita.Text, txtbox_pernaEsquerda.Text, txtbox_ombros.Text, txtbox_pescoco.Text, txtbox_punho.Text, txtbox_joelho.Text, txtbox_tornozelo.Text);
                }
                else
                {
                    verificador.VerificaCamposTempoReal.Start();
                    MessageBox.Show("Preencha os campos obrigatórios!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("É necessário realizar uma consulta para atualizar um cadastro!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            CS_MedidasAluno consultar = new CS_MedidasAluno();

            if(lbl_idResult.Text != "" && lbl_idResult.Text != "ID:")
            {
                consultar.ConsultandoMedidasAluno(int.Parse(lbl_idResult.Text));
                if (consultar.DT_COLETA == null)
                {
                    LimpaCampos();
                    MessageBox.Show("É necessário cadastrar uma medida para esse aluno!", "NENHUMA MEDIDA ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txtbox_altura.Text = consultar.ALTURA;
                    txtbox_torax.Text = consultar.TÓRAX;
                    txtbox_abdomen.Text = consultar.ABDÔMEN;
                    txtbox_cintura.Text = consultar.CINTURA;
                    txtbox_quadril.Text = consultar.QUADRIL;
                    txtbox_bracoDireito.Text = consultar.BRAÇO_D;
                    txtbox_bracoEsquerdo.Text = consultar.BRAÇO_E;
                    txtbox_antebracoDireito.Text = consultar.ANTEB_D;
                    txtbox_antebracoEsquerdo.Text = consultar.ANTEB_E;
                    txtbox_Dproximal.Text = consultar.COXAD_P;
                    txtbox_Dmedial.Text = consultar.COXAD_M;
                    txtbox_Ddistal.Text = consultar.COXAD_D;
                    txtbox_Eproximal.Text = consultar.COXAE_P;
                    txtbox_Emedial.Text = consultar.COXAE_M;
                    txtbox_Edistal.Text = consultar.COXAE_D;
                    txtbox_pernaDireita.Text = consultar.PERNA_D;
                    txtbox_pernaEsquerda.Text = consultar.PERNA_E;
                    txtbox_ombros.Text = consultar.OMBROS;
                    txtbox_pescoco.Text = consultar.PESCOÇO;
                    txtbox_joelho.Text = consultar.JOELHO;
                    txtbox_tornozelo.Text = consultar.TORNOZELO;
                    txtbox_punho.Text = consultar.PUNHO;
                    lbl_coletaResult.Text = Convert.ToDateTime(consultar.DT_COLETA).ToShortDateString();
                    lbl_coleta.Visible = true;
                    lbl_coletaResult.Visible = true;
                }
            }
            else
            {
                LimpaCampos();
                MessageBox.Show("É necessário selecionar um aluno para realizar a consulta!", "SELECIONE UM ALUNO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }     
        }
      
        private void btn_gerarPDF_Click(object sender, EventArgs e)
        {
            using (var image = new Bitmap(pnl_print.Width, pnl_print.Height))
            {
                pnl_print.DrawToBitmap(image, new Rectangle(0, 0, image.Width, image.Height));
                image.Save(@"C:\Users\PICHAU\Desktop\" + "Medidas Aluno - " + cmbbox_aluno.Text + ".png", ImageFormat.Png);
            }
        }
        private void LimpaCampos()
        {
            txtbox_abdomen.Text = "";
            txtbox_altura.Text = "";
            txtbox_torax.Text = "";
            txtbox_cintura.Text = "";
            txtbox_quadril.Text = "";
            txtbox_bracoDireito.Text = "";
            txtbox_bracoEsquerdo.Text = "";
            txtbox_antebracoDireito.Text = "";
            txtbox_antebracoEsquerdo.Text = "";
            txtbox_Dproximal.Text = "";
            txtbox_Dmedial.Text = "";
            txtbox_Ddistal.Text = "";
            txtbox_Eproximal.Text = "";
            txtbox_Emedial.Text = "";
            txtbox_Edistal.Text = "";
            txtbox_pernaDireita.Text = "";
            txtbox_pernaEsquerda.Text = "";
            txtbox_ombros.Text = "";
            txtbox_pescoco.Text = "";
            txtbox_joelho.Text = "";
            txtbox_tornozelo.Text = "";
            lbl_coletaResult.Text = "";
            txtbox_punho.Text = "";
            lbl_coleta.Visible = false;
            lbl_coletaResult.Visible = false;
        }        
    }
}
