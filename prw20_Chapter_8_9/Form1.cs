using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prw20_Chapter_8_9
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			ConvertText();
		}

		private void ConvertText()
		{
			//Do a ToUpper first to clean the text to compare against variables.
			/*Set variables for VALID_LENGTH = 12
			 *  •	A, B, and C = 2
				•	D, E, and F = 3
				•	G, H, and I = 4
				•	J, K, and L = 5
				•	M, N, and O = 6
				•	P, Q, R, and S = 7
				•	T, U, and V = 8
				•	W, X, Y, and Z = 9*/
			//Make sure formatting is correct (str.Length == VALID_LENGTH && str [3] == '-' && str[7] == '-'), if not error message
			//if the user enters 555-GET-FOOD, the application should display 555-438-3663.
			const int VALID_LENGTH = 12;
			int abc = 2;
			int def = 3;
			int ghi = 4;
			int jkl = 5;
			int mno = 6;
			int pqrs = 7;
			int tuv = 8;
			int wxyz = 9;
			string str = "";
			str = txtUserInput.Text.ToUpper();
			string conversion = "";

			if (str.Length == VALID_LENGTH && str[3] == '-' && str[7] == '-')
			{
				foreach (char ch in str)
				{
					if (ch == 'A' || ch ==  'B' || ch == 'C')
					{
						conversion += abc.ToString();
					}
					if (ch == 'D' || ch == 'E' || ch == 'F')
					{
						conversion += def.ToString();
					}
					if (ch == 'G' || ch == 'H' || ch == 'I')
					{
						conversion += ghi.ToString();
					}
					if (ch == 'J' || ch == 'K' || ch == 'L')
					{
						conversion += jkl.ToString();
					}
					if (ch == 'M' || ch == 'N' || ch == 'O')
					{
						conversion += mno.ToString();
					}
					if (ch == 'P' || ch == 'Q' || ch == 'R' || ch == 'S')
					{
						conversion += pqrs.ToString();
					}
					if (ch == 'T' || ch == 'U' || ch == 'V')
					{
						conversion += tuv.ToString();
					}
					if (ch == 'W' || ch == 'X' || ch == 'Y' || ch == 'Z')
					{
						conversion += wxyz.ToString();
					}
					if (ch == '0')
					{ conversion += "0"; }
					if (ch == '1')
					{ conversion += "1"; }
					if (ch == '2')
					{ conversion += "2"; }
					if (ch == '3')
					{ conversion += "3"; }
					if (ch == '4')
					{ conversion += "4"; }
					if (ch == '5')
					{ conversion += "5"; }
					if (ch == '6')
					{ conversion += "6"; }
					if (ch == '7')
					{ conversion += "7"; }
					if (ch == '8')
					{ conversion += "8"; }
					if (ch == '9')
					{ conversion += "9"; }
					if (conversion.Length == 3)
					{
						conversion += "-";
					}
					if (conversion.Length == 7)
					{
						conversion += "-";
					}
				}
				lblOutput.Text = conversion;
			}
			else
			{
				MessageBox.Show("Please enter correct format");
			}
		}
		private void ClearText()
		{
			txtUserInput.Text = "";
			txtUserInput.Focus();
			lblOutput.Text = "";
		}
		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearText();
		}
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
