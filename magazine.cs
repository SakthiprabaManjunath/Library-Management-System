namespace libraryManagement;

class Magazine : LibraryItem
{
    public string Id { get; set; }
    public string Title { get; set; }
    public int IssueNumber { get; set; }
    //constructor for magazine
    public Magazine(string id, string title, int issueNumber) : base(title)
    {
        Id = id;
        Title = title;
        IssueNumber = issueNumber;

    }
    public void ShowDetails()
    {
        Console.WriteLine($"{Id} {Title} {IssueNumber}");
    }
    

}