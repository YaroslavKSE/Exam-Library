namespace Exam.Library;

public interface IReaderNotifier
{
    Task Notify(Guid userId, string message);
}