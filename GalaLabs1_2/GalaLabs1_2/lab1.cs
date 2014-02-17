using System;
using Microsoft.Win32;

namespace GalaLabs1_2
{
    static class Lab1
    {
        
        public static void Go()
        {
            Console.WriteLine("Let's calculate a^n! Enter a, please.\n");
            var aUsers = Console.ReadLine();
            double a = 0;
            int n = 0;
            if (aUsers != null && Double.TryParse(aUsers, out a))
            {
                Console.WriteLine("Now enter n, please.\n");
                var nUsers = Console.ReadLine();
                if (nUsers != null && int.TryParse(nUsers,out n))
                {
                    Console.WriteLine(Pow((decimal)a, n).ToString());
                }
             }
            
        }

    
        private static decimal Pow(decimal a, int n)
        {
            if (n == 1)
            {
                return a;
            }
            return Pow(a * a, n - 1);
            
        }
    }
}
