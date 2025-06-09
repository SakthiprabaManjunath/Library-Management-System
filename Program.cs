// See https://aka.ms/new-console-template for more information*using System.Collections.Concurrent;
using System.Net;
using System.Reflection;
using libraryManagement;

//Object for book class
try
{
    Book b1 = new Book("Think like a Monk", "Jay Shetty", "sas");
    Book b2 = new Book("Psychology of Money", "Morgan Housel", "pas");
    Magazine m1 = new Magazine("ID-124", "Chandamama", 120);
    Dvd d1 = new Dvd("My title", "abc", "def");
    FineCalculate f1 = new FineCalculate(14);
    b1.DisplayDetails();
    b2.DisplayDetails();
    m1.ShowDetails();
    d1.DvdDetails();
    f1.ShowFine();
}
catch (InvalidBookException e)
{
    Console.WriteLine($"Error: {e.Message}");
}


// LibraryItem l1 = new LibraryItem { Id = "sa", Title = "The book" };
