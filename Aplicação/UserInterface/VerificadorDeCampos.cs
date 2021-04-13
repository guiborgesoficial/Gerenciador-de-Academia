using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UserInterface
{
    public class VerificadorDeCampos
	{
		public int verificadorQtdInputsNumericosValidados = 0;
		public int verificadorDeCamposPreenchidos = 0;
		public int limpaCampos = 0;
		public System.Windows.Forms.Timer VerificaCamposTempoReal = new System.Windows.Forms.Timer();
		public System.Windows.Forms.Timer VerificaCamposNuméricosTempoReal = new System.Windows.Forms.Timer();

		public void VerificaCamposPreenchidos(Control x)
		{
			VerificaCamposTempoReal.Interval = 100;
			VerificaCamposTempoReal.Enabled = true;
			
			foreach (Control verificar in x.Controls)
			{
				if (verificar.GetType().Equals(typeof(TextBox)))
				{
					Panel AlturaCampo = new Panel();
					Panel LarguraCampo = new Panel();
					if (verificar.Text == string.Empty)
					{
						verificar.Controls.Clear();
						AlturaCampo.Height = verificar.Height;
						AlturaCampo.Width = 1;
						AlturaCampo.BackColor = Color.Red;
						verificar.Controls.Add(AlturaCampo);

						LarguraCampo.Width = verificar.Width;
						LarguraCampo.Height = 1;
						LarguraCampo.BackColor = Color.Red;
						verificar.Controls.Add(LarguraCampo);
					}
					else
					{
						verificadorDeCamposPreenchidos += 1;
						verificar.Controls.Clear();
					}
				}
				if (verificar.GetType().Equals(typeof(MaskedTextBox)))
				{
					Panel LarguraCampo = new Panel();
					Panel AlturaCampo = new Panel();

					if (verificar.Text.Contains("_"))
					{
						verificar.Controls.Clear();
						AlturaCampo.Height = verificar.Height;
						AlturaCampo.Width = 1;
						AlturaCampo.BackColor = Color.Red;
						verificar.Controls.Add(AlturaCampo);

						LarguraCampo.Width = verificar.Width;
						LarguraCampo.Height = 1;
						LarguraCampo.BackColor = Color.Red;
						verificar.Controls.Add(LarguraCampo);
					}
					else
					{
						verificadorDeCamposPreenchidos += 1;
						verificar.Controls.Clear();
					}
				}
				if (verificar.GetType().Equals(typeof(ComboBox)))
				{
					Panel LarguraCampo = new Panel();
					Panel AlturaCampo = new Panel();

					if (verificar.Text == string.Empty)
					{
						verificar.Controls.Clear();
						AlturaCampo.Height = verificar.Height;
						AlturaCampo.Width = 1;
						AlturaCampo.BackColor = Color.Red;
						verificar.Controls.Add(AlturaCampo);

						LarguraCampo.Width = verificar.Width;
						LarguraCampo.Height = 1;
						LarguraCampo.BackColor = Color.Red;
						verificar.Controls.Add(LarguraCampo);
					}
					else
					{
						verificadorDeCamposPreenchidos += 1;
						verificar.Controls.Clear();
					}
				}
			}
		}
		public void VerificarCamposNuméricos(Control x)
        {
			VerificaCamposNuméricosTempoReal.Interval = 100;
			VerificaCamposNuméricosTempoReal.Enabled = true;

			foreach (Control verificar in x.Controls)
			{
				if (verificar.GetType().Equals(typeof(TextBox)))
				{
					Panel LarguraCampo = new Panel();
					Panel AlturaCampo = new Panel();
					if (Regex.IsMatch(verificar.Text, @"^[0-9]+$"))
					{
						verificadorQtdInputsNumericosValidados++;
					}
					else
					{
						verificar.Controls.Clear();
						AlturaCampo.Height = verificar.Height;
						AlturaCampo.Width = 1;
						AlturaCampo.BackColor = Color.Red;
						verificar.Controls.Add(AlturaCampo);

						LarguraCampo.Width = verificar.Width;
						LarguraCampo.Height = 1;
						LarguraCampo.BackColor = Color.Red;
						verificar.Controls.Add(LarguraCampo); 
						
						verificar.Text = string.Empty;
					}
				}
			}
		}
	}
}
