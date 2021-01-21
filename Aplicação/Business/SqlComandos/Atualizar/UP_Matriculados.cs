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
    public class UP_Matriculados
    {
        public DateTime DT_VENC { get; set; }
        public int lbl_id2 { get; set; }

        public string strAtualizar = "UPDATE Pagamento SET DT_PAG = @DT_PAG, STATUS = @STATUS WHERE ID_NOVOALUNO = @IDNOVOALUNO";
        public string strInserir2 = "INSERT INTO Pagamento (DT_VENC, PRÓX_PAG, PLANO, VALOR, STATUS, ID_NOVOALUNO) VALUES (@DT_VENC, @DT_PRÓX, @PLANO, @VALOR, @STATUS, @IDNOVOALUNO)";
        Conexão conectar = new Conexão();
        public void AtualizarPagamento(int lbl_id)
        {
            try
            {
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strAtualizar, conectar.con);
                objComando.Parameters.Add(new SqlParameter("@DT_PAG", DateTime.Now.ToShortDateString()));
                objComando.Parameters.Add(new SqlParameter("@STATUS","PAGO"));
                objComando.Parameters.Add(new SqlParameter("@IDNOVOALUNO", lbl_id));
                lbl_id2 = lbl_id;
                objComando.ExecuteNonQuery();
                MessageBox.Show("Atualizado com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar - Business/SqlComandos/Atualizar/UP_Matriculados - AtualizarPagamento()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }

        public void InserindoNovaFaturaMatriculados(int lbl_id, string valor, string plano, string status)
        {
            lbl_id2 = lbl_id;
            ConsultandoDatas();
            int diasVencimento = 0;

            if (plano == "MENSAL")
                diasVencimento = 30;
            else if (plano == "TRIMESTRAL")
                diasVencimento = 90;
            else if (plano == "ANUAL")
                diasVencimento = 365;

            try
            {
                conectar.AbrirConexão();
                SqlCommand objComando = new SqlCommand(strInserir2, conectar.con);
                objComando.Parameters.Add(new SqlParameter("@IDNOVOALUNO", lbl_id));
                objComando.Parameters.Add(new SqlParameter("@PLANO", plano));
                objComando.Parameters.Add(new SqlParameter("@VALOR", valor));
                objComando.Parameters.Add(new SqlParameter("@STATUS", status));
                objComando.Parameters.Add(new SqlParameter("@DT_VENC", DT_VENC.AddDays(diasVencimento).ToShortDateString()));
                objComando.Parameters.Add(new SqlParameter("@DT_PRÓX", DT_VENC.AddDays(diasVencimento * 2).ToShortDateString()));
                objComando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar Nova Fatura - BLL/SqlComandos/Atualizar/UP_Matriculados - InserindoNovaFaturaMatriculados()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void ConsultandoDatas()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultar = "SELECT DT_VENC FROM Pagamento WHERE ID_NOVOALUNO = @ID";
                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                objComando.Parameters.Add(new SqlParameter("@ID", lbl_id2));
                objComando.ExecuteNonQuery();
                SqlDataReader leitor = objComando.ExecuteReader();     
                
                while(leitor.Read())
                {
                    DT_VENC = Convert.ToDateTime(leitor["DT_VENC"].ToString());
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Consultar Datas - BLL/SqlComandos/Atualizar/UP_Matriculados - ConsultandoDatas()" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
