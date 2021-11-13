using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShannonAlgorithmApp
{
	class SortData
	{
		private char[] data;
		private List<Letter> ListLetter = new List<Letter>() { };
		private double sum = 0;
		public SortData(char[] userInput)
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

			ListLetter.Reverse();
			return ListLetter;
        }

		private void SortInterest()
		{
			bool flag = false;
			for (int i = 0; i < ListLetter.Count; i++)
			{
				if (i+1 == ListLetter.Count)
				{
					if (flag) { i = 0; flag = false; } else { break; }
				}
				if (ListLetter[i].interest > ListLetter[i+1].interest)
				{
					Letter swap = ListLetter[i];
					ListLetter[i] = ListLetter[i+1];
					ListLetter[i+1] = swap;
					flag = true;
				}
			}
		}


		private void CheckArray(char elem)
		{
			//if (elem <= 42 && elem >= 32 || elem <= 64 && elem >= 58) // use only letters without spaces and other symbols
				//return;

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
			SortInterest();
		}
	}
}
