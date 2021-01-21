using System;
using DataBase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Business.SqlComandos.Excluir
{
    public class DL_Matriculados
    {
        Conexão conectar = new Conexão();
        public string strDeletar = "DELETE FROM MedidasAluno WHERE MedidasAluno.ID_NOVOALUNO = @ID DELETE FROM Pagamento WHERE Pagamento.ID_NOVOALUNO = @ID DELETE FROM FichaDeTreino WHERE FichaDeTreino.ID_NOVOALUNO = @ID DELETE FROM Peso WHERE Peso.ID_NOVOALUNO = @ID DELETE FROM NovoAluno WHERE NovoAluno.IDNOVOALUNO = @ID";
        public void DeletarMatriculados(int lbl_ID)
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strDeletar, conectar.con);
                objComando.Parameters.Add(new SqlParameter("@ID", lbl_ID));
                objComando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao deletar - Business/SqlComandos/Excluir/DL_Matriculados - DeletarMatriculados()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
