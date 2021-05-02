using System;

namespace Dealership.Models
{
  public class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;
  
  public void SetPrice(int newprice)
  {
    _price = newprice;
  }

  public static string MakeSound(string sound)
  {
    return "Lonnys Lemons where all the cars have sound like" + sound;
  }

  public static string Disclaimer()
  {
    return "We only sell cars that get you from A to B";
  }
public Car(string makeModel, int price, int miles)
{
  _makeModel = makeModel;
  _price = price;
  _miles = miles;
}

public string GetMakeModel()
{
  return _makeModel;
}

public int GetPrice()
{
  return _price;
}

public int GetMiles()
{
  return _miles;
}
  public bool WorthBuying(int maxPrice)
  {
    return (_price <= maxPrice);
  }
}
}