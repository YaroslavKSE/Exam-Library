using Exam.Library.Interfaces;

namespace Exam.Library;

public class BorrowingService : IBookBorrower, IJournalTaker, IReaderNotifier
{
    private Library _library;

    public BorrowingService(Library library)
    {
        _library = library;
    }

    public Task<bool> BorrowBook(Reader reader, string title)
    {
        if (reader.CanIncreaseBorrowAmount())
        {
            var item = _library.GetItem(title);
            if (item.IsAvailable)
            {
                item.BorrowItem();

                Notify(reader.ReaderId, "The book is borrowed");
                Task.FromResult(true);
            }
            else
            {
                Notify(reader.ReaderId, "The book is not available");
                return Task.FromResult(false);
            }
        }

        return Task.FromResult(false);
    }

    public Task<bool> Take(Reader reader, string title)
    {
        var item = _library.GetItem(title);
        if (item.IsAvailable)
        {
            item.BorrowItem();

            Notify(reader.ReaderId, "The journal is taken");
            Task.FromResult(true);
        }
        else
        {
            Notify(reader.ReaderId, "The journal is not available");
            return Task.FromResult(false);
        }
        return Task.FromResult(false);
    }

    public Task Notify(Guid userId, string message)
    {
        throw new NotImplementedException();
    }
}