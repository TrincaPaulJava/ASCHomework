using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MooresLaw
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mod de rezolvare:
              
              pentru a afla numarul de ani, am folosit Log(n , 2) * 1.5 
              iar pentru a afla numarul de luni, am luat partea fractionara
              a numarului de ani si am inmultit-o cu 12.*/
            
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("*               Welcome to Moore's Law calculator                   *");
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("* Moore's law is the observation that the number of transistors in  *");
            Console.WriteLine("* a dense integrated circuit (IC) doubles about every 18 months     *");
            Console.WriteLine("* while the price remains the same.                                 *");
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("* This program will tell you how long it will take for the numbers  *");
            Console.WriteLine("* of transistors will be multiplied by a number chose by you        *");
            Console.WriteLine("*                                                                   *");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.Write("Choose a number:");
            int n;
            n = int.Parse(Console.ReadLine());
            double result = Math.Log(n, 2) * 1.5;
            
            double var = result - (int)result;
            var = var * 12;
            Console.WriteLine("After " + (int)result + " years and " + (int)var + " months, the number of transistors will be multiplied by " + n);
        }
    }
}
