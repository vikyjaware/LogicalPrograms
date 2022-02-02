using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    public class PrimeNumber
    {
        public void Prime()
        {
            Console.WriteLine("Enter the number to find is it prime or not...");
            int num = Convert.ToInt32(Console.ReadLine()) ;
            int i, sum = 0;
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    sum++;
            }

            if(sum==2)
                {
                    Console.WriteLine(num + " is a prime number");
                }
                else
                {
                    Console.WriteLine(num + " is not a prime number");
                }    
        }
    }
}
