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
    public class CS_MedidasAluno
    {
        public string ALTURA { get; set;}
        public string TÓRAX { get; set; }
        public string ABDÔMEN { get; set; }
        public string CINTURA { get; set; }
        public string QUADRIL { get; set; }
        public string BRAÇO_D { get; set; }
        public string BRAÇO_E { get; set; }
        public string ANTEB_D { get; set; }
        public string ANTEB_E { get; set; }
        public string COXAD_P { get; set; }
        public string COXAD_M { get; set; }
        public string COXAD_D { get; set; }
        public string COXAE_P { get; set; }
        public string COXAE_M { get; set; }
        public string COXAE_D { get; set; }
        public string PERNA_D { get; set; }
        public string PERNA_E { get; set; }
        public string OMBROS { get; set; }
        public string PESCOÇO { get; set; }
        public string PUNHO { get; set; }
        public string JOELHO { get; set; }
        public string TORNOZELO { get; set; }
        public string DT_COLETA { get; set; }
        public string IDMEDIDASALUNO { get; set; }
        Conexão conectar = new Conexão();
        public void ConsultandoMedidasAluno(int ID)
        { 
            string strConsultar = "SELECT TOP(1) * FROM MedidasAluno where ID_NOVOALUNO = '" + ID + "'" + "Order By DT_COLETA DESC";

            try
            {
                conectar.AbrirConexão();

                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                objComando.ExecuteNonQuery();

                SqlDataReader leitor = objComando.ExecuteReader();
                while (leitor.Read())
                {
                    ALTURA = leitor["ALTURA"].ToString();
                    TÓRAX = leitor["TÓRAX"].ToString();
                    ABDÔMEN = leitor["ABDÔMEN"].ToString();
                    CINTURA = leitor["CINTURA"].ToString();
                    QUADRIL = leitor["QUADRIL"].ToString();
                    BRAÇO_D = leitor["BRAÇO_DIREITO"].ToString();
                    BRAÇO_E = leitor["BRAÇO_ESQUERDO"].ToString();
                    ANTEB_D = leitor["ANTEBRAÇO_DIREITO"].ToString();
                    ANTEB_E = leitor["ANTEBRAÇO_ESQUERDO"].ToString();
                    COXAD_P = leitor["COXA_DIREITA_P"].ToString();
                    COXAD_M = leitor["COXA_DIREITA_M"].ToString();
                    COXAD_D = leitor["COXA_DIREITA_D"].ToString();
                    COXAE_P = leitor["COXA_ESQUERDA_P"].ToString();
                    COXAE_M = leitor["COXA_ESQUERDA_M"].ToString();
                    COXAE_D = leitor["COXA_ESQUERDA_D"].ToString();
                    PERNA_D = leitor["PERNA_DIREITA"].ToString();
                    PERNA_E = leitor["PERNA_ESQUERDA"].ToString();
                    OMBROS = leitor["OMBROS"].ToString();
                    PESCOÇO = leitor["PESCOÇO"].ToString();
                    PUNHO = leitor["PUNHO"].ToString();
                    JOELHO = leitor["JOELHO"].ToString();
                    TORNOZELO = leitor["TORNOZELO"].ToString();
                    DT_COLETA = leitor["DT_COLETA"].ToString();
                    IDMEDIDASALUNO = leitor["IDMEDIDASALUNO"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar - Business/SqlComandos/Consultar/CS_MedidasAluno" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
