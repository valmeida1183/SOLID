namespace SOLID.ISP.Bad;
public class FullTimeEmployee : IEmployee
{
    public required string Name { get; set; }

    public void CalculateBenefits()
    {
        Console.WriteLine("Full Time Benefits");
    }

    public void CalculateSalary()
    {
        Console.WriteLine("Full Time Salary");
    }
}
