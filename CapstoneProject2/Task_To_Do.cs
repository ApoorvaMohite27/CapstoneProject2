using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CapstoneProject2
{
    interface Task_To_Do
    {
        void AddBook();
        void RemoveBook();
        void DisplayAllBooks(int x);
        void SearchBook(int a, int b);
        void IssueBook();
        void ReturnBook();
        void DisplayIssueBooks();
        void check(int n);
    }
}
