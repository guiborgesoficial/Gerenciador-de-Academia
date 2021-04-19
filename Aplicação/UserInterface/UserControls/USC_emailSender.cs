using Business.SqlComandos.Consultar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using UserInterface;

namespace RCFitness.UserControls
{
    public partial class USC_emailSender : UserControl
    {
        public USC_emailSender()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void USC_emailSender_Load(object sender, EventArgs e)
        {
            groupBox_Configurações.Visible = false;
            groupbox_inadimplentes.Visible = false;
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

        int visualizarCampoConfigurações = 0;
        private void bnt_config_Click(object sender, EventArgs e)
        {
            if(visualizarCampoConfigurações == 0)
            {
                groupBox_Configurações.Visible = true;
                groupbox_inadimplentes.Visible = false;
                groupBox_ConfigureSuaMensagem.Visible = true;
                visualizarCampoConfigurações = 1;
            }
            else
            {
                groupBox_Configurações.Visible = false;
                groupbox_inadimplentes.Visible = false;
                groupBox_ConfigureSuaMensagem.Visible = true;
                visualizarCampoConfigurações = 0;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Deseja confirmar as alterações?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(confirmar == DialogResult.Yes)
            {
                UserInterface.Properties.Settings.Default.email = textBox_email.Text;
                UserInterface.Properties.Settings.Default.senha = textBox_senha.Text;
                UserInterface.Properties.Settings.Default.Save();
                groupBox_Configurações.Visible = false;
                visualizarCampoConfigurações = 0;
            }
        }

        VerificadorDeCampos verificador = new VerificadorDeCampos();

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            DialogResult enviarCobrança = MessageBox.Show("Deseja enviar essa mensagem por email para esse aluno?", "Confirme o envio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (enviarCobrança == DialogResult.Yes)
            {
                verificador.VerificaCamposPreenchidos(groupBox_ConfigureSuaMensagem);
                if(cmbbox_aluno.Text == string.Empty || textBox_assunto.Text == string.Empty || textBox_escreverEmail.Text == string.Empty)
                {
                    verificador.VerificaCamposTempoReal.Tick += VerificaCamposTempoReal_Tick;
                    verificador.VerificaCamposTempoReal.Stop();
                    textBox_anexo.Controls.Clear();
                    MessageBox.Show("É necessário preencher os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        textBox_anexo.Controls.Clear();

                        verificador.VerificaCamposTempoReal.Stop();
                        AtribuidorSMTPePorta(textBox_email);

                        NetworkCredential login;
                        SmtpClient client;
                        MailMessage msg;

                        login = new NetworkCredential(textBox_email.Text, textBox_senha.Text);
                        client = new SmtpClient(SMTP);
                        client.Port = Convert.ToInt32(porta);
                        client.EnableSsl = true;
                        client.Credentials = login;

                        CS_DataGridEmailSenderPagamentosParaReceber consultandoEmail = new CS_DataGridEmailSenderPagamentosParaReceber();
                        consultandoEmail.ConsultadoEmailPorId(lbl_idResult.Text);

                        msg = new MailMessage();
                        msg.To.Add(new MailAddress(consultandoEmail.EMAIL));
                        msg.From = new MailAddress(textBox_email.Text);
                        msg.Body = textBox_escreverEmail.Text;

                        if (textBox_anexo.Text != "")
                        {
                            msg.Attachments.Add(new Attachment(textBox_anexo.Text));
                        }

                        msg.BodyEncoding = Encoding.UTF8;
                        msg.IsBodyHtml = false;
                        msg.Priority = MailPriority.High;
                        client.Send(msg);


                        MessageBox.Show("Cobranças enviadas com sucesso");
                        groupbox_inadimplentes.Visible = false;
                        groupBox_Configurações.Visible = false;
                        groupBox_ConfigureSuaMensagem.Visible = true;

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao enviar emails: " + erro);
                    }
                }
            }
        }   
        private void VerificaCamposTempoReal_Tick(object sender, EventArgs e)
        {
            verificador.VerificaCamposPreenchidos(groupBox_ConfigureSuaMensagem);
        }

        int visualizadorCampoInadimplentes = 0;
        private void btn_porquinho_Click(object sender, EventArgs e)
        {
            if (visualizadorCampoInadimplentes == 0)
            {
                //DATAGRIDVIEW_PAGAMENTOS DADOS DOS INADIMPLENTES
                CS_DataGridEmailSenderPagamentosParaReceber consultandoDadosInadimplentes = new CS_DataGridEmailSenderPagamentosParaReceber();
                consultandoDadosInadimplentes.ConsultandoPagamentosParaReceber(dataGridView_DadosPagamento);
                

                AlterarNomesColunasDataGridView(dataGridView_DadosPagamento);
                groupbox_inadimplentes.Visible = true;
                groupBox_ConfigureSuaMensagem.Visible = false;
                groupBox_Configurações.Visible = false;
                visualizadorCampoInadimplentes = 1;
                ListaEmailInadimplentes(dataGridView_DadosPagamento);
            }
            else
            {
                groupbox_inadimplentes.Visible = false;
                groupBox_ConfigureSuaMensagem.Visible = true;
                groupBox_Configurações.Visible = false;
                visualizadorCampoInadimplentes = 0;
            }
        }
        public void ListaEmailInadimplentes(DataGridView dadosEmail)
        {   
            EMAILf.Clear();
            NOMEf.Clear();
            int i = 0;
            while (i < dadosEmail.RowCount)
            {
                EMAILf.Add(dadosEmail["EMAIL", i].Value.ToString());
                NOMEf.Add(dadosEmail["NOME", i].Value.ToString());
                i++;
            }
        }

        public List<string> EMAILf = new List<string>();
        public List<string> NOMEf = new List<string>();
        public string SMTP = "";
        public string porta = "";

        private void btn_enviarCobranças_Click(object sender, EventArgs e)
        {
            if(dataGridView_DadosPagamento.Rows.Count < 1)
            {
                MessageBox.Show("Não há nenhum aluno com mensalidades atrasadas. Parabéns");
            }
            else
                enviarEmailsParaInadimplentes();
        }

        public async void enviarEmailsParaInadimplentes()
        {
            DialogResult enviarCobrança = MessageBox.Show("Deseja enviar cobranças por email para essa lista de alunos inadimplentes?", "Confirme o envio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (enviarCobrança == DialogResult.Yes)
            {
                for (int i = 0; i < EMAILf.Count; i++)
                {
                    try
                    {
                        AtribuidorSMTPePorta(textBox_email);

                        NetworkCredential login;
                        SmtpClient client;
                        MailMessage msg;

                        login = new NetworkCredential(textBox_email.Text, textBox_senha.Text);
                        client = new SmtpClient(SMTP);
                        client.Port = Convert.ToInt32(porta);
                        client.EnableSsl = true;
                        client.Credentials = login;

                        msg = new MailMessage();
                        msg.To.Add(new MailAddress(EMAILf[i]));
                        msg.From = new MailAddress(textBox_email.Text);
                        msg.Subject = "Sua mensalidade venceu";
                        msg.Body = "Opa " + NOMEf[i] + ", estou aqui passando para avisar que sua mensalidade venceu e para continuar treinando é necessário pagar sua fatura";
                        if (textBox_anexo.Text != "")
                        {
                            msg.Attachments.Add(new Attachment(textBox_anexo.Text));
                        }
                        msg.BodyEncoding = Encoding.UTF8;
                        msg.IsBodyHtml = false;
                        msg.Priority = MailPriority.High;
                        await client.SendMailAsync(msg);

                        if (i == EMAILf.Count)
                        {
                            MessageBox.Show("Cobranças enviadas com sucesso");
                            groupbox_inadimplentes.Visible = false;
                            groupBox_Configurações.Visible = false;
                            groupBox_ConfigureSuaMensagem.Visible = true;
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao enviar emails: " + erro);
                    }
                }
            }
        }
        public void AtribuidorSMTPePorta(TextBox email)
        {
            if (email.Text.Contains("outlook"))
            {
                SMTP = "smtp.office365.com";
                porta = "587";
            }
            else if (email.Text.Contains("hotmail"))
            {
                SMTP = "smtp.live.com";
                porta = "587";
            }
            else if (email.Text.Contains("gmail"))
            {
                SMTP = "smtp.gmail.com";
                porta = "587";
            }
            else if (email.Text.Contains("yahoo"))
            {
                SMTP = "smtp.mail.yahoo.com";
                porta = "465";
            }
            else if (email.Text.Contains("uol"))
            {
                SMTP = "smtps.uol.com.br";
                porta = "587";
            }
        }
        private void AlterarNomesColunasDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns[0].HeaderText = "ID DO PAGAMENTO";
            dataGridView.Columns[1].HeaderText = "NOME";
            dataGridView.Columns[2].HeaderText = "PLANO";
            dataGridView.Columns[3].HeaderText = "VALOR";
            dataGridView.Columns[4].HeaderText = "DATA DO PAGAMENTO";
            dataGridView.Columns[5].HeaderText = "STATUS";
            dataGridView.Columns[6].HeaderText = "DATA DO VENCIMENTO";
            dataGridView.Columns[7].HeaderText = "ID DO ALUNO";
            dataGridView.Columns[8].HeaderText = "EMAIL";
        }

        private void btn_anexoBuscar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_anexo.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox_senha.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox_senha.UseSystemPasswordChar = true;
        }

        private void btn_gerarPDF_Click(object sender, EventArgs e)
        {
            using (var image = new Bitmap(groupbox_inadimplentes.Width, groupbox_inadimplentes.Height))
            {
                groupbox_inadimplentes.DrawToBitmap(image, new Rectangle(0, 0, image.Width, image.Height));
                image.Save(@"C:\Users\PICHAU\Desktop\" + "Alunos Inadimplentes" + ".png", ImageFormat.Png);
            }
        }

        private void btn_msgPersonalizada1_Click(object sender, EventArgs e)
        {
            lbl_numeroMsgPersonalizada.Text = "1";
            lbl_numeroMsgPersonalizada.Visible = true;

            if(UserInterface.Properties.Settings.Default.btn_msgPersonalizada1.Length > 1)
            {
                textBox_assunto.Text = UserInterface.Properties.Settings.Default.btn_assuntoPersonalizado1;
                textBox_escreverEmail.Text = UserInterface.Properties.Settings.Default.btn_msgPersonalizada1;
            }
            else
            {
                textBox_assunto.Text = string.Empty;
                textBox_escreverEmail.Text = string.Empty;
                MessageBox.Show("Ainda não há nenhuma mensagem personalizada no preset 1", "Personalize uma mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_msgPersonalizada2_Click(object sender, EventArgs e)
        {
            lbl_numeroMsgPersonalizada.Text = "2";
            lbl_numeroMsgPersonalizada.Visible = true;

            if (UserInterface.Properties.Settings.Default.btn_msgPersonalizada2.Length > 1)
            {
                textBox_assunto.Text = UserInterface.Properties.Settings.Default.btn_assuntoPersonalizado2;
                textBox_escreverEmail.Text = UserInterface.Properties.Settings.Default.btn_msgPersonalizada2;
            }
            else
            {
                textBox_assunto.Text = string.Empty;
                textBox_escreverEmail.Text = string.Empty;
                MessageBox.Show("Ainda não há nenhuma mensagem personalizada no preset 2", "Personalize uma mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_msgPersonalizada3_Click(object sender, EventArgs e)
        {
            lbl_numeroMsgPersonalizada.Text = "3";
            lbl_numeroMsgPersonalizada.Visible = true;

            if (UserInterface.Properties.Settings.Default.btn_msgPersonalizada3.Length > 1)
            {
                textBox_assunto.Text = UserInterface.Properties.Settings.Default.btn_assuntoPersonalizado3;
                textBox_escreverEmail.Text = UserInterface.Properties.Settings.Default.btn_msgPersonalizada3;
            }
            else
            {
                textBox_assunto.Text = string.Empty;
                textBox_escreverEmail.Text = string.Empty;
                MessageBox.Show("Ainda não há nenhuma mensagem personalizada no preset 3", "Personalize uma mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_msgPersonalizada4_Click(object sender, EventArgs e)
        {
            lbl_numeroMsgPersonalizada.Text = "4";
            lbl_numeroMsgPersonalizada.Visible = true;

            if (UserInterface.Properties.Settings.Default.btn_msgPersonalizada4.Length > 1)
            {
                textBox_assunto.Text = UserInterface.Properties.Settings.Default.btn_assuntoPersonalizado4;
                textBox_escreverEmail.Text = UserInterface.Properties.Settings.Default.btn_msgPersonalizada4;
            }
            else
            {
                textBox_assunto.Text = string.Empty;
                textBox_escreverEmail.Text = string.Empty;
                MessageBox.Show("Ainda não há nenhuma mensagem personalizada no preset 4", "Personalize uma mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_salvarMsg_Click(object sender, EventArgs e)
        {
            switch(lbl_numeroMsgPersonalizada.Text)
            {
                case "1":
                    if(textBox_assunto.Text.Length > 1 && textBox_escreverEmail.Text.Length > 1)
                    {
                        UserInterface.Properties.Settings.Default.btn_msgPersonalizada1 = textBox_escreverEmail.Text;
                        UserInterface.Properties.Settings.Default.btn_assuntoPersonalizado1 = textBox_assunto.Text;
                        UserInterface.Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Preencha os campos Assunto e Mensagem para salvar um preset personalizado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "2":
                    if (textBox_assunto.Text.Length > 1 && textBox_escreverEmail.Text.Length > 1)
                    {
                        UserInterface.Properties.Settings.Default.btn_msgPersonalizada2 = textBox_escreverEmail.Text;
                        UserInterface.Properties.Settings.Default.btn_assuntoPersonalizado2 = textBox_assunto.Text;
                        UserInterface.Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Preencha os campos Assunto e Mensagem para salvar um preset personalizado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "3":
                    if (textBox_assunto.Text.Length > 1 && textBox_escreverEmail.Text.Length > 1)
                    {
                        UserInterface.Properties.Settings.Default.btn_msgPersonalizada3 = textBox_escreverEmail.Text;
                        UserInterface.Properties.Settings.Default.btn_assuntoPersonalizado3 = textBox_assunto.Text;
                        UserInterface.Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Preencha os campos Assunto e Mensagem para salvar um preset personalizado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "4":
                    if (textBox_assunto.Text.Length > 1 && textBox_escreverEmail.Text.Length > 1)
                    {
                        UserInterface.Properties.Settings.Default.btn_msgPersonalizada4 = textBox_escreverEmail.Text;
                        UserInterface.Properties.Settings.Default.btn_assuntoPersonalizado4 = textBox_assunto.Text;
                        UserInterface.Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Preencha os campos Assunto e Mensagem para salvar um preset personalizado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }
    }
}
