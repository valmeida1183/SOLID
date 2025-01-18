namespace SOLID.LSP.Bad;

public class SavingsAccount : BankAccount
{
    public decimal Balance { get; set; }

    public override void WithDraw(decimal amount)
    {
        if (Balance < amount)
            throw new Exception("Insufficient balance"); 
        
        Balance -= amount;
        Console.WriteLine($"Withdraw {amount}");
    }
}
