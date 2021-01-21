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
    public class CS_Matriculados
    {
        public int IDNOVOALUNO { get; set; }
        public string NOME { get; set; }
        public DateTime DT_MATRÍC { get; set; }

        Conexão conectar = new Conexão();
        public List<string> tabela = new List<string>();
        public void ConsultaParaComboBox()
        {
            try
            {
                string strConsultar = "SELECT NOME FROM NovoAluno";
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                SqlDataReader leitor = objComando.ExecuteReader();

                while (leitor.Read())
                {
                    tabela.Add(leitor["NOME"].ToString());
                }
            }
            catch (Exception erro) 
            {
                MessageBox.Show("Erro ao Consultar - Business/SqlComandos/Consultar/CS_Matriculados - ConsultaParaComboBox()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }

        public void ConsultadoMatriculados(string NomeAluno)
        {
            try
            {
                string strConsultar = "SELECT IDNOVOALUNO, NOME, DT_MATRÍC FROM NovoAluno WHERE NOME = '"+ NomeAluno +"'";
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                SqlDataReader leitor = objComando.ExecuteReader();

                while(leitor.Read())
                {
                    IDNOVOALUNO = int.Parse(leitor["IDNOVOALUNO"].ToString());
                    NOME = leitor["NOME"].ToString();
                    DT_MATRÍC = Convert.ToDateTime(leitor["DT_MATRÍC"].ToString());
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao consultar - Business/SqlComandos/Consultar/CS_Matriculados - ConsultandoMatriculados()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
