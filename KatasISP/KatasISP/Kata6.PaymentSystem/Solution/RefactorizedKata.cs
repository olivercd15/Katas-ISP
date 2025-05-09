using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasISP.Kata6.PaymentSystem.Solution
{
    public interface ICreditCardPayment
    {
        void ProcessCreditCard();
    }

    public interface IPayPalPayment
    {
        void ProcessPayPal();
    }

    public interface ICryptoPayment
    {
        void ProcessCrypto();
    }

    public class CreditCardProcessor : ICreditCardPayment
    {
        public void ProcessCreditCard() => Console.WriteLine("Processing credit card payment");
    }

    public class PayPalProcessor : IPayPalPayment
    {
        public void ProcessPayPal() => Console.WriteLine("Processing PayPal payment");
    }

    public class CryptoProcessor : ICryptoPayment
    {
        public void ProcessCrypto() => Console.WriteLine("Processing Crypto payment");
    }

    // Ejemplo opcional: Procesador híbrido
    public class HybridPaymentProcessor : ICreditCardPayment, IPayPalPayment
    {
        public void ProcessCreditCard() => Console.WriteLine("Processing credit card (hybrid)");
        public void ProcessPayPal() => Console.WriteLine("Processing PayPal (hybrid)");
    }
}
