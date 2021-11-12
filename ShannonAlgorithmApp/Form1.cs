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

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Convert user input to list of letters and sort it
			//-----------------------------------------------------------------
			SortData userText_1 = new SortData(richTextBox1.Text.ToCharArray());  
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
			Dictionary<char, string> letterCodeValues = testData.GetLettersCode();
			// ----------------------------------------------------------------
		}
	}
}
