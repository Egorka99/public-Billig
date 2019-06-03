using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy;
using Decorator;
using Visitor;


namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            void strategy()
            {
                //Создаем контекст и инициализируем его первой стратегией
                Context context = new Context(new ConcreteStrategy1());
                //Выполняем операцию (алгоритм) первой стратегии
                context.ExecuteOperation();
                //Заменяем в context первую стратегию на вторую
                context.SetStrategy(new ConcreteStrategy2());
                //Выполняем операцию (алгоритм) теперь уже второй стратегии
                context.ExecuteOperation();
                Console.ReadKey();
            }
         

           void Decorator()
            {
                Pizza pizza1 = new ItalianPizza();
                pizza1 = new TomatoPizza(pizza1); // итальянская пицца с томатами
                Console.WriteLine("Название: {0}", pizza1.Name);
                Console.WriteLine("Цена: {0}", pizza1.GetCost());

                Pizza pizza2 = new ItalianPizza();
                pizza2 = new CheesePizza(pizza2);// итальянская пиццы с сыром
                Console.WriteLine("Название: {0}", pizza2.Name);
                Console.WriteLine("Цена: {0}", pizza2.GetCost());

                Pizza pizza3 = new BulgerianPizza();
                pizza3 = new TomatoPizza(pizza3);
                pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
                Console.WriteLine("Название: {0}", pizza3.Name);
                Console.WriteLine("Цена: {0}", pizza3.GetCost());

                Console.ReadLine();
            }
            void Visitor()
            {
                List<Auto> collection = new List<Auto>();
                collection.Add(new Car { ModelTitle = "ВАЗ" });
                collection.Add(new Track { ModelTitle = "ГАЗель" });
                collection.Add(new Car { ModelTitle = "Merсedes" });
                collection.Add(new Track { ModelTitle = "КамАЗ" });
                IVisitor visitor = new AutoVisitor();
                foreach (Auto a in collection)
                {
                    a.Accept(visitor);
                }
                Console.ReadKey();
            }
            // Decorator();
            //  strategy();
            Visitor();
        }
    }
}
