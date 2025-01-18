namespace SOLID.ISP.Good;
public class ContractEmployee : ISalaryCalculator
{
    public required string Name { get; set; }
        
    public void CalculateSalary()
    {
        Console.WriteLine("Contract salary");
    }
}
