namespace SOLID.ISP.Good;
public class FullTimeEmployee : ISalaryCalculator, IBenefitsCalculator
{
    public required string Name { get; set; }

    public void CalculateBenefits()
    {
        Console.WriteLine("Full Time Benefits");
    }

    public void CalculateSalary()
    {
        Console.WriteLine("Full Time salary");
    }
}
