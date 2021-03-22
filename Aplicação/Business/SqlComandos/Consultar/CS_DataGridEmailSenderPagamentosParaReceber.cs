using DataBase;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Business.SqlComandos.Consultar
{
    public class CS_DataGridEmailSenderPagamentosParaReceber
    {
        Conexão conectar = new Conexão();
        public string EMAIL { get; set; }

        public void ConsultandoPagamentosParaReceber(DataGridView dataGridView)
        {
            string strConsultar = "SELECT PagamentosParaReceber.IDPagamentosParaReceber, NovoAluno.NOME, PagamentosParaReceber.PLANO, " +
                "PagamentosParaReceber.VALOR, PagamentosParaReceber.DT_PAG, PagamentosParaReceber.STATUS, " +
                "PagamentosParaReceber.DT_VENC, PagamentosParaReceber.ID_NOVOALUNO, NovoAluno.EMAIL FROM NovoAluno, " +
                "PagamentosParaReceber WHERE NovoAluno.IDNOVOALUNO = PagamentosParaReceber.ID_NOVOALUNO";

            try
            {
                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(objComando);
                DataTable dadosInadimplente = new DataTable();
                dataAdapter.Fill(dadosInadimplente);
                dataGridView.DataSource = dadosInadimplente;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar pagamentos para receber - Business/SqlComandos/Consultar/CS_EmailSenderPagamentosParaReceber - ConsultandoPagamentosParaReceber()" + erro, "Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void ConsultadoEmailPorId(string id)
        {
            string strConsultar = "SELECT EMAIL FROM NovoAluno WHERE IDNOVOALUNO = '" + id + "'";

            try
            {
                conectar.AbrirConexão();

                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                objComando.ExecuteNonQuery();

                SqlDataReader leitor = objComando.ExecuteReader();
                while (leitor.Read())
                {
                    EMAIL = leitor["EMAIL"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar - Business/SqlComandos/Consultar/CS_NovoAluno - ConsultandoEmail()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
