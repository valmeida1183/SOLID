namespace SOLID.LSP.Bad;

public class BankAccount
{
    public virtual void WithDraw(decimal amount)
    {
        Console.WriteLine($"Withdraw {amount}");
    }
}
