using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasISP.Kata4.SensorManagement.Solution
{
    // Interfaces segregadas
    public interface ITemperatureReadable
    {
        double ReadTemperature();
    }

    public interface IPressureReadable
    {
        double ReadPressure();
    }

    public interface IHumidityReadable
    {
        double ReadHumidity();
    }

    // Implementaciones específicas
    public class TemperatureSensor : ITemperatureReadable
    {
        public double ReadTemperature() => 25.5;
    }

    public class PressureSensor : IPressureReadable
    {
        public double ReadPressure() => 1013.25;
    }

    public class HumiditySensor : IHumidityReadable
    {
        public double ReadHumidity() => 60.0;
    }

    // Sensor de ambiente que implementa múltiples interfaces
    public class EnvironmentalSensor : ITemperatureReadable, IHumidityReadable
    {
        public double ReadTemperature() => 22.3;
        public double ReadHumidity() => 65.0;
    }
}
