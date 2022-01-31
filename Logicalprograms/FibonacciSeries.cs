using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    public class FibonacciSeries
    {
        public void Fibonacci()
        {
            Console.WriteLine("Enter the number of terms required ");
            int n = Convert.ToInt32(Console.ReadLine()) ;
            int i, firstnum = 1, secondnum = 1, thirdnum;
            Console.Write(firstnum + "\t" +secondnum );
            for( i=2; i<n; i++)
            {
                thirdnum = firstnum + secondnum;
                firstnum = secondnum;
                secondnum= thirdnum;
                Console.Write("\t" +thirdnum );
            }
        }
    }
}
