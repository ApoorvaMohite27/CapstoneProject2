using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.ComponentModel;
using System.Collections.Specialized;

namespace CapstoneProject2
{
    public class T
    { 
        private static int CustomerIdCounter;
        static T()
        {
            T.CustomerIdCounter = 0;
        }
        public T()
        {
            this._CustomerId = ++T.CustomerIdCounter;
        }
        private int _CustomerId;
        public int CustomerId
        {
            get
            {
                return _CustomerId;
            }
        }
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string CustomerName { get; set; }
        public DateTime IssueDateTime { get; set; }
        public int RemQuantity { get; set; }
        public DateTime ReturnDateTime { get; set; }
    }
    class Librarian : Task_To_Do
    {
        public List<Book> Books;
        public List<T> Lists { get; set; } = new List<T>();

        public string LibraryName { get; private set; }
        
        public void Librarian1(string name){
            this.LibraryName = name;
            Books = new List<Book>();
 
        }
        private string _username = "GDL";
        private string _password = "GDL@2022";

        public Boolean LibrarianCheck(string username, string password)
        {
            if (username == null || password == null)
            {
                Console.WriteLine("Invalid Input");
                return false;
            }
            else if (username != this._username || password != this._password)
            {
                Console.WriteLine("Invalid UserName and Password");
                return false;
            }
            return true;
        }

        public void AddBook()
        {
            Book book = new Book();

            Console.WriteLine();
            Console.WriteLine("Enter details of the Book");
            Console.Write("Book Name : ");
            book.BookName = Console.ReadLine();
            Console.Write("Author : ");
            book.Author = Console.ReadLine();
            Console.Write("Publication : ");
            book.Publication = Console.ReadLine();
            Console.Write("Type : ");
            book.Type = Console.ReadLine();
            book.AddDateTime = DateTime.Now;
            Console.Write("Quantity : ");
            book.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Price : ");
            book.Price = decimal.Parse(Console.ReadLine());
            book.RemQuantity = book.Quantity;

            this.Books.Add(book);
        }

        public void RemoveBook()
        {
            Console.Write("Enter the ID of the Book to remove : ");
            int id = int.Parse(Console.ReadLine());
            for(int i = 0; i < Books.Count; i++)
            {
                Book b = this.Books[i] as Book;
                if(b.BookId == id)
                {
                    this.Books.Remove(b);
                    break;
                }
                else
                {
                    Console.WriteLine("Input is Invalide !!!");
                }
            }
        }

        public void DisplayAllBooks(int menu)
        {
            Console.WriteLine();
            Console.WriteLine($"List of Books :");
            if (menu == 1)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-20} {5,-20} {6,10} {7,15} {8,15} {9,10}", "BookID", "Book Name", "Author", "Publication", "Type" , "DateTime", "Quantity", "Price", "Cost","RemQuant");
                foreach (Book b in this.Books)
                {
                    Console.WriteLine(b);
                }
                Console.WriteLine();
            }
            else if(menu == 2)
            {
                Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,15}", "BookID", "Book Name", "Author", "Publication", "Type", "Price");

