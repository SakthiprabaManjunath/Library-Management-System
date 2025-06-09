using System.Dynamic;

namespace libraryManagement;

public class LibraryItem
{

    public string Title { get; set; }
    public LibraryItem(string title)
    {
        Title = title;
    }



    // class FineCalculate
    // {
    //     public int Overdue{get ; set ;}
    //     public FineCalculate(int overdue) {
    //         Overdue = overdue;
    //     }

    //     public void ShowFine() {
    //         Console.WriteLine("No of days: " + Overdue);
    //     }
    // }
}