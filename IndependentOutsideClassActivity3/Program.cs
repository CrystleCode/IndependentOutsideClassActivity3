using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentOutsideClassActivity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool intInput;
            int numberInput;
            Console.Write("Input a number: ");

            intInput = int.TryParse(Console.ReadLine(), out numberInput);
            switch (intInput)
            {
                case true:
            switch (numberInput)
            {
                case 10: Console.WriteLine("Your number was 10");
                    break;

                default: Console.WriteLine("Your number was not 10");
                    break;
            }
                    break;
                case false: Console.WriteLine("You didn't input an integer");
                    break;
            }

            Console.ReadKey();
        }
    }
}
