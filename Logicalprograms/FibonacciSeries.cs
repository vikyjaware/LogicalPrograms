using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            Console.WriteLine("Enter the number to find is perfect or not ...");
            int num = Convert.ToInt32(Console.ReadLine()) ;
            int i, sum = 0;
            for( i=1; i<=num/2; i++)
            {
                if(num%i==0)
                {
                    sum+=i;
                }
                if (sum == num)
                {
                    Console.WriteLine(num + " is a perfect number");
                }

            }
            if(sum!=num)
            {
                Console.WriteLine(num + " is not a perfect number ");
            }
        }
    }
}
