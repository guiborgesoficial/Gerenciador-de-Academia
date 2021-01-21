using System;
using DataBase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Business.SqlComandos.Consultar
{
    public class CS_ChtAlunosMatriculados
    {
        public string QuantidadeMatriculadosMasculinos { get; set; }
        public string QuantidadeMatriculadosFemininos { get; set; }
        public string QuantidadeMatriculadosOutros { get; set; }
        Conexão conectar = new Conexão();
    
        string strConsultaMasculinos = "Select Count(*) SEXO from NovoAluno Where SEXO = 'M'";
        string strConsultaFemininos = "Select Count(*) SEXO from NovoAluno Where SEXO = 'F'";
        string strConsultaOutros = "Select Count(*) SEXO from NovoAluno Where SEXO != 'M' AND SEXO != 'F'";
        public void ConsultandoAlunosMatriculadosChtMasculinos()
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComamando = new SqlCommand(strConsultaMasculinos, conectar.con);
                objComamando.ExecuteNonQuery();
                SqlDataReader leitor = objComamando.ExecuteReader();

                while (leitor.Read())
                {
                    QuantidadeMatriculadosMasculinos = leitor["SEXO"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar Alunos Matriculados - Business/SqlComandos/Consultar/Charts/CS_ChtAlunosMatriculados - ConsultandoAlunosMatriculadosChtMasculinos()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void ConsultandoAlunosMatriculadosChtFemininos()
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComamando = new SqlCommand(strConsultaFemininos, conectar.con);
                objComamando.ExecuteNonQuery();
                SqlDataReader leitor = objComamando.ExecuteReader();

                while (leitor.Read())
                {
                    QuantidadeMatriculadosFemininos = leitor["SEXO"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar Alunos Matriculados - Business/SqlComandos/Consultar/CS_ChtAlunosMatriculados - ConsultandoAlunosMatriculadosChtFemininos()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void ConsultandoAlunosMatriculadosChtOutros()
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComamando = new SqlCommand(strConsultaOutros, conectar.con);
                objComamando.ExecuteNonQuery();
                SqlDataReader leitor = objComamando.ExecuteReader();

                while (leitor.Read())
                {
                    QuantidadeMatriculadosOutros = leitor["SEXO"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar Alunos Matriculados - Business/SqlComandos/Consultar/CS_ChtAlunosMatriculados - ConsultandoAlunosMatriculadosChtOutros()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