                foreach (Book b in this.Books)
                {
                    Console.WriteLine($"{b.BookId,-10} {b.BookName,-20} {b.Author,-20} {b.Publication,-20} {b.Type,-20} {b.Price,15:C}");
                }
                Console.WriteLine();
            }
        }
        
        public void SearchBook(int n,int menu)
        {
            if (n == 1)
            {
                Console.WriteLine("Enter the ID of the Book to search :");
                int id = int.Parse(Console.ReadLine());

                for(int i = 0; i < Books.Count; i++)
                {
                    Book b = this.Books[i] as Book;
                    if (b.BookId == id   &&   menu==2)
                    {
                        Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,15}", "BookID", "Book Name", "Author", "Publication", "Type", "Price");
                        Console.WriteLine($"{b.BookId,-10} {b.BookName,-20} {b.Author,-20} {b.Publication,-20} {b.Type,-20} {b.Price,15:C}");
                        break;
                    }
                    else if(b.BookId == id && menu == 1)
                    {
                        Console.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-20} {5,-20} {6,10} {7,15} {8,15} {9,10}", "BookID", "Book Name", "Author", "Publication", "Type", "DateTime", "Quantity", "Price", "Cost", "RemQuant");
                        Console.WriteLine($"{b.BookId,-5} {b.BookName,-20} {b.Author,-20} {b.Publication,-20} {b.Type,-20} {b.AddDateTime,-20} {b.Quantity,10} {b.Price,15:C} {b.Cost,15:C} {b.RemQuantity,10}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Input is Invalide !!!");
                        break;
                    }
                }
            }
            else if (n == 2)
            {
                Console.WriteLine("Enter the Name of the Book to search :");
                string name = Console.ReadLine();

                for (int i = 0; i < Books.Count; i++)
                {
                    Book b = this.Books[i] as Book;
                    if (b.BookName == name && menu == 2)
                    {
                        Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,15}", "BookID", "Book Name", "Author", "Publication", "Type", "Price");
                        Console.WriteLine($"{b.BookId,-10} {b.BookName,-20} {b.Author,-20} {b.Publication,-20} {b.Type,-20} {b.Price,15:C}");
                        break;
                    }
                    else if (b.BookName == name && menu == 1)
                    {
                        Console.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-20} {5,-20} {6,10} {7,15} {8,15} {9,10}", "BookID", "Book Name", "Author", "Publication", "Type", "DateTime", "Quantity", "Price", "Cost", "RemQuant");
                        Console.WriteLine($"{b.BookId,-5} {b.BookName,-20} {b.Author,-20} {b.Publication,-20} {b.Type,-20} {b.AddDateTime,-20} {b.Quantity,10} {b.Price,15:C} {b.Cost,15:C} {b.RemQuantity,10}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Input is Invalide !!!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }

        public void IssueBook()
        {
            Console.WriteLine("Enter the ID of the Book :");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < Books.Count; i++)
            {
                Book b = this.Books[i] as Book;
                if (b.BookId == id)
                {
                    if (b.RemQuantity != 0)
                    {
                        T book = new T();
                        book.RemQuantity = b.RemQuantity;
                        book.BookId = b.BookId;
                        book.BookName = b.BookName;
                        Console.WriteLine("Enter Your Name :");
                        book.CustomerName = Console.ReadLine();
                        book.IssueDateTime = DateTime.Now;
                        b.RemQuantity--;
                        book.RemQuantity--;
                        this.Lists.Add(book);

                        Console.WriteLine("Successfully Issued!!");
                        Console.WriteLine($"The Book {book.BookName} is issued by {book.CustomerName}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry No Books Left!!!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Input is Invalide !!!");
                }
            }
        }

        public void ReturnBook()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the ID of the Book :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Name :");
            string name = Console.ReadLine();
            for (int i = 0; i < Lists.Count; i++)
            {
                T t = this.Lists[i] as T;
                Book b = this.Books[i] as Book;
                if (t.BookId == id  && t.CustomerName == name  &&  b.Quantity!=t.RemQuantity)
                {
                    t.ReturnDateTime = DateTime.Now;
                    t.RemQuantity++;
                    b.RemQuantity++;
                    this.Lists[i] = t;

                    Console.WriteLine("Successfully Returned!!");
                    Console.WriteLine($"The Book {t.BookName} is returned by {t.CustomerName}");
                    break;
                }
                else
                {
                    Console.WriteLine("Failed!!");
                    break;
                }
            }
        }

        public void DisplayIssueBooks()
        {
            Console.WriteLine();
            Console.WriteLine($"List of Books :");
            Console.WriteLine("{0,-10} {1,-10} {2,-25} {3,-20} {4,-25} {5,-25} {6,10}", "CustID", "BookID", "Book Name", "Customer Name", "issueDateTime", "returnDateTime", "RemQuant");

            foreach (T b in this.Lists)
            {
                Console.WriteLine($"{b.CustomerId,-10}{b.BookId,-10} {b.BookName,-25} {b.CustomerName,-20} {b.IssueDateTime,-25} {b.ReturnDateTime,-25} {b.RemQuantity,10}");
            }
            Console.WriteLine();

        }

        public void check(int choice)
        {
            if (choice == 1)
            {
                var queryN = from b in Books
                             orderby b.BookName ascending
                             select b;
                Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,15}", "BookID", "Book Name", "Author", "Publication", "Type", "Price");
                foreach (var b in queryN)
                {
                    Console.WriteLine($"{b.BookId,-10} {b.BookName,-20} {b.Author,-20} {b.Publication,-20} {b.Type,-20} {b.Price,15:C}");
                }
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                var query = from b in Books
                            orderby b.Price ascending
                            select b;
                Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,15}", "BookID", "Book Name", "Author", "Publication", "Type", "Price");
                foreach (var b in query)
                {
                    Console.WriteLine($"{b.BookId,-10} {b.BookName,-20} {b.Author,-20} {b.Publication,-20} {b.Type,-20} {b.Price,15:C}");
                }
                Console.WriteLine();
            }
            else if (choice == 3)
            {
                Console.WriteLine();
                Console.WriteLine("1. Novel");
                Console.WriteLine("2. Comic");
                Console.WriteLine("3. Adventure");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        var query1 = Books.Where(b => b.Type == "Novel");
                        Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,15}", "BookID", "Book Name", "Author", "Publication", "Type", "Price");
                        foreach (var q1 in query1)
                        {
                            Console.WriteLine($"{q1.BookId,-10} {q1.BookName,-20} {q1.Author,-20} {q1.Publication,-20} {q1.Type,-20} {q1.Price,15:C}");
                        }
                        break;
                    case 2:
                        var query2 = Books.Where(b => b.Type == "Comic");
                        Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,15}", "BookID", "Book Name", "Author", "Publication", "Type", "Price");
                        foreach (var q2 in query2)
                        {
                            Console.WriteLine($"{q2.BookId,-10} {q2.BookName,-20} {q2.Author,-20} {q2.Publication,-20} {q2.Type,-20} {q2.Price,15:C}");
                        }
                        break;
                    case 3:
                        var query3 = Books.Where(b => b.Type == "Adventure");
                        Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,15}", "BookID", "Book Name", "Author", "Publication", "Type", "Price");
                        foreach (var q3 in query3)
                        {
                            Console.WriteLine($"{q3.BookId,-10} {q3.BookName,-20} {q3.Author,-20} {q3.Publication,-20} {q3.Type,-20} {q3.Price,15:C}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

    }
}
