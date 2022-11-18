using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второк число");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                int result1 = a + b;
                Console.WriteLine(result1);
            }
            if (a == b)
            {
                int result2 = a * b;
                Console.WriteLine(result2); 
            }
            if (b > a)
            {
                int result3 = a - b;
                Console.WriteLine(result3);
            }
              
        }
        
        
    }
}
