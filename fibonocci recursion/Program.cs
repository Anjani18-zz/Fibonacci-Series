using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonocci_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("enter the len");
            length= int.Parse(Console.ReadLine());
            Fibonacci_Temp(0, 1, 1, length);

        }
      private static void Fibonacci_Temp(int firstnum, int secondnum, int count, int length)

        {

            if (count <= length)
            {
                Console.Write(" "+firstnum);
                Fibonacci_Temp(secondnum, firstnum+secondnum, count + 1, length);
                Console.ReadKey();
            }
        }
    }
}
