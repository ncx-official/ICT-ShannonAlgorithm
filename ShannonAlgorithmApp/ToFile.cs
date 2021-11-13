using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShannonAlgorithmApp
{
    class ToFile
    {
        private string path = @"D:\";
        private string name;

        public ToFile(string name = "Test")
        {
            this.name = name;
            path = path + $"{name}.txt";
        }
        
        public void WriteToFile(Letter let)
        {
            try
            {
                File.AppendAllText(path, $"Letter: '{let.letter}', CountInText: {let.count}, Probability: {let.interest}%, Двійковий код: {let.letterCode}\n");
            }
            catch
            {
                MessageBox.Show("Error in File");
                return;
            }
        }
        public void WriteToFile(string str)
        {
            try
            {
                File.AppendAllText(path, str+"\n");
            }
            catch
            {
                MessageBox.Show("Error in File");
                return;
            }
        }

    }
}
