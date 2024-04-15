using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i!=5)
            {   
                Console.WriteLine("Enter your option 1) Conversion\n 5)Exit");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter American dollars to be converted into Indian rupees");
                
                Console.WriteLine($"Converted amount is {convertedAmount}");
                Console.ReadLine();
            }
            
        }
    }
}
        