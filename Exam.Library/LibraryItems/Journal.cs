namespace Exam.Library.LibraryItems;

public class Journal : LibraryItem
{
    private string Country { get; set; }
    private DateTime IssueDate { get; set; }
    public bool IsAvailable { get; private set; }
    
    public Journal(string title, string country, DateTime issueDate) : base(title)
    {
        Country = country;
        IssueDate = issueDate;
        IsAvailable = true;
    }
    public void Take(Guid userId)
    {
        if (!IsAvailable)
            throw new InvalidOperationException("This journal is not available.");
        
        IsAvailable = false;
    }

    public void Return(Guid userId)
    {
        IsAvailable = true;
    }
    
}