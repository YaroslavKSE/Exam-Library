namespace Exam.Library.Interfaces;

public interface IJournalTaker
{
    Task<bool> Take(Reader reader, string title);
}