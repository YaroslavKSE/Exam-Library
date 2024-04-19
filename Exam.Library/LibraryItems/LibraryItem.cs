namespace Exam.Library.LibraryItems;

public abstract class LibraryItem
{
    protected LibraryItem(string title)
    {
        Title = title;
    }

    public string Title { get; private set; }
}