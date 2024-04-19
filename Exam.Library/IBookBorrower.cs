using Exam.Library.LibraryItems;

namespace Exam.Library;

public interface IBookBorrower
{
    Task<bool> BorrowBook(Reader reader, Book book);
}