using System;

namespace GalaLabs1_2
{
     static class Lab2
    {
         public static void Go()
         {
             Console.WriteLine("Let's order number. Enter it, please.\n");
             var numberUsers = Console.ReadLine();
             int number = 0;

             if (numberUsers != null && int.TryParse(numberUsers, out number))
             {
                 if (number > 100)
                     Console.WriteLine(ReturnNormalNumberBack(number).ToString());
                 else
                     Console.WriteLine(number.ToString());
             }
            
         }

         static int GetOrder(int someMessedBigNumber)
        {
            int order = 0;
            while (someMessedBigNumber > 1) 
            {
                someMessedBigNumber = someMessedBigNumber / 10;
                order ++;
            }
            return order;
        }
        public static int ReturnNormalNumberBack(int someMessedBigNumber) 
        {
            int order = GetOrder(someMessedBigNumber);
            int lastNumber = someMessedBigNumber % 10;
            int tail = ((someMessedBigNumber-lastNumber) % (int)Math.Pow(10, order));
            return (someMessedBigNumber - tail - lastNumber) + lastNumber * (int)Math.Pow(10,(order-1)) + tail / 10;
        }
    }
}
