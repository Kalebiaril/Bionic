using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace SecondLectureLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Instanse.UsersChoice();
        }
        public class Menu
        {
            private static Menu _instanse;
            public static Menu Instanse
            {
                get
                {
                    if (_instanse == null) _instanse = new Menu();
                    return _instanse;
                }
            }

            private void GetDocumentInfo(Document document)
            {

                string keys = document.KeyWords.Aggregate("", (current, key) => current + (key + ";"));

                Console.WriteLine(string.Format("Name: {0}, \n Author: {1}, \n Path: {2}, \n Theme: {3}, \n KeyWords: {4} ",
                                                document.Name,document.Author,document.Path,document.Theme, keys));
            }

            public void UsersChoice()
            {
                Console.WriteLine("Select document type:\n1.DOC \n2.XLS \n3.PDF \n4.TXT \n5.HTML\n");
                string answer =  Console.ReadLine();
                if (!string.IsNullOrEmpty(answer)) 
                switch (answer.Trim())
                {
                    case "1":
                    {
                        GetDocumentInfo(new MicrosoftWordDocument());
                        break;
                    }
                    //case "2":
                    //{
                    //    GetDocumentInfo(new ());
                    //    break;
                    //}
                    case "3":
                    {
                        GetDocumentInfo(new PDFDocument());
                        break;
                    }
                    case "4":
                    {
                        GetDocumentInfo(new TxtDocument());
                        break;
                    }
                    case "5":
                    {
                        GetDocumentInfo(new HTMLDocument());
                        break;
                    }
                   
                }
                Console.ReadLine();
            }
        }
    }

}
