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
		private int LenghtCodeASCI;


		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			richTextBox2.Clear();

			LenghtCodeASCI = (richTextBox1.Text.Length * 8);

			// Convert user input to list of letters and sort it
			//-----------------------------------------------------------------
			UserInput = richTextBox1.Text.ToCharArray();
			if (richTextBox1.Text == "")
			{
				MessageBox.Show("Помилка зчитування даних, введено пусте значення.");
				return;
			}
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
            
			richTextBox2.Text = richTextBox2.Text + $"\nДвійковий код усього повідомлення:\n{Write}\n Довжина в бітах кодованого повідомлення: {Write.Length} біт\n";
			richTextBox2.Text = richTextBox2.Text + $"\nДовжина коду в ASCI {LenghtCodeASCI}";
		}
		private string Printer(Letter let)
        {
			return $"Letter: '{let.letter}', CountInText: {let.count}, Probability: {let.interest}%, Двійковий код: {let.letterCode}\n";

		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("The program was created by:\n- Nasikovskyi Vitalii\n- Ovramets Illia\n- Nesterenko Vyacheslav\n- Kaplia Heorhii\n- Karavan Evhenii\n- Marchenko Nikolas", "About program");
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToFile toFile = new ToFile("ResultData");
			toFile.WriteToFile(richTextBox1.Text);
			for (int j = 0; j < data.Count; j++)
			{
				toFile.WriteToFile(data[j]);
			}
			toFile.WriteToFile($"\nДвійковий код усього повідомлення:\n{Write}\n Довжина в бітах кодованого повідомлення: {Write.Length} біт\n");
			toFile.WriteToFile($"\nДовжина коду в ASCI: {LenghtCodeASCI}");
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (richTextBox3.Text.Length < 1 || richTextBox2.Text.Length < 1)
				return;

			try
			{
				Decoding decoding = new Decoding(letterCodeValues);
				richTextBox4.Text = decoding.GetResult(richTextBox3.Text);
			}
			catch
			{
				MessageBox.Show("Введіть інше значення.");
			}


		}
	}
}
