using Business.SqlComandos.Atualizar;
using Business.SqlComandos.Cadastrar;
using Business.SqlComandos.Consultar;
using System;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UserInterface;

namespace RCFitness.UserControls
{
    public partial class USC_novoAluno : UserControl
	{
		public string StatusPag = DateTime.Now.ToShortDateString();
		VerificadorDeCampos verificador = new VerificadorDeCampos();
		public USC_novoAluno()
		{
			InitializeComponent();
		}
		private void USC_novoAluno_Load(object sender, EventArgs e)
		{
			this.Visible = false;
			cmbbox_uf.SelectedIndex = 25;
			msktbox_cep.Text = "12980000";
			cmbbox_cidade.SelectedIndex = 0;
			msktbox_dtMatricula.Text = DateTime.Now.ToShortDateString();
			cmbbox_plano.SelectedIndex = 0;
			cmbbox_valor.SelectedIndex = 0;
		}
		private void btn_voltar_Click(object sender, EventArgs e)
		{
			this.Visible = false;
		}

		private void cmbbox_valor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbbox_valor.SelectedIndex == 3)
			{
				msktbox_outroValor.Enabled = true;
				msktbox_outroValor.Visible = true;
			}
			else
			{
				msktbox_outroValor.Text = string.Empty;
				msktbox_outroValor.Enabled = false;
				msktbox_outroValor.Visible = false;
			}
		}
		private void cmbbox_plano_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbbox_plano.SelectedIndex == 0)
			{
				cmbbox_valor.SelectedIndex = 0;
				msktbox_outroValor.Mask = "$00.00";
			}
			else if (cmbbox_plano.SelectedIndex == 1)
			{
				cmbbox_valor.SelectedIndex = 1;
				msktbox_outroValor.Mask = "$000.00";

			}
			else if (cmbbox_plano.SelectedIndex == 2)
			{
				cmbbox_valor.SelectedIndex = 2;
				msktbox_outroValor.Mask = "$000.00";

			}
			else if (cmbbox_plano.SelectedIndex == 3)
			{
				cmbbox_valor.SelectedIndex = 3;
			}
		}
		private void btn_cadastrar_Click(object sender, EventArgs e)
		{
			verificador.verificadorDeCamposPreenchidos = 0;
			verificador.VerificaCamposPreenchidos(this);

			if (cmbbox_valor.Text != "OUTROS" && verificador.verificadorDeCamposPreenchidos == 17)
			{
				Cadastrando();
			}
			else if (cmbbox_valor.Text == "OUTROS" && verificador.verificadorDeCamposPreenchidos == 18)
			{
				Cadastrando();
			}
			else
			{
				verificador.VerificaCamposTempoReal.Tick += VerificaCamposTempoReal_Tick;
				MessageBox.Show("O preenchimento dos campos é obrigatório!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		public void Cadastrando()
		{
			verificador.VerificaCamposTempoReal.Stop();
			string Whatsaap;
			SqlDateTime DataPagamento = SqlDateTime.Null;
			CD_NovoAluno cadastrarNovoAluno = new CD_NovoAluno();

			if (chckbox_whatsaap.Checked)
			{
				Whatsaap = "S";
			}
			else
			{
				Whatsaap = "N";
			}
			if (cmbbox_valor.Text == "OUTROS")
			{
				cmbbox_valor.Items.Add(msktbox_outroValor.Text);
				cmbbox_valor.SelectedItem = msktbox_outroValor.Text;
			}
			else
			{
				msktbox_outroValor.Text = "0000";
			}

			cadastrarNovoAluno.InserindoNovoAluno(txtbox_nome.Text, msktbox_dtNascimento.Text, cmbbox_sexo.Text, msktbox_rg.Text, mstkbox_cpf.Text, msktbox_telefone.Text, Whatsaap, txtbox_endereco.Text, txtbox_numero.Text, txtbox_bairro.Text, cmbbox_uf.Text, msktbox_cep.Text, cmbbox_cidade.Text, msktbox_dtMatricula.Text, cmbbox_marketing.Text, txtbox_email.Text);
			if (cadastrarNovoAluno.IdRetorno != 0)
			{
				if (chckbox_pago.Checked)
				{
					DataPagamento = DateTime.Now;
					cadastrarNovoAluno.InserindoPagamento(DataPagamento, cmbbox_valor.Text, cmbbox_plano.Text, "PAGO");
					UP_Matriculados inserindoNovaFatura = new UP_Matriculados();
					inserindoNovaFatura.InserindoNovaFaturaMatriculados(cadastrarNovoAluno.IdRetorno, cmbbox_valor.Text, cmbbox_plano.Text, "HAVER");
				}
				else
				{
					cadastrarNovoAluno.InserindoPagamento(SqlDateTime.Null, cmbbox_valor.Text, cmbbox_plano.Text, "HAVER");
				}
				if (cadastrarNovoAluno.IdRetorno != 0)
				{
					DialogResult msg = MessageBox.Show("Deseja Cadastrar as medidas do Aluno?", "Medidas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (msg == DialogResult.Yes)
					{
						this.Visible = false;
						USC_medidasAluno TelaMedidas = new USC_medidasAluno();
						this.Parent.Controls.Add(TelaMedidas);
						TelaMedidas.lbl_idResult.Text = cadastrarNovoAluno.IdRetorno.ToString();
						TelaMedidas.lbl_idResult.Visible = true;
						TelaMedidas.cmbbox_aluno.Text = txtbox_nome.Text.ToUpper();
						TelaMedidas.Visible = true;
					}
				}
			}
		} 
		private void VerificaCamposTempoReal_Tick(object sender, EventArgs e)
		{
			verificador.VerificaCamposPreenchidos(this);
		}
		public string verificarMudançaValorMensalidade = "";
		private void btn_consultar_Click(object sender, EventArgs e)
		{
			if(!msktbox_rg.Text.Contains("_") || !mstkbox_cpf.Text.Contains("_"))
			{
				CS_NovoAluno consultandoCadastrados = new CS_NovoAluno();
				consultandoCadastrados.ConsultandoNovoAluno(msktbox_rg.Text, mstkbox_cpf.Text);
				lbl_id.Text = consultandoCadastrados.IDNOVOALUNO.ToString();
				if (lbl_id.Text == "0" || lbl_id.Text == "ID:")
				{
					MessageBox.Show("Esse RG ou CPF não está cadastrado no sistema", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					verificarMudançaValorMensalidade = "";
					lbl_id.Visible = true;
					lbl_idInfo.Visible = true;
					txtbox_nome.Text = consultandoCadastrados.NOME;
					msktbox_dtNascimento.Text = consultandoCadastrados.DT_NASC.ToString();
					cmbbox_sexo.Text = consultandoCadastrados.SEXO;
					msktbox_rg.Text = consultandoCadastrados.RG;
					mstkbox_cpf.Text = consultandoCadastrados.CPF;
					msktbox_telefone.Text = consultandoCadastrados.TELEFONE;
					txtbox_endereco.Text = consultandoCadastrados.ENDEREÇO;
					txtbox_numero.Text = consultandoCadastrados.NÚMERO;
					txtbox_bairro.Text = consultandoCadastrados.BAIRRO;
					cmbbox_uf.Text = consultandoCadastrados.UF;
					msktbox_cep.Text = consultandoCadastrados.CEP;
					cmbbox_cidade.Text = consultandoCadastrados.CIDADE;
					msktbox_dtMatricula.Text = consultandoCadastrados.DT_MATRÍC.ToString();
					cmbbox_marketing.Text = consultandoCadastrados.MARKETING;
					cmbbox_plano.Text = consultandoCadastrados.PLANO;
					
					if(cmbbox_valor.Items.Contains(consultandoCadastrados.VALOR))
                    {
						cmbbox_valor.Text = consultandoCadastrados.VALOR.ToString();
					}
                    else
                    {
						cmbbox_valor.SelectedIndex = 3;
						msktbox_outroValor.Text = consultandoCadastrados.VALOR;
						msktbox_outroValor.Visible = true;
                    }

					txtbox_email.Text = consultandoCadastrados.EMAIL.ToString();
					verificarMudançaValorMensalidade = consultandoCadastrados.VALOR;
					if (consultandoCadastrados.WHATSAPP == "S")
						chckbox_whatsaap.Checked = true;
				}
			}
			else
			{
				MessageBox.Show("É necessário informar um RG ou CPF para consultar um cliente cadastrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}			
		
		public string Whatsaap;

		private void btn_atualizar_Click(object sender, EventArgs e)
		{
			UP_NovoAluno atualizarCadastrados = new UP_NovoAluno();
			if (lbl_id.Text != "0" && lbl_id.Text != "ID:")
			{
				verificador.verificadorDeCamposPreenchidos = 0;
				verificador.VerificaCamposPreenchidos(this);
				if (cmbbox_valor.Text != "OUTROS" && verificador.verificadorDeCamposPreenchidos == 17)
				{
					verificador.VerificaCamposTempoReal.Stop();
					if (chckbox_whatsaap.Checked == true)
					{
						Whatsaap = "S";
					}
					else
					{
						Whatsaap = "N";
					}
					atualizarCadastrados.AtualizandoNovoAluno(lbl_id.Text, txtbox_nome.Text, msktbox_dtNascimento.Text, cmbbox_sexo.Text, msktbox_rg.Text, mstkbox_cpf.Text, msktbox_telefone.Text, Whatsaap, txtbox_endereco.Text, txtbox_numero.Text, txtbox_bairro.Text, cmbbox_uf.Text, msktbox_cep.Text, cmbbox_cidade.Text, msktbox_dtMatricula.Text, cmbbox_marketing.Text, txtbox_email.Text);
					if (verificarMudançaValorMensalidade != cmbbox_valor.Text)
					{
						MessageBox.Show("O valor da mensalidade deve ser atualizado na próxima fatura pela aba 'MATRICULADOS'", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
						verificarMudançaValorMensalidade = cmbbox_valor.Text;
					}
				}
				else if (cmbbox_valor.Text == "OUTROS" && verificador.verificadorDeCamposPreenchidos == 18)
				{
					verificador.VerificaCamposTempoReal.Stop();
					cmbbox_valor.Text = msktbox_outroValor.Text;
					if (chckbox_whatsaap.Checked == true)
					{
						Whatsaap = "S";
					}
					else
					{
						Whatsaap = "N";
					}
					atualizarCadastrados.AtualizandoNovoAluno(lbl_id.Text, txtbox_nome.Text, msktbox_dtNascimento.Text, cmbbox_sexo.Text, msktbox_rg.Text, mstkbox_cpf.Text, msktbox_telefone.Text, Whatsaap, txtbox_endereco.Text, txtbox_numero.Text, txtbox_bairro.Text, cmbbox_uf.Text, msktbox_cep.Text, cmbbox_cidade.Text, msktbox_dtMatricula.Text, cmbbox_marketing.Text, txtbox_email.Text);
					if (verificarMudançaValorMensalidade != msktbox_outroValor.Text)
					{
						MessageBox.Show("O valor da mensalidade deve ser atualizado na próxima fatura pela aba 'MATRICULADOS'", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
						verificarMudançaValorMensalidade = cmbbox_valor.Text;

					}
				}
				else
				{
					verificador.VerificaCamposTempoReal.Tick += VerificaCamposTempoReal_Tick;
					MessageBox.Show("Preencha os campos obrigatórios!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("É necessário realizar uma consulta para atualizar um cadastro!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

        private void txtbox_email_Leave(object sender, EventArgs e)
        {
			string email = txtbox_email.Text;

			Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

			if (!(rg.IsMatch(email)))
			{
				txtbox_email.Text = "";
				lbl_emailVálido.Visible = true;
				txtbox_email.Focus();
			}
            else
            {
				lbl_emailVálido.Visible = false;
            }
		}
    }   
}
