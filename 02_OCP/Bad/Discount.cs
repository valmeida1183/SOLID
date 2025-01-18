namespace SOLID.OCP.Bad;

public enum EProductType
{
  Electronics = 1,
  Health = 2,
  Beauty = 3,
  Fashion = 4
}

public class Discount
{
  public decimal Calculate(EProductType type, decimal price)
  {
    if (type == EProductType.Electronics)
      return price * 0.2M;
    else if (type == EProductType.Health)
      return price * 0.3M;
    else if (type == EProductType.Beauty)
      return price * 0.4M;
    else if (type == EProductType.Fashion)
      return price * 0.5M;
    else
      return price;
  }
}