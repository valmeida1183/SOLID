namespace SOLID.OCP.Good;

public class BeautyDiscount : Discount
{
  public override decimal Calculate(decimal price)
    => price * 0.4M;
}