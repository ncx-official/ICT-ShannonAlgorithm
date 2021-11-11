using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShannonAlgorithmApp
{
	class ShannonAlgorithm
	{
		private char[] data;
		private List<Letter> ListLetter = new List<Letter>() { };
		private double sum = 0;
		public ShannonAlgorithm(char[] userInput)
		{
			this.data = userInput;
			Worker();
		}
		private void GetFullSum()
        {
            for (int i = 0; i < ListLetter.Count; i++)
            {
				sum += ListLetter[i].count;
            }
        }
		public List<Letter> GetData(){

			return ListLetter;
        }

		private void CheckArray(char elem)
		{

			if (elem <= 42 && elem >= 32 || elem <= 64 && elem >= 58)
				return;

			for (int j = 0; j < ListLetter.Count; j++)
			{
				if (ListLetter[j].letter == elem)
				{
					ListLetter[j].count += 1;
					return;
				}
			}
			ListLetter.Add(new Letter(elem, 1));
		}
		public void Worker()
        {
			for (int i = 0; i < data.Length; i++)
			{
				CheckArray(data[i]);
			}
			GetFullSum();
            for (int i = 0; i < ListLetter.Count; i++)
            {
				ListLetter[i].SetInterest(sum);
            }
		}
	}
}
