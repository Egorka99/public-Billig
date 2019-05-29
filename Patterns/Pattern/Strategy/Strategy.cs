using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //Этот интерфейс, должен наследовать класс, реализующий конкреную стратегию
    //Класс Context использует данный интерфейс для вызова конкретной стратегии
    public interface IStrategy
    {
        void Algorithm();
    }

    //Первая конкретная реализация-стратегия
    public class ConcreteStrategy1 : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Выполняется алгоритм стратегии номер ОДИН.");
        }
    }

    //Вторая конкретная реализация-стратегия
    //Реализаций стратегий (различных алгоритмов) может быть сколько угодно. Столько
    //сколько требуется для решения конкретной задачи
    public class ConcreteStrategy2 : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Выполняется алгоритм стратегии номер ДВА.");
        }
    }

    //Контекст, использующий стратегию для решения поставленной задачи
    public class Context
    {
        //Ссылка на интерфейс IStrategy
        //используется при переключении между конкретными реализациями
        //(проще говоря, это выбор конкретной стратегии)
        private IStrategy _strategy;

        //Конструктор контекста
        //Инициализирует объект контекста заданной стратегией
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        //Метод для установки стратегии
        //Используется для смены стратегии во время выполнения программы
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        //Запускает выполнение алгоритма выбранной стратегии
        public void ExecuteOperation()
        {
            _strategy.Algorithm();
        }
    }

   
}
