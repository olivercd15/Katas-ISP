using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasISP.Kata1.MonolithicInterface.Solution
{
    // Interfaces refactorizadas con ISP


    public interface IFlyable
    {
        void Fly();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public interface IRunnable
    {
        void Run();
    }


    // Implementaciones limpias
    public class Birds : IFlyable, IRunnable
    {
        public void Fly() => Console.WriteLine("Bird flies");
        public void Run() => Console.WriteLine("Bird runs (a little)");
    }

    public class Fish : ISwimmable
    {
        public void Swim() => Console.WriteLine("Fish swims");
    }

    public class Dog : ISwimmable, IRunnable
    {
        public void Swim() => Console.WriteLine("Dog swims (doggy paddle)");
        public void Run() => Console.WriteLine("Dog runs");
    }
}
