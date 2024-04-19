namespace Exam.Library.Interfaces;

public interface IBookBorrower
{
    Task<bool> BorrowBook(Reader reader, string title);
}