using System;
using Business;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Business.SqlComandos.Cadastrar;
using Business.SqlComandos.Consultar;
using Business.SqlComandos.Atualizar;
using System.Drawing.Text;
using UserInterface;
using System.Data.SqlTypes;

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
				msktbox_outroValor.Visible = true;
			}
			else
			{
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

			//VERIFICADOR É 17 CORRIGIR ERRO DO CMBBOXVALOR
			if (verificador.verificadorDeCamposPreenchidos >= 16)
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
				if(cadastrarNovoAluno.IdRetorno != 0)
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
			else
			{
				verificador.VerificaCamposTempoReal.Tick += VerificaCamposTempoReal_Tick;
				MessageBox.Show("O preenchimento dos campos é obrigatório!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void VerificaCamposTempoReal_Tick(object sender, EventArgs e)
		{
			verificador.VerificaCamposPreenchidos(this);
		}

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
					cmbbox_valor.Text = consultandoCadastrados.VALOR.ToString();
					txtbox_email.Text = consultandoCadastrados.EMAIL.ToString();
					if (consultandoCadastrados.WHATSAPP == "S")
						chckbox_whatsaap.Checked = true;
				}
			}
			else
			{
				MessageBox.Show("É necessário informar um RG ou CPF para consultar um cliente cadastrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		private void btn_atualizar_Click(object sender, EventArgs e)
		{
			UP_NovoAluno atualizarCadastrados = new UP_NovoAluno();
			string Whatsaap;
			if (lbl_id.Text != "0" && lbl_id.Text != "ID:")
			{
				if(verificador.verificadorDeCamposPreenchidos == 17)
				{
					if (chckbox_whatsaap.Checked == true)
					{
						Whatsaap = "S";
					}
					else
					{
						Whatsaap = "N";
					}
					if (cmbbox_valor.Text == "OUTROS")
					{
						cmbbox_valor.Text = msktbox_outroValor.Text;
					}
					atualizarCadastrados.AtualizandoNovoAluno(lbl_id.Text, txtbox_nome.Text, msktbox_dtNascimento.Text, cmbbox_sexo.Text, msktbox_rg.Text, mstkbox_cpf.Text, msktbox_telefone.Text, Whatsaap, txtbox_endereco.Text, txtbox_numero.Text, txtbox_bairro.Text, cmbbox_uf.Text, msktbox_cep.Text, cmbbox_cidade.Text, msktbox_dtMatricula.Text, cmbbox_marketing.Text, txtbox_email.Text);
				}
				else
				{
					MessageBox.Show("Preencha os campos obrigatórios!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("É necessário realizar uma consulta para atualizar um cadastro!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}   
}
