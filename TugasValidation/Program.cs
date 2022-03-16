using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasValidation
{
    class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--== Basic Authentication==--");
            Console.WriteLine("1. Create User");
            Console.WriteLine("2. Delete User");
            Console.WriteLine("3. Update User");
            Console.WriteLine("4. Show User");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Login");
            Console.WriteLine("7. Exit");
            Console.Write("Input : ");
            var pilih = Console.ReadKey();
            switch (pilih.KeyChar)
            {
                case '1':
                    User create = new User();
                    create.Create();
                    break;
                
                case '2':
                    User delete = new User();
                    delete.Delete();    
                    break;
                case '3':
                    User update = new User();
                    update.Update();
                    break;
                case '4':
                    User show = new User();
                    show.Show();
                    break;
                case '5':
                    User search = new User();
                    search.Search();
                    break;
                case '6':
                    User login = new User();
                    login.Login();
                    break;
                case '7':
                    Environment.Exit(0);
                    break;
                default:
                    Main();
                    break;
            }
        }
    }
}
