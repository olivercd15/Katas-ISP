using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasISP.Kata5.DeviceInterface.Solution
{
    // Interfaces segregadas
    public interface IPowerControllable
    {
        void TurnOn();
        void TurnOff();
    }

    public interface IWiFiConnectable
    {
        void ConnectToWiFi();
    }

    public interface IMusicPlayable
    {
        void PlayMusic();
    }

    // Implementaciones específicas
    public class SmartLight : IPowerControllable, IWiFiConnectable
    {

        public void TurnOn() => Console.WriteLine("Lights on");
        public void TurnOff() => Console.WriteLine("Lights off");
        public void ConnectToWiFi() => Console.WriteLine("Connected to WiFi");
    }

    public class SmartSpeaker : IPowerControllable, IWiFiConnectable, IMusicPlayable
    {
        public void TurnOn() => Console.WriteLine("Speakers on");
        public void TurnOff() => Console.WriteLine("Speakers off");
        public void ConnectToWiFi() => Console.WriteLine("Connected to WiFi");
        public void PlayMusic() => Console.WriteLine("Playing music");
    }
}
