namespace SOLID.ISP.Bad;
public interface IEmployee
{
    string Name { get; set; }
    void CalculateSalary();
    void CalculateBenefits();
}
