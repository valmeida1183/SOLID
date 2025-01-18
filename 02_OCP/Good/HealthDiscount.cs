namespace SOLID.OCP.Good;

public class HealthDiscount : Discount
{
  public override decimal Calculate(decimal price)
    => price * 0.3M;
}