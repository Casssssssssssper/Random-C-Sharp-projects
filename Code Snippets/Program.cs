using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snippets
{
    class Program
    {
        static void Main(string[] args)
        {

            // The following code uses the float type’s IsInfinity method to determine whether the narrowing conversion caused an overflow or underflow:

            double big = -1E40;
            float small = (float)big;
            if (float.IsInfinity(small))
            {
                throw new OverflowException();
            }
        }

           
             public string firstName;
        public string lastname; public char initial; public double score1; public double score2; public double score3; public double score4; public double score5; public double average;
        public void calcAverage() { double avg = ((score1 + score2 + score3 + score4 + score5) / 5); this.average = avg; }
    }

}
    