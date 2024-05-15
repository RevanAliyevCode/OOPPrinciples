// See https://aka.ms/new-console-template for more information
using LibaryTask;

Books books = new("Dune", "Frank herbert", 16m);
Books books1 = new("Dune Mesiah", "Frank herbert", 16m);
Libary libary = new("Liberaff");

libary.AddBook(books);
libary.AddBook(books1);

libary.RemoveBook(books);
libary.RemoveBook(books);

libary.GetBooksDetails();