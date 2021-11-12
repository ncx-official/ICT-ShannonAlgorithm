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
        private string path = @"C:\";
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
                File.AppendAllText(path, $"{let.letter} {let.count} {let.interest} {let.letterCode}\n");
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
