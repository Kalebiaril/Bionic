using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthLabth
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu.Instanse.UsersChoise();
        }
        public class  Menu
        {
            private static Menu _instanse;

            public static Menu Instanse
            {
                get
                {
                    if (_instanse == null)
                    {
                        _instanse = new Menu();
                    }
                    return _instanse;
                }
            }

            private TextFile txtFile;

            public void UsersChoise()
            {
                Console.WriteLine(
                    "Select operation: \n1.Create new txtfile \n2.Serialize file Y  \n3. Deserialize file \n4.Exit");
                string answer = Console.ReadLine();
                if (!string.IsNullOrEmpty(answer))
                    switch (answer.Trim())
                    {
                        case "1":
                        {
                            Console.WriteLine("Enter Name of file");
                            string name = Console.ReadLine();
                            txtFile = new TextFile {Name = name};
                            UsersChoise();
                            break;
                        }
                        case "2":
                        {
                            if (txtFile != null)
                            {
                                Console.WriteLine("Enter a path, please");
                                string path = Console.ReadLine();
                                Directory.CreateDirectory(Path.GetTempPath() + "bionicsTests\\");
                                path = Path.GetTempPath() +"bionicsTests\\"+ path;
                                try
                                {
                                    using (var fs = new FileStream(path, FileMode.Create))
                                    {
                                        txtFile.Serialize(fs);
                                    }
                                }
                                catch (FieldAccessException ex)
                                {
                                    Console.WriteLine("Enter other path, please");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Create a file, please");
                            }
                            UsersChoise();
                            break;
                        }
                        case "3":
                        {
                            if (txtFile != null)
                            {
                                Console.WriteLine("Enter a path, please");
                                string path = Console.ReadLine();
                                path = Path.GetTempPath() + "bionicsTests\\" + path;
                                try
                                {
                                    using (var fs = new FileStream(path, FileMode.Open))
                                    {
                                        txtFile.Deserialize(fs);
                                    }
                                }
                                catch (FieldAccessException ex)
                                {
                                    Console.WriteLine("Enter other path, please");
                                }
                               
                            }
                            else
                            {
                                Console.WriteLine("Create a file, please");
                            }
                            UsersChoise();
                            break;
                        }
                        case "4":
                        {
                            break;
                        }

                    }
            }

        }
    }
}
