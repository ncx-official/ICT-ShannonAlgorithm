using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShannonAlgorithmApp
{
    class Letter
    {
        public char letter;
        public int count;
        public double interest;
        public string letterCode = "";

        public Letter(char letter,int count)
        {
            this.letter = letter;
            this.count = count;
        }
        /// <summary>
        /// Обраховує відсоток.
        /// </summary>
        /// <param name="all"></param>
        public void SetInterest(double all)
        {
            interest = Math.Round((count/all)*100.0, 3);
        }
    }
}
