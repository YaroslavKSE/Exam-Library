namespace Exam.Library.LibraryItems;

public class Journal : LibraryItem
{
    private string Country { get; set; }
    private DateTime IssueDate { get; set; }
    
    public Journal(string title, string country, DateTime issueDate) : base(title)
    {
        Country = country;
        IssueDate = issueDate;
        IsAvailable = true;
    }

    public void Return(Guid userId)
    {
        IsAvailable = true;
    }

    public override bool BorrowItem()
    {
        if (!IsAvailable)
        {
            return false;
        }

        IsAvailable = false;
        return true;
    }
}