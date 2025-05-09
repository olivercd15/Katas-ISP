using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasISP.Kata6.PaymentSystem.Problem
{
    /*
      
    Kata 6: Sistema de Pago en E-Commerce
    Objetivo: Evitar que las clases implementen métodos irrelevantes.

    Crear una interfaz PaymentProcessor con los métodos processCreditCard(), processPayPal() y processCrypto().
    Implementar las clases CreditCardProcessor, PayPalProcessor y CryptoProcessor.
    Identificar el problema: Cada clase implementa métodos que no utiliza.
    Refactorizar: Dividir PaymentProcessor en CreditCardPayment, PayPalPayment y CryptoPayment.
     
    */
    public interface IPaymentProcessor
    {
        void ProcessCreditCard();
        void ProcessPayPal();
        void ProcessCrypto();
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessCreditCard() => Console.WriteLine("Processing credit card payment");

        public void ProcessPayPal() =>
            throw new NotSupportedException("CreditCardProcessor does not support PayPal");

        public void ProcessCrypto() =>
            throw new NotSupportedException("CreditCardProcessor does not support Crypto");
    }

    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessCreditCard() =>
            throw new NotSupportedException("PayPalProcessor does not support credit cards");

        public void ProcessPayPal() => Console.WriteLine("Processing PayPal payment");

        public void ProcessCrypto() =>
            throw new NotSupportedException("PayPalProcessor does not support Crypto");
    }

    public class CryptoProcessor : IPaymentProcessor
    {
        public void ProcessCreditCard() =>
            throw new NotSupportedException("CryptoProcessor does not support credit cards");

        public void ProcessPayPal() =>
            throw new NotSupportedException("CryptoProcessor does not support PayPal");

        public void ProcessCrypto() => Console.WriteLine("Processing Crypto payment");
    }
}
