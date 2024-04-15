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
            Console.WriteLine("Enter American dollars to be converted into Indian rupees");
            string amount = Console.ReadLine();
            double convertedAmount = double.Parse(amount) * 83.44;
            
            Console.WriteLine($"Converted amount is {convertedAmount}");
            Console.ReadLine();
        }
    }
}
        