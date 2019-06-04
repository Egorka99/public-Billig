using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  public  abstract class Pizza
    {
        public Pizza(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();
    }

   public class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Итальянская пицца")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }
    public class BulgerianPizza : Pizza
    {
        public BulgerianPizza() : base("Болгарская пицца")
        { }
        public override int GetCost()
        {
            return 8;
        }
    }

  public  abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(string n, Pizza pizza) : base(n)
        {
            this.pizza = pizza;
        }
    }

   public class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza p): base(p.Name + ", с томатами", p)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 3;
        }
    }

   public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza p): base(p.Name + ", с сыром", p)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 5;
        }
    }
}
