namespace SOLID.OCP.Good;

public class FashionDiscount : Discount
{
  public override decimal Calculate(decimal price)
    => price * 0.5M;
}