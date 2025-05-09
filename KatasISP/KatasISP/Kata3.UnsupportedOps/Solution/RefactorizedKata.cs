using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasISP.Kata3.UnsupportedOps.Solution
{
    // Interfaces segregadas
    public interface IDrivable
    {
        void Drive();
    }

    public interface IFlyable
    {
        void Fly();
    }

    public interface ISailable
    {
        void Sail();
    }

    // Implementaciones específicas
    public class Car : IDrivable
    {
        public void Drive() => Console.WriteLine("Car is driving...");
    }

    public class Plane : IFlyable
    {
        public void Fly() => Console.WriteLine("Plane is flying...");
    }

    public class Boat : ISailable
    {
        public void Sail() => Console.WriteLine("Boat is sailing...");
    }

}
