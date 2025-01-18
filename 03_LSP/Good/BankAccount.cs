namespace SOLID.LSP.Good;

public abstract class BankAccount
{
    public decimal Balance { get; protected set; }

    public abstract void Withdraw(decimal amount);
}
