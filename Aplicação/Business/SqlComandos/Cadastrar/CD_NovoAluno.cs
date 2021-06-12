using DataBase;
using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace Business.SqlComandos.Cadastrar
{
    public class CD_NovoAluno
    {
        public int IdRetorno { get; set;}
        public string strInserçãoFrequencia = "INSERT INTO Frequencia (FREQUENCIA, ID_NOVOALUNO) VALUES (@FREQUENCIA, @ID_NOVOALUNO)";
        public string strInserçãoNovoAluno = "INSERT INTO NovoAluno (NOME , DT_NASC, SEXO, RG, CPF, TELEFONE, WHATSAPP, ENDEREÇO, NÚMERO, BAIRRO, UF, CEP, CIDADE, DT_MATRÍC, MARKETING, EMAIL) VALUES (@NOME , @DT_NASC, @SEXO, @RG, @CPF, @TELEFONE, @WHATSAPP, @ENDEREÇO, @NÚMERO, @BAIRRO, @UF, @CEP, @CIDADE, @DT_MATRÍC, @MARKETING, @EMAIL) SELECT SCOPE_IDENTITY()";
        public string strInserçãoPagamento = "INSERT INTO Pagamento (DT_PAG, DT_VENC, PRÓX_PAG, VALOR, PLANO, STATUS, ID_NOVOALUNO) VALUES (@DT_PAG, @DT_VENC, @PRÓX_PAG, @VALOR, @PLANO, @STATUS, @ID_NOVOALUNO)";
        Conexão conectar = new Conexão();
        public void InserindoNovoAluno(string txtbox_nome, string msktbox_dtNascimento, string cmbbox_sexo, string msktbox_rg, string mstkbox_cpf, string msktbox_telefone, string Whatsapp, string txtbox_endereco, string txtbox_numero, string txtbox_bairro, string cmbbox_uf, string msktbox_cep, string cmbbox_cidade, string msktbox_dtMatricula, string cmbbox_marketing, string txtbox_email)
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strInserçãoNovoAluno, conectar.con);

                objComando.Parameters.Add(new SqlParameter("@NOME", txtbox_nome.ToUpper()));
                objComando.Parameters.Add(new SqlParameter("@DT_NASC", DateTime.Parse(msktbox_dtNascimento)));
                objComando.Parameters.Add(new SqlParameter("@SEXO", cmbbox_sexo));
                objComando.Parameters.Add(new SqlParameter("@RG", msktbox_rg));
                objComando.Parameters.Add(new SqlParameter("@CPF", mstkbox_cpf));
                objComando.Parameters.Add(new SqlParameter("@TELEFONE", msktbox_telefone));
                objComando.Parameters.Add(new SqlParameter("@WHATSAPP", Whatsapp));
                objComando.Parameters.Add(new SqlParameter("@ENDEREÇO", txtbox_endereco.ToUpper()));
                objComando.Parameters.Add(new SqlParameter("@NÚMERO", txtbox_numero));
                objComando.Parameters.Add(new SqlParameter("@BAIRRO", txtbox_bairro.ToUpper()));
                objComando.Parameters.Add(new SqlParameter("@UF", cmbbox_uf));
                objComando.Parameters.Add(new SqlParameter("@CEP", msktbox_cep));
                objComando.Parameters.Add(new SqlParameter("@CIDADE", cmbbox_cidade.ToUpper()));
                objComando.Parameters.Add(new SqlParameter("@DT_MATRÍC", Convert.ToDateTime(msktbox_dtMatricula)));
                objComando.Parameters.Add(new SqlParameter("@MARKETING", cmbbox_marketing));
                objComando.Parameters.Add(new SqlParameter("@EMAIL", txtbox_email));
                IdRetorno = Convert.ToInt32(objComando.ExecuteScalar());
                MessageBox.Show("Cadastro realizado com sucesso", "OPERAÇÃO BEM-SUCEDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                if(erro.Message.Contains("UNIQUE"))
                {
                    MessageBox.Show("Esse CPF ou RG já está cadastrado no sistema", "ESSE ALUNO JÁ ESTÁ CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Erro ao cadastrar - Business/SqlComandos/Cadastrar/CD_NovoAluno - InserindoNovoAluno()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void InserindoPagamento(SqlDateTime DataPagamento, string valor, string plano, string status)
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strInserçãoPagamento, conectar.con);

                objComando.Parameters.Add(new SqlParameter("@DT_PAG", DataPagamento));
                objComando.Parameters.Add(new SqlParameter("@DT_VENC", DateTime.Now.ToShortDateString()));
                objComando.Parameters.Add(new SqlParameter("@PRÓX_PAG", DateTime.Now.AddDays(30).ToShortDateString()));
                objComando.Parameters.Add(new SqlParameter("@VALOR", valor));
                objComando.Parameters.Add(new SqlParameter("@PLANO", plano));
                objComando.Parameters.Add(new SqlParameter("@STATUS", status));
                objComando.Parameters.Add(new SqlParameter("@ID_NOVOALUNO", IdRetorno));
                objComando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {            
                if(erro.Message.Contains("FOREIGN KEY"))
                {
                    
                }
                else
                    MessageBox.Show("Erro ao cadastrar pagamento - Business/SqlComandos/Cadastrar/CD_NovoAluno - InserindoPagamento()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void InserindoFrequencia(int id, string statusFrequencia)
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strInserçãoFrequencia, conectar.con);

                objComando.Parameters.Add(new SqlParameter("@ID_NOVOALUNO", id));
                objComando.Parameters.Add(new SqlParameter("@FREQUENCIA", statusFrequencia));

                objComando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
               MessageBox.Show("Erro ao cadastrar Frequência - Business/SqlComandos/Cadastrar/CD_NovoAluno - InserindoFrequencia()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
