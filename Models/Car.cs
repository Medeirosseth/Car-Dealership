using System;

namespace Dealership.Models
{
  public class Car
{
  private string MakeModel {get; set;} 
  private int Price {get; set;}
  private int Miles {get; set;}
  
  public void SetPrice(int newprice)
  {
    Price = newprice;
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
  MakeModel = makeModel;
  Price = price;
  Miles = miles;
}

public string GetMakeModel()
{
  return MakeModel;
}

public int GetPrice()
{
  return Price;
}

public int GetMiles()
{
  return Miles;
}
  public bool WorthBuying(int maxPrice)
  {
    return (Price <= maxPrice);
  }
}
}