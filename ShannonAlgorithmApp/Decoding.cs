using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShannonAlgorithmApp
{
    class Decoding
    {
        private Dictionary<char, string> letterCodeValues;

        public Decoding(Dictionary<char, string> letterCodeValues)
        {
            this.letterCodeValues = letterCodeValues;
        }

        private int GetMaxLenValue()
        {
            int maxvalue = 0;
            foreach (var item in letterCodeValues)
            {
                int secondvalue = item.Value.Length;
                if(secondvalue > maxvalue)
                {
                    maxvalue = secondvalue;
                }

            }
            return maxvalue;
        }
        //can you can a can as a canner can can a can
        public string GetResult(string userInput)
        {
            int start = 0;
            int caunt = GetMaxLenValue();
            int end = caunt;
            string result = "";
            bool flag = false;
            string letter;
            caunt = 0;
            do
            {
                if(start > end)
                {
                    break;
                }
                letter = userInput[start..end];
                foreach (var item in letterCodeValues)
                {
                    if (item.Value == letter)
                    {
                        result += $"{item.Key}";
                        caunt += letter.Length;
                        start = end;
                        end += caunt;
                        flag = true;
                        break;
                    }
                }
                if (end >= userInput.Length - 1) { end = userInput.Length - 1;}
                if (!flag) { end--;}
                flag = false;
                
            }
            while (end < userInput.Length);

            letter = userInput[caunt..(userInput.Length)];
            foreach (var item in letterCodeValues)
            {
                if (item.Value == letter)
                {
                    result += $"{item.Key}";
                    break;
                }
            }
            return result;
        }


    }
}
