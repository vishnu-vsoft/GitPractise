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
                Console.WriteLine("Enter your option 1) Conversion in INR\n2)Conversion to AUS Dollar\n 5)Exit");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter American dollars to be converted into Indian rupees");
                if (i == 1)
                {
                    double convertedAmount = Convert.ToDouble(Console.ReadLine()) * 84.44;
                    Console.WriteLine($"Converted amount is {convertedAmount}");
                }
                if (i == 2)
                {
                    double ausDollar = Convert.ToDouble(Console.ReadLine()) * 1.54;
                    Console.WriteLine($"Converted amount is {ausDollar}");
                }
                
                
                
                Console.ReadLine();
            }
            
        }
    }
}
        