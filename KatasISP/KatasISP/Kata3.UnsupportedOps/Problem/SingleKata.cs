using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasISP.Kata3.UnsupportedOps.Problem
{
    /*
     
    Kata 3: Operaciones No Soportadas
    Objetivo: Manejar operaciones no soportadas.

    Crear una interfaz Vehicle con los métodos drive(), fly() y sail().
    Implementar las clases Car, Plane y Boat. Lanzar UnsupportedOperationException para los métodos no soportados.
    Identificar el problema: Lanzar excepciones viola ISP.
    Refactorizar: Crear interfaces separadas (Drivable, Flyable, Sailable) e implementarlas adecuadamente.
    
    */
    public interface IVehicle
    {
        void Drive();
        void Fly();
        void Sail();
    }

    // Implementaciones con excepciones forzadas e implementacion de métodos no utilizados
    public class Car : IVehicle
    {
        public void Drive() => Console.WriteLine("Car is driving...");

        public void Fly() =>
            throw new NotSupportedException("Cars can't fly!");

        public void Sail() =>
            throw new NotSupportedException("Cars can't sail!");
    }

    public class Plane : IVehicle
    {
        public void Drive() =>
            throw new NotSupportedException("Planes can't drive!");

        public void Fly() => Console.WriteLine("Plane is flying...");

        public void Sail() =>
            throw new NotSupportedException("Planes can't sail!");
    }

    public class Boat : IVehicle
    {
        public void Drive() =>
            throw new NotSupportedException("Boats can't drive!");

        public void Fly() =>
            throw new NotSupportedException("Boats can't fly!");

        public void Sail() => Console.WriteLine("Boat is sailing...");
    }
}
