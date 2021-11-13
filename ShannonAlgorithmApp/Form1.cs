using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShannonAlgorithmApp
{
	public partial class Form1 : Form
	{
		private List<Letter> data;
		private char[] UserInput;
		private string Write;
		private Dictionary<char, string> letterCodeValues;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			richTextBox2.Clear();

			// Convert user input to list of letters and sort it
			//-----------------------------------------------------------------
			if (richTextBox1.Text.Trim() == "")
			{
				MessageBox.Show("User input is null, try to analyze another data.", "Error");
				return;
			}

			UserInput = richTextBox1.Text.ToCharArray();
			SortData userText_1 = new SortData(UserInput);  
			data = userText_1.GetData();
			//-----------------------------------------------------------------
			


			// Find count of all letters and split letters to char array
			// ----------------------------------------------------------------
			char[] AllLetters = new char[data.Count];
			int[] AllCount = new int[data.Count];
			
			int cnt = 0;
		    foreach (var item in data)
			{
				AllLetters[cnt] = item.letter;
				AllCount[cnt] = item.count;
				cnt++;
			}
			// ----------------------------------------------------------------


			// Convert letters to Shannon code and save it like (letter --> code)
			// ----------------------------------------------------------------
			ShannonAlgorithm testData = new ShannonAlgorithm(AllLetters, AllCount);
			letterCodeValues = testData.GetLettersCode();
			// ----------------------------------------------------------------

			//
			// ----------------------------------------------------------------
			for (int i = 0; i < data.Count; i++)
			{
				data[i].letterCode = letterCodeValues[data[i].letter];
			}
			// ----------------------------------------------------------------
			
			Write = richTextBox1.Text;
			foreach (var item in letterCodeValues)
			{
				Write = Write.Replace($"{item.Key}", item.Value);

			}
			for (int i = 0; i < data.Count; i++)
            {
				richTextBox2.Text = richTextBox2.Text + Printer(data[i]);
            }
            
			richTextBox2.Text = richTextBox2.Text + Write;
		}
		private string Printer(Letter let)
        {
			return $"{let.letter} {let.count} {let.interest} {let.letterCode}\n";

		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("The program was created by:\n- Nasikovskyi Vitalii\n- Ovramets Illia\n- Nesterenko Vyacheslav\n- Kaplia Heorhii\n- Karavan Evhenii\n- Marchenko Nikolas", "About program");
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToFile toFile = new ToFile();
			toFile.WriteToFile(richTextBox1.Text);
			for (int j = 0; j < data.Count; j++)
			{
				toFile.WriteToFile(data[j]);
			}
			toFile.WriteToFile(Write);
		}
	}
}
