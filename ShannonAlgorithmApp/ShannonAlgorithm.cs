using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShannonAlgorithmApp
{
	class ShannonAlgorithm
	{
		private string[] data;


		public ShannonAlgorithm(string[] userInput)
		{
			this.data = userInput;
		}

		public string[] GetData(){

			return data;
        }

		private void Worker()
        {
            for (int i = 0; i < data.Length; i++)
            {

            }
        }

	}
}
