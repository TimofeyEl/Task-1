using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            

            Console.WriteLine("Введите целое число: ");
            int x = int.Parse(Console.ReadLine());
            


            if (x % 2 == 0) 
            {
                Console.WriteLine($"Введенное число {x} является четным");
            
            }
            else
            {
                Console.WriteLine($"Введенное число {x} является нечетным");
                
            }
            Console.ReadKey();
        }


        
        
    }
}
