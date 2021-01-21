using System;
using DataBase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace Business.SqlComandos.Consultar
{
    public class CS_ChtFaturamento
    {
        public double faturamento { get; set; }
        public double ticketMédio { get; set; }
        public double ContasParaReceber { get; set; }
        public double ValoresVencimentoHoje { get; set; }
        public double FaturamentoHoje { get; set; }
        Conexão conectar = new Conexão();

        public void ConsultandoFaturamentoCht(string intervalo)
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultar = intervalo;
                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                objComando.ExecuteNonQuery();

                SqlDataReader leitor = objComando.ExecuteReader();
               
                while (leitor.Read() && !leitor.IsDBNull(0))
                {
                    faturamento = Convert.ToDouble(leitor["Faturamento"]);
                }
                
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao consultar faturamento - Business/SqlComandos/Consultar/Charts/CS_ChtFaturamento - ConsultandoFaturamentoCht()" + erro, "Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void ConsultandoTicketMedio()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultar = "SELECT AVG(CAST(REPLACE(SUBSTRING(VALOR, 3, 7), ',' ,'.')AS decimal(18,2))) AS TicketMédio FROM Pagamento WHERE DT_PAG IS NOT NULL";
                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                objComando.ExecuteNonQuery();

                SqlDataReader leitor = objComando.ExecuteReader();

                while (leitor.Read() && !leitor.IsDBNull(0))
                {
                    ticketMédio = Convert.ToDouble(leitor["TicketMédio"]);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar Ticket Médio - Business/SqlComandos/Consultar/CS_ChtFaturamento - ConsultandoTicketMedio()" + erro, "Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void ConsultandoContasParaReceber()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultar = "SELECT SUM(CAST(REPLACE(SUBSTRING(VALOR, 3, 7), ',' ,'.')AS decimal(18,2))) AS ContasParaReceber FROM PagamentosParaReceber WHERE DT_PAG IS NULL AND STATUS = 'HAVER' AND DT_VENC >= '" + DateTime.Now.ToShortDateString() + "'";
                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                objComando.ExecuteNonQuery();

                SqlDataReader leitor = objComando.ExecuteReader();

                while (leitor.Read() && !leitor.IsDBNull(0))
                {
                    ContasParaReceber = Convert.ToDouble(leitor["ContasParaReceber"]);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar Contas Para Receber - Business/SqlComandos/Consultar/CS_ChtFaturamento - ConsultandoContasParaReceber()" + erro, "Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }

        }
        public void ConsultandoValoresVencimentoHoje()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultar = "SELECT SUM(CAST(REPLACE(SUBSTRING(VALOR, 3, 7), ',' ,'.')AS decimal(18,2))) AS ValoresVencimentoHoje FROM Pagamento WHERE DT_PAG IS NULL AND STATUS = 'HAVER' AND DT_VENC = '" + DateTime.Now.ToShortDateString() + "'";
                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                objComando.ExecuteNonQuery();

                SqlDataReader leitor = objComando.ExecuteReader();

                while (leitor.Read() && !leitor.IsDBNull(0))
                {
                    ValoresVencimentoHoje = Convert.ToDouble(leitor["ValoresVencimentoHoje"]);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar Valores Vencimento Hoje - Business/SqlComandos/Consultar/CS_ChtFaturamento - ConsultandoValoresVencimentoHoje()" + erro, "Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
        public void ConsultandoFaturamentoHoje()
        {
            try
            {
                conectar.AbrirConexão();
                string strConsultar = "SELECT SUM(CAST(REPLACE(SUBSTRING(VALOR, 3, 7), ',' ,'.')AS decimal(18,2))) AS FaturamentoHoje FROM Pagamento WHERE DT_PAG = '" + DateTime.Now.ToShortDateString() + "' AND STATUS = 'PAGO'";
                SqlCommand objComando = new SqlCommand(strConsultar, conectar.con);
                objComando.ExecuteNonQuery();

                SqlDataReader leitor = objComando.ExecuteReader();

                while (leitor.Read() && !leitor.IsDBNull(0))
                {
                    FaturamentoHoje = Convert.ToDouble(leitor["FaturamentoHoje"]);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar Faturamento Hoje - Business/SqlComandos/Consultar/CS_ChtFaturamento - ConsultandoFaturamentoHoje()" + erro, "Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.FecharConexão();
            }
        }
    }
}
