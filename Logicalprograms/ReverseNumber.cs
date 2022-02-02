using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    public class ReverseNumber
    {
        public void reverse()
        {
            Console.WriteLine("Enter the number you want to reverse...");
            int n = Convert.ToInt32(Console.ReadLine()) ;
            int result = 0;
            while(n > 0)
            {
                int reminder = n % 10;
                result = result * 10 + reminder;
                n /= 10;
            }
            Console.WriteLine("The Reverse of Number "+ n + " is " + result);
        }
    }
}
