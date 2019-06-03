using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
  public  abstract class Auto
    {
        public string ModelTitle { get; set; }
        public abstract void Accept(IVisitor visitor);
    }
    public class Car : Auto
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitCar(this);
        }
    }
    public class Track : Auto
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitTrack(this);
        }
    }
    public interface IVisitor
    {
        void VisitCar(Car car);
        void VisitTrack(Track track);
    }
    public class AutoVisitor : IVisitor
    {
        public void VisitCar(Car car)
        {
            Console.WriteLine($"Легковой автомобиль модели: {car.ModelTitle}");
        }
        public void VisitTrack(Track track)
        {
            Console.WriteLine($"Грузовой автомобиль модели: {track.ModelTitle}");
        }
    }
}
