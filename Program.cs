using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace PisagorUcgeni
{
    class Program
    {

        public static int PisagorUcgeni(int ustSinir)
        {
            int count = 0;
            for (int a = 1; a < ustSinir; a++)
            {
                for (int b = a; b < ustSinir; b++)
                {
                    for (int c = b; c < ustSinir; c++)
                    {
                        if (a*a+b*b==c*c)
                        {
                            WriteLine($"( {a},{b},{c} )");
                            count++;
                        }
                        
                    }
                }
            }
            return count;

        }
        static void Main(string[] args)
        {

            WriteLine("Pisagor üçgeni sayısı : " + PisagorUcgeni(100));
            ReadLine();
        }
    }
}
