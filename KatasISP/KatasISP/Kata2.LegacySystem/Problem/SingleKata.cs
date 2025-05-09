using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasISP.Kata2.LegacySystem.Problem
{

    /*
     
    Kata 2: Sistema Legacy con Métodos No Utilizados
    Objetivo: Identificar métodos no utilizados en un sistema legacy.

    Crear una interfaz LegacyPrinter con los métodos print(), scan() y fax().
    Implementar una clase BasicPrinter que solo utilice print().
    Identificar el problema: BasicPrinter se ve obligada a implementar métodos no utilizados.
    Refactorizar: Dividir LegacyPrinter en Printable, Scannable y Faxable.

    */

    public interface ILegacyPrinter
    {
        void Print();
        void Scan();
        void Fax();
    }

    // Implementación forzada 
    public class BasicPrinter : ILegacyPrinter
    {
        public void Print() => Console.WriteLine("Printing document...");

        public void Scan() =>
            throw new NotImplementedException("BasicPrinter cannot scan!");

        public void Fax() =>
            throw new NotImplementedException("BasicPrinter cannot fax!");
    }
}
