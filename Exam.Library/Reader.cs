namespace Exam.Library;

public abstract class Reader
{
    private Guid ReaderId { get; set; }
    protected int CurrentBorrowAmount { get; private set; }
    protected int MaxBorrowAmount;

    protected Reader()
    {
        ReaderId = new Guid();
    }

    public void ChangeMaxBorrowAmount(int newAmount)
    {
        CurrentBorrowAmount = 0;
        MaxBorrowAmount = newAmount;
    }

    private bool CanBorrowBook()
    {
        if (CurrentBorrowAmount < MaxBorrowAmount)
        {
            return true;
        }

        return false;
    }

    public bool CanIncreaseBorrowAmount()
    {
        if (CanBorrowBook())
        {
            CurrentBorrowAmount++;
            return true;
        }

        return false;
    }
}