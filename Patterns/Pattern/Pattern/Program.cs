using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy;

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
            strategy();


        }
    }
}
