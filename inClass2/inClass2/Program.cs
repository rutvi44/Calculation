
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace inClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first;
            double second;
            double third;
            double fourth;
            double fifth;
            double sixth;
            int firstThree;
            int lastFour;
            int answerA;
            int final;
            
            //1. Take input from users for 1 to 6 numbers

            Console.Write("Enter the first number which is in two digits:");
            first = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number which is in two digits:");
            second = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number which is in two digits:");
            third = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number which is in two digits:");
            fourth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fifth number which is in two digits:");
            fifth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the sixth number which is in two digits:");
            sixth = Convert.ToDouble(Console.ReadLine());

            //2. Addition of the first three numbers
            firstThree = (int)(first + second + third);

           //3. Addition of last four numbers
            lastFour = Convert.ToInt32(third + fourth + fifth + sixth );

            //4. Multiplication of first three and last four numbers
            answerA = Convert.ToInt32(firstThree * lastFour);

            //5. Subtraction of first three numbers with last number
            final = firstThree - (int)(sixth);

            //6. Output
            Console.WriteLine($"Result of  addition of first Three {firstThree}");
            Console.WriteLine($"Result of addition of lastfourth {lastFour}");
            Console.WriteLine($"Result of multiplication {answerA}");
            Console.WriteLine($"Result of subtraction {final}");

            Console.ReadKey();
        }
    }
}
