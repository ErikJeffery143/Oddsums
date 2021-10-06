using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_Percentages
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = 1;

            Console.WriteLine("Enter a NUMBER!!");
            if (Int32.TryParse(Console.ReadLine(), out input))
            {
                for (int i = 1; i < input; i = i + 2)
                {
                    Console.WriteLine(Convert.ToString(i));
                }



            }
            else
            {
                Console.WriteLine("Read better. ");
            }

            Console.ReadLine();







        }
    }
}
