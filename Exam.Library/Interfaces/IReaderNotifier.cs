namespace Exam.Library.Interfaces;

public interface IReaderNotifier
{
    Task Notify(Guid userId, string message);
}