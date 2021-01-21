using System;
using DataBase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.SqlComandos.Atualizar
{
    public class UP_NovoAluno
    {
        public string strAtualizar = "UPDATE NovoAluno SET NOME = @NOME, DT_NASC = @DT_NASC, SEXO = @SEXO, RG = @RG, CPF = @CPF, TELEFONE = @TELEFONE, WHATSAPP = @WHATSAPP, ENDEREÇO = @ENDEREÇO, NÚMERO = @NÚMERO, BAIRRO = @BAIRRO, UF = @UF, CEP = @CEP, CIDADE = @CIDADE, DT_MATRÍC = @DT_MATRÍC, MARKETING = @MARKETING WHERE IDNOVOALUNO = @IDNOVOALUNO";
        Conexão conectar = new Conexão();
        public void AtualizandoNovoAluno(string lbl_id, string txtbox_nome, string msktbox_dtNascimento, string cmbbox_sexo, string msktbox_rg, string mstkbox_cpf, string msktbox_telefone, string Whatsapp, string txtbox_endereco, string txtbox_numero, string txtbox_bairro, string cmbbox_uf, string msktbox_cep, string cmbbox_cidade, string msktbox_dtMatricula, string cmbbox_marketing)
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strAtualizar, conectar.con);
                objComando.Parameters.Add(new SqlParameter("@IDNOVOALUNO", lbl_id));
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
                objComando.ExecuteNonQuery();
                MessageBox.Show("Atualizado com sucesso", "OPERAÇÃO BEM-SUCEDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar - Business/SqlComandos/Atualizar/UP_NovoAluno - AtualizandoNovoAluno()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
