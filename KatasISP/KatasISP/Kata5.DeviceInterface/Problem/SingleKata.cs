using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasISP.Kata5.DeviceInterface.Problem
{
    /*
     
    Kata 5: Interfaz de Dispositivo IoT
    Objetivo: Diseñar interfaces para capacidades específicas de dispositivos.

    Crear una interfaz SmartDevice con los métodos turnOn(), turnOff(), connectToWiFi() y playMusic().
    Implementar las clases SmartLight y SmartSpeaker.
    Identificar el problema: SmartLight no necesita playMusic().
    Refactorizar: Crear interfaces más pequeñas (PowerControllable, WiFiConnectable, MusicPlayable) e implementarlas selectivamente. 
     
    */
    public interface ISmartDevice
    {
        void TurnOn();
        void TurnOff();
        void ConnectToWiFi();
        void PlayMusic();
    }

    // Implementaciones con métodos no soportados
    public class SmartLight : ISmartDevice
    {
        public void TurnOn() => Console.WriteLine("Lights on");
        public void TurnOff() => Console.WriteLine("Lights off");
        public void ConnectToWiFi() => Console.WriteLine("Connected to WiFi");

        public void PlayMusic() =>
            throw new NotSupportedException("SmartLight cannot play music.");
    }

    public class SmartSpeaker : ISmartDevice
    {
        public void TurnOn() => Console.WriteLine("Speakers on");
        public void TurnOff() => Console.WriteLine("Speakers off");
        public void ConnectToWiFi() => Console.WriteLine("Connected to WiFi");
        public void PlayMusic() => Console.WriteLine("Playing music");
    }
}
