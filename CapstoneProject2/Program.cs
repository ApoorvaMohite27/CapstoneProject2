using System;

namespace CapstoneProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Librarian cs1 = new Librarian();
            cs1.Librarian1("Google Digital Library");
            int menu = -1;

            Console.WriteLine("\n\t\t\t  **-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**\n");
            Console.WriteLine("\n\t\t\t        =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("\n\t\t\t        =                 WELCOME                   =");
            Console.WriteLine("\n\t\t\t        =                   TO                      =");
            Console.WriteLine("\n\t\t\t        =                 LIBRARY                   =");
            Console.WriteLine("\n\t\t\t        =               MANAGEMENT                  =");
            Console.WriteLine("\n\t\t\t        =                 SYSTEM                    =");
            Console.WriteLine("\n\t\t\t        =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("\n\t\t\t  **-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**\n");


            while (menu != 0)
            {
                Console.WriteLine("\n\t\t\t\t*****Welcome to {0}*****\n", cs1.LibraryName);
                Console.WriteLine("Please Choose one of the option below ");
                Console.WriteLine("------------------");
                Console.WriteLine("|  1. Librarian  |");
                Console.WriteLine("|  2. Borrower   |");
                Console.WriteLine("|  0  EXIT       |");
                Console.WriteLine("------------------");
                Console.Write("Enter your choice: ");
                string menuInput = Console.ReadLine();
                int.TryParse(menuInput, out menu);

                switch (menu)
                {
                    case 0:
                        Console.WriteLine("--- Thank you");
                        break;
                    case 1:
                        Console.WriteLine("***************************");
                        Console.WriteLine("Enter UserName and Password");
                        Console.WriteLine("***************************");
                        Console.Write("Enter UserName : ");
                        string username = Console.ReadLine();
                        Console.Write("Password : ");
                        string password = Console.ReadLine();
                        Console.WriteLine("***************************");
                        if (cs1.LibrarianCheck(username, password) == true)
                        {

                            int num1 = -1;
                            while (num1 != 0)
                            {
                                Console.WriteLine(); Console.WriteLine("\n\t\t\t\t*****Welcome Librarian to {0}*****\n", cs1.LibraryName);
                                Console.WriteLine("Please Choose one of the option below ");
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("|   1. Add Book                 |");
                                Console.WriteLine("|   2. Remove Book              |");
                                Console.WriteLine("|   3. Search Book              |");
                                Console.WriteLine("|   4. Display Book List        |");
                                Console.WriteLine("|   5. Display Issue Book List  |");
                                Console.WriteLine("|   6. Filter Book              |");
                                Console.WriteLine("|   0  EXIT                     |");
                                Console.WriteLine("--------------------------------");

                                Console.Write("Enter your choice: ");
                                string menuInput1 = Console.ReadLine();
                                int.TryParse(menuInput1, out num1);
                                switch (num1)
                                {
                                    case 0:
                                        Console.WriteLine("--- Thank you");
                                        break;
                                    case 1:
                                        cs1.AddBook();
                                        break;
                                    case 2:
                                        cs1.RemoveBook();
                                        break;
                                    case 3:
                                        Console.WriteLine("1. Search by ID");
                                        Console.WriteLine("2. Search by Name");
                                        int n = Convert.ToInt32(Console.ReadLine());
                                        cs1.SearchBook(n, menu);
                                        break;
                                    case 4:
                                        cs1.DisplayAllBooks(menu);
                                        break;
                                    case 5:
                                        cs1.DisplayIssueBooks();
                                        break;
                                    case 6:
                                        Console.WriteLine("1. By Name");
                                        Console.WriteLine("2. By Price");
                                        Console.WriteLine("3. By Type");
                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        cs1.check(choice);
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Choice");
                                        break;
                                }
                            }
                        }
                        break;
                        
                    case 2:
                        int num2 = -1;
                        while (num2 != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("\n\t\t\t\t*****Welcome Borrower to {0}*****\n", cs1.LibraryName);
                            Console.WriteLine("Please Choose one of the option below ");
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("|   1. Display Book List  |");
                            Console.WriteLine("|   2. Search Book        |");
                            Console.WriteLine("|   3. Filter Book        |");
                            Console.WriteLine("|   4. Issue Book         |");
                            Console.WriteLine("|   5. Return Book        |");
                            Console.WriteLine("|   0  EXIT               |");
                            Console.WriteLine("---------------------------");
                            Console.Write("Enter your choice: ");
                            string menuInput2 = Console.ReadLine();
                            int.TryParse(menuInput2, out num2);
                            switch (num2)
                            {
                                case 0:
                                    Console.WriteLine("--- Thank you");
                                    break;
                                case 1:
                                    cs1.DisplayAllBooks(menu);
                                    break;
                                case 2:
                                    Console.WriteLine("1. Search by ID");
                                    Console.WriteLine("2. Search by Name");
                                    int n = Convert.ToInt32(Console.ReadLine());
                                    cs1.SearchBook(n,menu);
                                    break;
                                case 3:
                                    Console.WriteLine("1. By Name");
                                    Console.WriteLine("2. By Price");
                                    Console.WriteLine("3. By Type");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    cs1.check(choice);
                                    break;
                                case 4:
                                    cs1.IssueBook();
                                    break;
                                case 5:
                                    cs1.ReturnBook();
                                    break;
                                default:
                                    Console.WriteLine("Invalid Choice");
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
