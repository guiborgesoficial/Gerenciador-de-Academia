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
    public class CS_PesoAluno
    {
        public string PESOALUNO { get; set; }
        Conexão conectar = new Conexão();
        public void ConsultandoPesoAluno(int id)
        {
            string strConsultar = "SELECT * FROM Peso WHERE ID_NOVOALUNO = '"+ id +"'";

            try
            {
                conectar.AbrirConexão();

                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                objComando.ExecuteNonQuery();

                SqlDataReader leitor = objComando.ExecuteReader();
                while (leitor.Read())
                {
                    PESOALUNO = leitor["PESO"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar - Business/SqlComandos/Consultar/CS_PesoAluno - ConsultandoPesoAluno()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
