using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public class Conexão
    {
        public SqlConnection con = new SqlConnection(@"Data Source=PCH_SD-001\BORGES;Initial Catalog=RCFitness;Integrated Security=True");

        public void AbrirConexão()
        {
            try
            {
                con.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao abrir conexão - DataBase/Conexão - AbrirConexão" + erro);
            }
        }
        public void FecharConexão()
        {
            try
            {
                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao fechar conexão - DataBase/Conexão - FecharConexão()" + erro);
            }
        }
    }
}
