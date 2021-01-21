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
    public class CS_ChtAdimplentes
    {
        public string QuantidadeAdimplentesMasculinos { get; set; }
        public string QuantidadeAdimplentesFemininos { get; set; }
        public string QuantidadeAdimplentesOutros { get; set; }
        Conexão conectar = new Conexão();
        public void ConsultandoChtAdimplentesMasculinos()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultaM = "SELECT COUNT(SEXO) AS AdimplenteMasculino FROM Pagamento INNER JOIN NovoAluno ON ID_NOVOALUNO = IDNOVOALUNO WHERE DT_VENC <= '"+DateTime.Now.ToShortDateString()+"' AND DT_PAG IS NOT NULL AND SEXO = 'M'";
                SqlCommand objComandoM = new SqlCommand(strConsultaM, conectar.con);
                objComandoM.ExecuteNonQuery();

                SqlDataReader leitorM = objComandoM.ExecuteReader();
                while(leitorM.Read())
                {
                    QuantidadeAdimplentesMasculinos = leitorM["AdimplenteMasculino"].ToString();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao consultar gráfico - Business/SqlComandos/Consultar/Chats/CS_ChtAdimplentes - ConsultandoChtAdimplentesMasculinos()" + erro, "Erro em consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void ConsultandoChtAdimplentesFemininos()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultaF = "SELECT COUNT(SEXO) AS AdimplenteFeminino FROM Pagamento INNER JOIN NovoAluno ON ID_NOVOALUNO = IDNOVOALUNO WHERE DT_VENC <= '" + DateTime.Now.ToShortDateString() + "' AND DT_PAG IS NOT NULL AND SEXO = 'F'";
                SqlCommand objComandoF = new SqlCommand(strConsultaF, conectar.con);
                objComandoF.ExecuteNonQuery();

                SqlDataReader leitorF = objComandoF.ExecuteReader();
                while (leitorF.Read())
                {
                    QuantidadeAdimplentesFemininos = leitorF["AdimplenteFeminino"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar gráfico - Business/SqlComandos/Consultar/Chats/CS_ChtAdimplentes - ConsultandoChtAdimplentesFemininos()" + erro, "Erro em consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void ConsultandoChtAdimplenteOutros()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultaO = "SELECT COUNT(SEXO) AS AdimplenteOutros FROM Pagamento INNER JOIN NovoAluno ON ID_NOVOALUNO = IDNOVOALUNO WHERE DT_VENC <= '" + DateTime.Now.ToShortDateString() + "' AND DT_PAG IS NOT NULL AND SEXO = 'O'";
                SqlCommand objComandoO = new SqlCommand(strConsultaO, conectar.con);
                objComandoO.ExecuteNonQuery();

                SqlDataReader leitorO = objComandoO.ExecuteReader();
                while (leitorO.Read())
                {
                    QuantidadeAdimplentesOutros = leitorO["AdimplenteOutros"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar gráfico - Business/SqlComandos/Consultar/Chats/CS_ChtAdimplentes - ConsultandoChtAdimplentesOutros()" + erro, "Erro em consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
