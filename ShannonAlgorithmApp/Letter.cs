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

        public Letter(char letter,int count)
        {
            this.letter = letter;
            this.count = count;
        }

        public void SetInterest(int all)
        {
            interest = all / count;
        }
    }
}
