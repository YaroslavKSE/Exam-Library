namespace Exam.Library.LibraryItems;

public class Book : LibraryItem, IBookBorrower
{
    private string Author { get; set; }
    
    private int IsbnId { get; set; }

    private DateTime PrintYear { get; set; }
    
    public bool IsAvailable { get; private set; }
    
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

    public Task<bool> BorrowBook(Reader reader, Book book)
    {
        if (!IsAvailable)
        {
            throw new InvalidOperationException("All copies of this book are borrowed.");
        }

        if (reader.CanIncreaseBorrowAmount())
        {
            Copies--;
            IsAvailable = Copies > 0;
            ReturningDeadline = DateTime.Now.AddDays(14);
            return Task.FromResult(true);
        }

        return Task.FromResult(false);
        
    }
}