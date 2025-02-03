namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the library system");

            Library library = new Library();

            Console.WriteLine("Are you librarian or regular user ? (L/R)");

            char userType = Console.ReadLine().ToUpper()[0];

            if (userType == 'L')
            {
                Console.WriteLine($"Enter your name ...\t");
                string librarianName = Console.ReadLine();

                Librarian librarian = new Librarian(librarianName);

                Console.WriteLine($"Welcome {librarian.Name}");

                while (true)
                {

                    Console.WriteLine("Please Choose To Add Book (A) / Remove Book (R) / Display Book (D)");

                    char choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter book details");
                            Console.Write("Enter Book Name: ");
                            string bookName = Console.ReadLine();
                            Console.Write("Enter Book Author: ");
                            string bookAuthor = Console.ReadLine();
                            Console.Write("Enter Book Year: ");
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            librarian.AddBook(book, library);

                            break;
                        case 'R':
                            Console.WriteLine("Enter book details");
                            Console.Write("Enter Book Name: ");
                            bookName = Console.ReadLine();
                            Console.Write("Enter Book Author: ");
                            bookAuthor = Console.ReadLine();
                            Console.Write("Enter Book Year: ");
                            bookYear = Convert.ToInt32(Console.ReadLine());
                            book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            librarian.RemoveBook(book, library);

                            break;
                        case 'D':
                            Console.WriteLine("The Books List :");
                            librarian.DisplayBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }

            }
            else if (userType == 'R')
            {
                Console.WriteLine($"Enter your name ...\t");
                string name = Console.ReadLine();

                LibraryUser libraryUser = new LibraryUser(name);

                Console.WriteLine($"Welcome {libraryUser.Name}");

                while (true)
                {
                    Console.WriteLine("Please Choose To Borrow (B) / Display Book (D)");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'B':
                            Console.WriteLine("Enter book details");
                            Console.Write("Enter Book Name: ");
                            string bookName = Console.ReadLine();
                            Console.Write("Enter Book Author: ");
                            string bookAuthor = Console.ReadLine();
                            Console.Write("Enter Book Year: ");
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            libraryUser.Borrow(book, library);

                            break;
                        case 'D':
                            Console.WriteLine("The Books List :");
                            libraryUser.Display(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }

                }
            }
            else
            {
                Console.WriteLine("Please enter correct value (L or R)");
            }

        }
    }
}
