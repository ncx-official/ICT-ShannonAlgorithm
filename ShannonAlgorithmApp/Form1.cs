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
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ShannonAlgorithm userText_1 = new ShannonAlgorithm(richTextBox1.Text.ToCharArray());
			List<Letter> data = userText_1.GetData();
		}
	}
}
