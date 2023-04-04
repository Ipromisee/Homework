using System;

namespace OrderApp {

  public class Goods {

    public int Id { get; set; }

    public string Name { get; set; }

    private double price;

    public double Price {
      get { return price; }
      set {
        if (value < 0)
          throw new ArgumentException("the price must >= 0!");
        price = value;
      }
    }

    public Goods() { }

    public Goods(int id, string name, double price) {
      this.Id = id;
      this.Name = name;
      this.Price = price;
    }

    public override bool Equals(object obj) {
      var goods = obj as Goods;
      return goods != null && Id == goods.Id;
    }

    public override int GetHashCode() {
      return 2108858624 + Id.GetHashCode();
    }

    public override string ToString() {
      return $"{Name}";
    }

  }
}