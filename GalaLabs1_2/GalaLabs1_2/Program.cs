using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaLabs1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ChoiseLab();
        }

        private static void ChoiseLab()
        {
            Console.WriteLine("Hi!Select what do you want to do? \n 1. Calculate a^n \n 2. Order messed number \n");
            string usersLabChoise = Console.ReadLine();
            if (usersLabChoise != null)
            {

                usersLabChoise = usersLabChoise.Trim();
                if (usersLabChoise.Equals("1"))
                {
                    Lab1.Go();
                }
                else if (usersLabChoise.Equals("2"))
                {
                    Lab2.Go();
                }
                else
                {
                    ChoiseLab();
                }
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Oops! Something really unusual happened here");
            }
        }
    }
}
