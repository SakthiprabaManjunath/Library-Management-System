using System.Reflection.Metadata;

using libraryManagement;
class FineCalculate
{
    public int Overdue { get; set; }
    public FineCalculate(int overdue)
    {
        Overdue = overdue;
    }



    public void ShowFine()
    {
        Console.WriteLine("No of days : " + Overdue);
        Console.WriteLine("Fine Amount :" + Overdue * 5);
        Console.WriteLine("Are you a member: ");
        string Member = Console.ReadLine();
        if (Member == "yes" || Member == "no")
        {
            int FineAmount = Overdue * 5;
            if (Member == "yes")
            {
                Console.WriteLine(" " + FineAmount);
            }
            else
            {
                Console.WriteLine($"{FineAmount - 5}");
            }
        }
        else
        {
            Console.WriteLine("Invalid!!!! Type only yes or no");
        }
        
    }
}
