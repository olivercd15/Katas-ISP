using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasISP.Kata4.SensorManagement.Problem
{
    /*
    
    Kata 4: Gestión de Sensores en un Sistema de Monitoreo
    Objetivo: Diseñar interfaces específicas para diferentes tipos de sensores.

    Crear una interfaz Sensor con los métodos readTemperature(), readPressure() y readHumidity().
    Implementar las clases TemperatureSensor, PressureSensor y HumiditySensor.
    Identificar el problema: Cada sensor implementa métodos que no necesita.
    Refactorizar: Dividir Sensor en interfaces más pequeñas (TemperatureReadable, PressureReadable, HumidityReadable) e implementar solo las relevantes en cada clase.
     
    */
    public interface ISensor
    {
        double ReadTemperature();
        double ReadPressure();
        double ReadHumidity();
    }

    // Implementaciones con métodos no soportados y valores obtenidos (simulados)
    public class TemperatureSensor : ISensor
    {
        public double ReadTemperature() => 25.5; 

        public double ReadPressure() =>
            throw new NotSupportedException("TemperatureSensor cannot read pressure.");

        public double ReadHumidity() =>
            throw new NotSupportedException("TemperatureSensor cannot read humidity.");
    }

    public class PressureSensor : ISensor
    {
        public double ReadTemperature() =>
            throw new NotSupportedException("PressureSensor cannot read temperature.");

        public double ReadPressure() => 1013.25; 

        public double ReadHumidity() =>
            throw new NotSupportedException("PressureSensor cannot read humidity.");
    }

    public class HumiditySensor : ISensor
    {
        public double ReadTemperature() =>
            throw new NotSupportedException("HumiditySensor cannot read temperature.");

        public double ReadPressure() =>
            throw new NotSupportedException("HumiditySensor cannot read pressure.");

        public double ReadHumidity() => 60.0; 
    }
}
