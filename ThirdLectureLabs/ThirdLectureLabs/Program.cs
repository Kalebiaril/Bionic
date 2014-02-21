using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLectureLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Instanse.UsersChoice();
        }
        public class Calculator
        {
            private static Calculator _instanse;
            public static Calculator Instanse
            {
                get
                {
                    if (_instanse == null) _instanse = new Calculator();
                    return _instanse;
                }
            }

         

            private SquareMatrix X, Y;
            public void UsersChoice()
            {
                Console.WriteLine("Select operation: \n1.Generate matrix X \n2.Generate matrix Y  \n3. X+Y \n4. X-Y \n5.|X| \n6.|Y| \n7.Exit");
                string answer = Console.ReadLine();
                if (!string.IsNullOrEmpty(answer))
                    switch (answer.Trim())
                    {
                        case "1":
                            {
                                Console.WriteLine("Enter size of the matrix, please");
                                int size = 0;
                                if (Int32.TryParse(Console.ReadLine(), out size))
                                {
                                    X = new SquareMatrix(size);
                                    Console.WriteLine(X.ToString());
                                }
                                UsersChoice();
                                break;
                            }
                        case "2":
                        {
                            Console.WriteLine("Enter size of the matrix, please");
                            int size = 0;
                            if (Int32.TryParse(Console.ReadLine(), out size))
                            {
                                Y = new SquareMatrix(size);
                                Console.WriteLine(Y.ToString());
                            }
                            UsersChoice();
                            break;
                        }
                        case "3":
                        {
                            Console.WriteLine((X + Y).ToString());
                            UsersChoice();
                            break;
                        }
                        case "4":
                            {
                                Console.WriteLine((X - Y).ToString());
                                UsersChoice();
                                break;
                            }
                        case "5":
                        {
                            Console.WriteLine(X.Determinant);
                            UsersChoice();
                            break;
                        }
                        case "6":
                        {
                            Console.WriteLine(Y.Determinant);
                            UsersChoice();
                            break;
                        }
                        case "7":
                        {
                            break;
                        }

                    }
             
            }
        }
    }
}
