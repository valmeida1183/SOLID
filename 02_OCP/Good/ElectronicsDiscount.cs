namespace SOLID.OCP.Good;

public class ElectronicsDiscount : Discount
{
  public override decimal Calculate(decimal price)
    => price * 0.2M;
}