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
    public class CD_MedidasAluno
    {
        public string strInserção = "INSERT INTO MedidasAluno (ALTURA, TÓRAX, ABDÔMEN, CINTURA, QUADRIL, BRAÇO_DIREITO, BRAÇO_ESQUERDO, ANTEBRAÇO_DIREITO, ANTEBRAÇO_ESQUERDO, COXA_DIREITA_P, COXA_DIREITA_M, COXA_DIREITA_D, COXA_ESQUERDA_P,COXA_ESQUERDA_M, COXA_ESQUERDA_D,PERNA_DIREITA, PERNA_ESQUERDA, OMBROS, PESCOÇO, PUNHO, JOELHO, TORNOZELO, DT_COLETA, ID_NOVOALUNO) VALUES (@ALTURA, @TÓRAX, @ABDÔMEN, @CINTURA, @QUADRIL, @BRAÇO_DIREITO, @BRAÇO_ESQUERDO, @ANTEBRAÇO_DIREITO, @ANTEBRAÇO_ESQUERDO, @COXA_DIREITA_P, @COXA_DIREITA_M, @COXA_DIREITA_D, @COXA_ESQUERDA_P, @COXA_ESQUERDA_M, @COXA_ESQUERDA_D, @PERNA_DIREITA, @PERNA_ESQUERDA, @OMBROS, @PESCOÇO, @PUNHO, @JOELHO, @TORNOZELO, @DT_COLETA, @ID_NOVOALUNO)";
        Conexão conectar = new Conexão();
        public void InserindoMedidasAluno(int ID, string altura, string tórax, string abdomen, string cintura, string quadril, string bracoD, string bracoE, string antebD, string antebE, string coxadP, string coxadM, string coxadD, string coxaeP, string coxaeM, string coxaeD, string pernaD, string pernaE, string ombro, string pescoço, string punho, string joelho, string tornozelo)
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strInserção, conectar.con);
                
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
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            catch (Exception erro)
            {
               MessageBox.Show("Erro ao cadastrar - Business/SqlComandos/Cadastrar/CD_MedidasAluno - InserindoMedidasAluno()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
