using System;
using DataBase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.SqlComandos.Atualizar
{
    public class UP_FichaTreino
    {
        public string strAtualizar = "UPDATE FichaDeTreino SET DT_COLETA = @DT_COLETA, A_MUSC = @A_MUSC, A_DIA = @A_DIA, B_MUSC = @B_MUSC, B_DIA = @B_DIA, C_MUSC = @C_MUSC, C_DIA = @C_DIA, D_MUSC = @D_MUSC, D_DIA = @D_DIA, E_MUSC = @E_MUSC, E_DIA = @E_DIA WHERE ID_NOVOALUNO = @IDNOVOALUNO";
        Conexão conectar = new Conexão();
        public void AtualizarFichaTreino(string A_MUSC, string A_DIA, string B_MUSC, string B_DIA, string C_MUSC, string C_DIA, string D_MUSC, string D_DIA, string E_MUSC, string E_DIA, string id)
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strAtualizar, conectar.con);
                objComando.Parameters.Add(new SqlParameter("@DT_COLETA", DateTime.Now.ToShortDateString()));
                objComando.Parameters.Add(new SqlParameter("@A_MUSC", A_MUSC));
                objComando.Parameters.Add(new SqlParameter("@A_DIA", A_DIA));
                objComando.Parameters.Add(new SqlParameter("@B_MUSC", B_MUSC));
                objComando.Parameters.Add(new SqlParameter("@B_DIA", B_DIA));
                objComando.Parameters.Add(new SqlParameter("@C_MUSC", C_MUSC));
                objComando.Parameters.Add(new SqlParameter("@C_DIA", C_DIA));
                objComando.Parameters.Add(new SqlParameter("@D_MUSC", D_MUSC));
                objComando.Parameters.Add(new SqlParameter("@D_DIA", D_DIA));
                objComando.Parameters.Add(new SqlParameter("@E_MUSC", E_MUSC));
                objComando.Parameters.Add(new SqlParameter("@E_DIA", E_DIA));
                objComando.Parameters.Add(new SqlParameter("@IDNOVOALUNO", id));
                objComando.ExecuteNonQuery();
                MessageBox.Show("Atualizado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar - Business/SqlComandos/Atualizar/UP_FichaTreino - AtualizarFichaTreino" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
