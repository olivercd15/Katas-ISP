using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasISP.Kata2.LegacySystem.Solution
{
    // Interfaces segregadas
    public interface IPrintable
    {
        void Print();
    }

    public interface IScannable
    {
        void Scan();
    }

    public interface IFaxable
    {
        void Fax();
    }

    // Implementación específica
    public class BasicPrinter : IPrintable
    {
        public void Print() => Console.WriteLine("Printing document...");
    }

    // Ejemplo de una impresora avanzada 
    public class AdvancedPrinter : IPrintable, IScannable, IFaxable
    {
        public void Print() => Console.WriteLine("Printing...");
        public void Scan() => Console.WriteLine("Scanning...");
        public void Fax() => Console.WriteLine("Faxing...");
    }
}
