using System;
using DataBase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.SqlComandos.Consultar
{
    public class CS_NovoAluno
    {
        public int IDNOVOALUNO { get; set; }
        public string NOME { get; set; }
        public DateTime DT_NASC { get; set; }
        public string SEXO { get; set; }
        public string RG{ get; set; }
        public string CPF { get; set; }
        public string TELEFONE { get; set; }
        public string WHATSAPP { get; set; }
        public string ENDEREÇO { get; set; }
        public string NÚMERO { get; set; }
        public string BAIRRO { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string CIDADE { get; set; }
        public DateTime DT_MATRÍC { get; set; }
        public string MARKETING { get; set; }
        public string PLANO { get; set; }
        public string VALOR { get; set; }
        public string EMAIL { get; set; }
        Conexão conectar = new Conexão();
        public void ConsultandoNovoAluno(string msktbox_rg, string mstkbox_cpf)
        {
            string strConsultar = "SELECT * FROM NovoAluno WHERE RG = '"+ msktbox_rg +"' OR CPF = '"+ mstkbox_cpf +"'";

            try
            {
                conectar.AbrirConexão();

                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                objComando.ExecuteNonQuery();

                SqlDataReader leitor = objComando.ExecuteReader();
                while(leitor.Read())
                {
                    IDNOVOALUNO = int.Parse(leitor["IDNOVOALUNO"].ToString());
                    NOME = leitor["NOME"].ToString();
                    DT_NASC = Convert.ToDateTime(leitor["DT_NASC"].ToString());
                    SEXO = leitor["SEXO"].ToString();
                    RG = leitor["RG"].ToString();
                    CPF = leitor["CPF"].ToString();
                    TELEFONE = leitor["TELEFONE"].ToString();
                    WHATSAPP = leitor["WHATSAPP"].ToString();
                    ENDEREÇO = leitor["ENDEREÇO"].ToString();
                    NÚMERO = leitor["NÚMERO"].ToString();
                    BAIRRO = leitor["BAIRRO"].ToString();
                    UF = leitor["UF"].ToString();
                    CEP = leitor["CEP"].ToString();
                    CIDADE = leitor["CIDADE"].ToString();
                    DT_MATRÍC = Convert.ToDateTime(leitor["DT_MATRÍC"].ToString());
                    MARKETING = leitor["MARKETING"].ToString();
                    EMAIL = leitor["EMAIL"].ToString();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao consultar - Business/SqlComandos/Consultar/CS_NovoAluno - ConsultandoNovoAluno()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
            ConsultandoPagamento();
        }
        public void ConsultandoPagamento()
        {
            string strConsultar = "SELECT * FROM Pagamento WHERE ID_NOVOALUNO = '" + IDNOVOALUNO + "'";
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                objComando.ExecuteNonQuery();

                SqlDataReader leitor = objComando.ExecuteReader();
                while (leitor.Read())
                {
                    VALOR = leitor["VALOR"].ToString();
                    PLANO = leitor["PLANO"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar - Business/SqlComandos/Consultar/CS_NovoAluno - ConsultandoPagamento()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
