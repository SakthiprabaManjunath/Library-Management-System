/*namespace LibraryManagement;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Title : {Title}");
        Console.WriteLine($"Author : {Author}");
        Console.WriteLine($"ISBN : {ISBN}");
    }

}*/


using System.Dynamic;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace libraryManagement;

class Book : LibraryItem
{

    string Author { get; set; }
    string ISBN { get; set; }
    public Book(string title, string author, string iSBN) : base(title)
    {
        Title = title;
        Author = author;
        ISBN = iSBN;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"{Title} {Author}");
        
    }

}


// class Dvd : LibraryItem
// {
//     string issuenumber { get; set; }
//     string duration { get; set; }
//     public Dvd(string IssueNumber, string Duration): base(Title)
//     {
//         IssueNumber = issuenumber;
//         Duration = duration;
//     }
// }

// public void ShowDetails() {
//     PublicKey static void Main()
//     {
//         Console.WriteLine($"Title is {title}");
//     }
// }

