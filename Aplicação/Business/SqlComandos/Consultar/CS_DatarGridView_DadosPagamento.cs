using System;
using DataBase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.SqlComandos.Consultar
{
    public class CS_DatarGridView_DadosPagamento
    {
        Conexão conectar = new Conexão();
        public void ConsultandoDadosPagamento(int ID, DataGridView dataGridView)
        {
            string strConsultar = "SELECT * FROM PAGAMENTO WHERE ID_NOVOALUNO = '" + ID + "'";

            try
            {
                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(objComando);
                DataTable dadosPagamento = new DataTable();
                dataAdapter.Fill(dadosPagamento);
                dataGridView.DataSource = dadosPagamento;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao consultar dados do pagamento - Business/Consultar/CS_DataGridView_DadosPagamento - ConsultandoDadosPagamento()" + erro, "ERRO AO CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
