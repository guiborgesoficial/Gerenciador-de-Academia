using System;
using DataBase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.SqlComandos.Cadastrar
{
    public class CD_FichaDeTreino
    {
        public string strInserção = "INSERT INTO FichaDeTreino (DT_COLETA, A_MUSC, A_DIA, B_MUSC, B_DIA, C_MUSC, C_DIA, D_MUSC, D_DIA, E_MUSC, E_DIA, ID_NOVOALUNO) VALUES (@DT_COLETA, @A_MUSC, @A_DIA, @B_MUSC, @B_DIA, @C_MUSC, @C_DIA, @D_MUSC, @D_DIA, @E_MUSC, @E_DIA, @ID_NOVOALUNO)";
        Conexão conectar = new Conexão();
        public void InserindoFichaDeTreino(string A_MUSC, string A_DIA, string B_MUSC, string B_DIA, string C_MUSC, string C_DIA, string D_MUSC, string D_DIA, string E_MUSC, string E_DIA, string id)
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strInserção, conectar.con);

                objComando.Parameters.Add(new SqlParameter("@DT_COLETA", DateTime.Now.ToShortDateString()));
                objComando.Parameters.Add(new SqlParameter("@A_MUSC", A_MUSC.ToString()));
                objComando.Parameters.Add(new SqlParameter("@A_DIA", A_DIA.ToString()));
                objComando.Parameters.Add(new SqlParameter("@B_MUSC", B_MUSC.ToString()));
                objComando.Parameters.Add(new SqlParameter("@B_DIA", B_DIA.ToString()));
                objComando.Parameters.Add(new SqlParameter("@C_MUSC", C_MUSC.ToString()));
                objComando.Parameters.Add(new SqlParameter("@C_DIA", C_DIA.ToString()));
                objComando.Parameters.Add(new SqlParameter("@D_MUSC", D_MUSC.ToString()));
                objComando.Parameters.Add(new SqlParameter("@D_DIA", D_DIA.ToString()));
                objComando.Parameters.Add(new SqlParameter("@E_MUSC", E_MUSC.ToString()));
                objComando.Parameters.Add(new SqlParameter("@E_DIA", E_DIA.ToString()));
                objComando.Parameters.Add(new SqlParameter("@ID_NOVOALUNO", int.Parse(id)));
                objComando.ExecuteNonQuery();
                MessageBox.Show("Cadastrado com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar - Business/SqlComandos/Cadastrar/CD_FichaDeTreino - InserindoFichaDeTreino()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
