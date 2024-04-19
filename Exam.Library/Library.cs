//Database

using Exam.Library.LibraryItems;

namespace Exam.Library;

public class Library
{
    private Dictionary<string, LibraryItem> _libraryItems;

    public Library(Dictionary<string, LibraryItem> libraryItems)
    {
        _libraryItems = libraryItems;
    }
    
    public void AddItem(LibraryItem item, int copies)
    {
        for (int i = 0; i < copies; i++)
        {
            if (item is Book book)
            {
                var title = book?.Title;
                if (title != null) _libraryItems.Add(title, book);
            }
            
            else if (item is Journal journal)
            {
                var title = journal?.Title;
                if (title != null) _libraryItems.Add(title, journal);
            }
                
        }
    }
    public LibraryItem GetItem(string title)
    {
        if (!_libraryItems.ContainsKey(title))
            throw new KeyNotFoundException("Item not found in the library.");

        return _libraryItems[title];
    }
}