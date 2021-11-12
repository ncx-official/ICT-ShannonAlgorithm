using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShannonAlgorithmApp
{
	class ShannonAlgorithm
	{
		private Dictionary<char, string> LettersCoding = new Dictionary<char, string>();
		private char[] letters;
		private int[] lettersCount;
		private bool flag = true;
		
		public ShannonAlgorithm(char[] letters, int[] lettersCount)
		{
			this.letters = letters;
			this.lettersCount = lettersCount;
            this.GetShannonCodeByLetters(' ', " ", 0, letters.Length - 1);
		}

		private void GetShannonCodeByLetters(char branch, string full_branch, int startPos, int endPos)
		{
            double dS;
            int m, i, S;
            string c_branch;
            if (flag)
            {
                c_branch = "";
                flag = false;
            }
            else
            {
                c_branch = full_branch + branch;
            }

            if (startPos == endPos)
            {
                if (LettersCoding.ContainsKey(letters[startPos]))
				{
                    LettersCoding[letters[startPos]] = c_branch;
                }
				else
				{
                    LettersCoding.Add(letters[startPos], c_branch);
                }
                return;
            }

            dS = 0;
            for (i = startPos; i < endPos; i++)
            {
                dS += lettersCount[i];
            }

            dS /= 2;


            S = 0;
            i = startPos;
            m = i;

            while (S + lettersCount[i] < dS && i < endPos)
            {
                S += lettersCount[i];
                m++;
                i++;
            }
            this.GetShannonCodeByLetters('0', c_branch, startPos, m);
            this.GetShannonCodeByLetters('1', c_branch, m + 1, endPos);
        }

        public Dictionary<char, string> GetLettersCode()
		{
            return LettersCoding;
		}
    }
}
