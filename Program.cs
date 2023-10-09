using System;

namespace myApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Product mouse = new(Guid.NewGuid(), "Mouse Gamer RGB 3000", 299.90, EDiscount.TenPercent);
      string text = $"The product price is: {mouse.Price} on {(int)mouse.Discount}% promotion";
      Console.WriteLine(text);
    }


  }
  struct Product
  {
    public Product(Guid id, string name, double price, EDiscount discount)
    {
      Id = id;
      Name = name;
      Price = price;
      Discount = discount;
    }

    public Guid Id;
    public string Name;
    public double Price;
    public EDiscount Discount;
  }

  enum EDiscount
  {
    TenPercent = 10,
    TwentyPercent = 20
  }
}
