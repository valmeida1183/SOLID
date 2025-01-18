namespace SOLID.ISP.Bad;
public class ContractEmployee : IEmployee
{
    public required string Name { get; set; }

    public void CalculateBenefits()
    {
        throw new NotImplementedException();
    }

    public void CalculateSalary()
    {
        Console.WriteLine("Contract salary");
    }
}
