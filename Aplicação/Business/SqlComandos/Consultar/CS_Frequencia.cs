using DataBase;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Business.SqlComandos.Consultar
{
    public class CS_Frequencia
    {
        public string StatusFrequencia { get; set; }
        Conexão conectar = new Conexão();
        public void ConsultandoFrequencia(int ID)
        {
            string strConsultar = "SELECT * FROM Frequencia WHERE ID_NOVOALUNO = '" + ID + "'";
            try
            {
                conectar.AbrirConexão();

                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                objComando.ExecuteNonQuery();

                SqlDataReader leitor = objComando.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        StatusFrequencia = leitor["FREQUENCIA"].ToString();
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar - Business/SqlComandos/Consultar/CS_Frequencia - ConsultandoFrequencia()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
