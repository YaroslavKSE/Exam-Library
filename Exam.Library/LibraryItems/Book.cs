namespace Exam.Library.LibraryItems;

public class Book : LibraryItem
{
    private string Author { get; set; }
    
    private int IsbnId { get; set; }

    private DateTime PrintYear { get; set; }
    
    private int Copies { get; set; }
    
    public DateTime ReturningDeadline { get; private set; }
    
    public Book(string title, string author, int isbnId, DateTime printYear, int copies) : base(title)
    {
        Author = author;
        IsbnId = isbnId;
        PrintYear = printYear;
        Copies = copies;
    }
    
    public void Return(string userId)
    {
        Copies++;
        IsAvailable = true;
    }

    public override bool BorrowItem()
    {
        if (!IsAvailable)
        {
            return false;
        }

        Copies--;
        IsAvailable = Copies > 0;
        ReturningDeadline = DateTime.Now.AddDays(14);
        return true;

        
    }
}