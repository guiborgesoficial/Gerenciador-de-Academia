using System;
using DataBase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Business.SqlComandos.Consultar.Charts
{
    public class CS_ChtInadimplentes
    {
        public string QuantidadeInadimplentesMasculinos { get; set; }
        public string QuantidadeInadimplentesFemininos { get; set; }
        public string QuantidadeInadimplentesOutros { get; set; }
        Conexão conectar = new Conexão();
        public void ConsultandoChtInadimplentesMasculino()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultaM = "SELECT COUNT(SEXO) AS InadimplenteMasculino FROM Pagamento INNER JOIN NovoAluno ON ID_NOVOALUNO = IDNOVOALUNO WHERE DT_VENC <= '"+ DateTime.Now.ToShortDateString() +"' AND DT_PAG IS NULL AND SEXO = 'M'";
                SqlCommand objComandoM = new SqlCommand(strConsultaM, conectar.con);
                objComandoM.ExecuteNonQuery();
                SqlDataReader leitorM = objComandoM.ExecuteReader();
                
                while(leitorM.Read())
                {
                    QuantidadeInadimplentesMasculinos = leitorM["InadimplenteMasculino"].ToString();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao consultar gráfico - Business/SqlComandos/Consultar/Charts/CS_ChtInadimplentes - ConsultandoChtInadimplentesMasculino()" + erro, "Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void ConsultandoChtInadimplentesFeminino()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultaF = "SELECT COUNT(SEXO) AS InadimplenteFeminino FROM Pagamento INNER JOIN NovoAluno ON ID_NOVOALUNO = IDNOVOALUNO WHERE DT_VENC <= '" + DateTime.Now.ToShortDateString() + "' AND DT_PAG IS NULL AND SEXO = 'F'";
                SqlCommand objComandoF = new SqlCommand(strConsultaF, conectar.con);
                objComandoF.ExecuteNonQuery();
                SqlDataReader leitorF = objComandoF.ExecuteReader();

                while (leitorF.Read())
                {
                    QuantidadeInadimplentesFemininos = leitorF["InadimplenteFeminino"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar gráfico - Business/SqlComandos/Consultar/Charts/CS_ChtInadimplentes - ConsultandoChtInadimplentesFeminino()" + erro, "Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void ConsultandoChtInadimplentesOutros()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultaO = "SELECT COUNT(SEXO) AS InadimplenteOutros FROM Pagamento INNER JOIN NovoAluno ON ID_NOVOALUNO = IDNOVOALUNO WHERE DT_VENC <= '" + DateTime.Now.ToShortDateString() + "' AND DT_PAG IS NULL AND SEXO = 'O'";
                SqlCommand objComandoO = new SqlCommand(strConsultaO, conectar.con);
                objComandoO.ExecuteNonQuery();
                SqlDataReader leitorO = objComandoO.ExecuteReader();

                while (leitorO.Read())
                {
                    QuantidadeInadimplentesOutros = leitorO["InadimplenteOutros"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar gráfico - Business/SqlComandos/Consultar/Charts/CS_ChtInadimplentes - ConsultandoChtInadimplentesOutros()" + erro, "Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
