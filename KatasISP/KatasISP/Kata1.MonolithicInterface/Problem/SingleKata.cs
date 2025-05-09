using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasISP.Kata1.MonolithicInterface.Problem
{
    /*
     
    Kata 1: Interfaz Monolítica
    Objetivo: Crear una interfaz monolítica que viole ISP.

    Crear una interfaz Animal con los métodos fly(), swim() y run().
    Implementar las clases Bird, Fish y Dog utilizando la interfaz Animal.
    Identificar el problema: No todos los animales pueden realizar todas las acciones.
    Refactorizar: Dividir Animal en interfaces más pequeñas (Flyable, Swimmable, Runnable) e implementar solo las relevantes en cada clase.

     */


    // Interfaz monolítica que viola ISP
    public interface IAnimal
    {
        void Fly();
        void Swim();
        void Run();
    }

    // Implementaciones de la interfaz monolítica
    public class Bird : IAnimal
    {
        public void Fly() => Console.WriteLine("Bird flies");

        public void Swim() =>
            throw new NotImplementedException("Birds don't swim!");

        public void Run() => Console.WriteLine("Bird runs (a little)");
    }

    public class Fish : IAnimal
    {
        public void Fly() =>
            throw new NotImplementedException("Fish can't fly!");

        public void Swim() => Console.WriteLine("Fish swims");

        public void Run() =>
            throw new NotImplementedException("Fish can't run!");
    }

    public class Dog : IAnimal
    {
        public void Fly() =>
            throw new NotImplementedException("Dogs can't fly!");

        public void Swim() => Console.WriteLine("Dog swims (doggy paddle)");

        public void Run() => Console.WriteLine("Dog runs");
    }
}
