using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace LibaryTask
{
    public class Libary
    {
        private Books[] books = [];
        public string Name { get; set; }
        public int BookLimit { get; } = 300; 
        public Books[] Books { get => books; }

        public Libary(string name)
        {
            Name = name;
        }

        public void AddBook(Books book)
        {
            if (BookLimit > books.Length)
            {
                Array.Resize(ref books, books.Length + 1);
                books[books.Length - 1] = book;
            }
            else Console.WriteLine("We do not have space");
        }

        public void RemoveBook(Books book)
        {
            int index = Array.IndexOf(books, book);

            if (index != -1)
            {
                for (int i = index; i < books.Length - 1; i++)
                {
                    Books[i] = Books[i + 1];
                }

                Array.Resize(ref books, books.Length - 1);
            }
            else Console.WriteLine("We do not have a book like that");
        }

        public void GetBooksDetails()
        {
            foreach (var book in books) Console.WriteLine($"Book Name: {book.Name}, Book Author: {book.Author}, Book Price: {book.Price}");
        }
    }
}
