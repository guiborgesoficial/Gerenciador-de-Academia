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
    public class CD_PesoAluno
    {
        public string strInserção = "INSERT INTO Peso (DT_COLETA, PESO, ID_NOVOALUNO)  VALUES (@DT_COLETA, @PESO, @ID_NOVOALUNO)";
        Conexão conectar = new Conexão();
        public void CadastroPesoAluno(string dtColeta, string Peso, string IMC, int id)
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strInserção, conectar.con);

                objComando.Parameters.Add(new SqlParameter("@DT_COLETA", Convert.ToDateTime(dtColeta).ToShortDateString()));
                objComando.Parameters.Add(new SqlParameter("@PESO", decimal.Parse(Peso)));
                objComando.Parameters.Add(new SqlParameter("@ID_NOVOALUNO", id));
                objComando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar - Business/SqlComandos/Cadastrar/CD_PesoAluno - CadastroPesoAluno()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
