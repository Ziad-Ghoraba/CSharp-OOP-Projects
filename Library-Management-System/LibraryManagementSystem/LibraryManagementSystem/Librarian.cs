using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Librarian : User
    {
       public int EmployeeNumber { get; set; }

        public void AddBook(Book book, Library library)
        {
            library.Add(book);
        }

        public void RemoveBook(Book book, Library library)
        {
            library.Remove(book);
        }

        public Librarian(string name)
        {
            Name = name;
        }

        public void DisplayBooks(Library library)
        {
            library.Display();
        }
    }
}
