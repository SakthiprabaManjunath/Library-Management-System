namespace libraryManagement;

class Dvd : LibraryItem
{
    public string Duration { get; set; }
    public string Volume { get; set; }

    public Dvd(string title,string duration, string volume) : base(title) {
        duration = Duration;
        volume = Volume;
    }
    public void DvdDetails() {
        Console.WriteLine($"{Title} {Duration}  {Volume}");
    }
}