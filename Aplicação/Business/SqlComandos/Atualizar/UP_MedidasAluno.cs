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
    public class UP_MedidasAluno
    {
        public string strUpadate = "UPDATE MedidasAluno SET ALTURA = @ALTURA, TÓRAX = @TÓRAX, ABDÔMEN = @ABDÔMEN, CINTURA = @CINTURA, QUADRIL = @QUADRIL, BRAÇO_DIREITO = @BRAÇO_DIREITO, BRAÇO_ESQUERDO = @BRAÇO_ESQUERDO, ANTEBRAÇO_DIREITO = @ANTEBRAÇO_DIREITO, ANTEBRAÇO_ESQUERDO = @ANTEBRAÇO_ESQUERDO, COXA_DIREITA_P = @COXA_DIREITA_P, COXA_DIREITA_M = @COXA_DIREITA_M, COXA_DIREITA_D = @COXA_DIREITA_D, COXA_ESQUERDA_P = @COXA_ESQUERDA_P, COXA_ESQUERDA_M = @COXA_ESQUERDA_M, COXA_ESQUERDA_D = @COXA_ESQUERDA_D, PERNA_DIREITA = @PERNA_DIREITA, PERNA_ESQUERDA = @PERNA_ESQUERDA, OMBROS = @OMBROS, PESCOÇO = @PESCOÇO, PUNHO = @PUNHO, JOELHO = @JOELHO, TORNOZELO = @TORNOZELO, DT_COLETA = @DT_COLETA WHERE ID_NOVOALUNO = @ID_NOVOALUNO";
        Conexão conectar = new Conexão();
        public void AtualizarMedidasAluno(int ID, string altura, string tórax, string abdomen, string cintura, string quadril, string bracoD, string bracoE, string antebD, string antebE, string coxadP, string coxadM, string coxadD, string coxaeP, string coxaeM, string coxaeD, string pernaD, string pernaE, string ombro, string pescoço, string punho, string joelho, string tornozelo)
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strUpadate, conectar.con);

                objComando.Parameters.Add(new SqlParameter("@ALTURA", altura));
                objComando.Parameters.Add(new SqlParameter("@TÓRAX", tórax));
                objComando.Parameters.Add(new SqlParameter("@ABDÔMEN", abdomen));
                objComando.Parameters.Add(new SqlParameter("@CINTURA", cintura));
                objComando.Parameters.Add(new SqlParameter("@QUADRIL", quadril));
                objComando.Parameters.Add(new SqlParameter("@BRAÇO_DIREITO", bracoD));
                objComando.Parameters.Add(new SqlParameter("@BRAÇO_ESQUERDO", bracoE));
                objComando.Parameters.Add(new SqlParameter("@ANTEBRAÇO_DIREITO", antebD));
                objComando.Parameters.Add(new SqlParameter("@ANTEBRAÇO_ESQUERDO", antebE));
                objComando.Parameters.Add(new SqlParameter("@COXA_DIREITA_P", coxadP));
                objComando.Parameters.Add(new SqlParameter("@COXA_DIREITA_M", coxadM));
                objComando.Parameters.Add(new SqlParameter("@COXA_DIREITA_D", coxadD));
                objComando.Parameters.Add(new SqlParameter("@COXA_ESQUERDA_P", coxaeP));
                objComando.Parameters.Add(new SqlParameter("@COXA_ESQUERDA_M", coxaeM));
                objComando.Parameters.Add(new SqlParameter("@COXA_ESQUERDA_D", coxaeD));
                objComando.Parameters.Add(new SqlParameter("@PERNA_DIREITA", pernaD));
                objComando.Parameters.Add(new SqlParameter("@PERNA_ESQUERDA", pernaE));
                objComando.Parameters.Add(new SqlParameter("@OMBROS", ombro));
                objComando.Parameters.Add(new SqlParameter("@PESCOÇO", pescoço));
                objComando.Parameters.Add(new SqlParameter("@PUNHO", punho));
                objComando.Parameters.Add(new SqlParameter("@JOELHO", joelho));
                objComando.Parameters.Add(new SqlParameter("@TORNOZELO", tornozelo));
                objComando.Parameters.Add(new SqlParameter("@DT_COLETA", DateTime.Now.ToShortDateString()));
                objComando.Parameters.Add(new SqlParameter("@ID_NOVOALUNO", ID));
                objComando.ExecuteNonQuery();
                MessageBox.Show("Atualizado com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar - Business/SqlComandos/Atualizar/UP_MedidasAluno - AtualizarMedidasAluno()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
