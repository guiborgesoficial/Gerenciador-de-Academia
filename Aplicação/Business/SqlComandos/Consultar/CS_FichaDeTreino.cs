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
    public class CS_FichaDeTreino
    {
        public DateTime DT_COLETA { get; set; }
        public string A_MUSC { get; set; }
        public string A_DIA { get; set; }
        public string B_MUSC { get; set; }
        public string B_DIA { get; set; }
        public string C_MUSC { get; set; }
        public string C_DIA { get; set; }
        public string D_MUSC { get; set; }
        public string D_DIA { get; set; }
        public string E_MUSC { get; set; }
        public string E_DIA { get; set; }
        Conexão conectar = new Conexão();
        public bool verificadorExisteDados = false; 
        public void ConsultandoFichaDeTreino(string ID)
        {   
            string strConsultar = "SELECT * FROM FichaDeTreino WHERE ID_NOVOALUNO = '" + int.Parse(ID) + "'";
            try
            {
                conectar.AbrirConexão();

                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                objComando.ExecuteNonQuery();

                SqlDataReader leitor = objComando.ExecuteReader();
                if(leitor.HasRows)
                {
                    verificadorExisteDados = true;
                    while (leitor.Read())
                    {
                        DT_COLETA = Convert.ToDateTime(leitor["DT_COLETA"]);
                        A_MUSC = leitor["A_MUSC"].ToString();
                        A_DIA = leitor["A_DIA"].ToString();
                        B_MUSC = leitor["B_MUSC"].ToString();
                        B_DIA = leitor["B_DIA"].ToString();
                        C_MUSC = leitor["C_MUSC"].ToString();
                        C_DIA = leitor["C_DIA"].ToString();
                        D_MUSC = leitor["D_MUSC"].ToString();
                        D_DIA = leitor["D_DIA"].ToString();
                        E_MUSC = leitor["E_MUSC"].ToString();
                        E_DIA = leitor["E_DIA"].ToString();
                    }
                }
                else
                {
                    verificadorExisteDados = false;
                }
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar - Business/SqlComandos/Consultar/CS_FichaDeTreino - ConsultandoFichaDeTreino()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
