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
    public class CS_ChtVencimentoHoje
    {
        public string QuantidadeVencimentoMasculino { get; set; }
        public string QuantidadeVencimentoFeminino { get; set; }
        public string QuantidadeVencimentoOutros { get; set; }
        Conexão conectar = new Conexão();
        public void ConsultandoChtVencimentoMasculino()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultaM = "SELECT COUNT(SEXO) AS VencimentoMasculino FROM Pagamento INNER JOIN NovoAluno ON ID_NOVOALUNO = IDNOVOALUNO WHERE DT_VENC = '" + DateTime.Now.ToShortDateString()+"' AND DT_PAG IS NULL AND SEXO = 'M'";
                SqlCommand objComandoM = new SqlCommand(strConsultaM, conectar.con);
                objComandoM.ExecuteNonQuery();
                SqlDataReader leitorM = objComandoM.ExecuteReader();

                while(leitorM.Read())
                {
                    QuantidadeVencimentoMasculino = leitorM["VencimentoMasculino"].ToString();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao consultar gráfico - Business/SqlComandos/Consultar/Charts/CS_ChtVencimentoHoje - ConsultandoChtVencimentoMasculino()" + erro, "Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void ConsultandoChtVencimentoFeminino()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultaF = "SELECT COUNT(SEXO) AS VecimentoFeminino FROM Pagamento INNER JOIN NovoAluno ON ID_NOVOALUNO = IDNOVOALUNO WHERE DT_VENC = '" + DateTime.Now.ToShortDateString() + "' AND DT_PAG IS NULL AND SEXO = 'F'";
                SqlCommand objComandoF = new SqlCommand(strConsultaF, conectar.con);
                objComandoF.ExecuteNonQuery();
                SqlDataReader leitorF = objComandoF.ExecuteReader();

                while (leitorF.Read())
                {
                    QuantidadeVencimentoFeminino = leitorF["VecimentoFeminino"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar gráfico - Business/SqlComandos/Consultar/Charts/CS_ChtVencimentoHoje - ConsultandoChtVencimentoFeminino()" + erro, "Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void ConsultandoChtVencimentoOutros()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultaO = "SELECT COUNT(SEXO) AS VecimentoOutros FROM Pagamento INNER JOIN NovoAluno ON ID_NOVOALUNO = IDNOVOALUNO WHERE DT_VENC = '" + DateTime.Now.ToShortDateString() + "' AND DT_PAG IS NULL AND SEXO = 'O'";
                SqlCommand objComandoO = new SqlCommand(strConsultaO, conectar.con);
                objComandoO.ExecuteNonQuery();
                SqlDataReader leitorO = objComandoO.ExecuteReader();

                while (leitorO.Read())
                {
                    QuantidadeVencimentoOutros = leitorO["VecimentoOutros"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar gráfico - Business/SqlComandos/Consultar/Charts/CS_ChtVencimentoHoje - ConsultandoChtVencimentoOutros()" + erro, "Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
