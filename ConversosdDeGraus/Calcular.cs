using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversosdDeGraus
{
    public class Calcular
    {
        double Celsius {  get; set; }
        double Forehnhiet { get; set; }
        double Kelvin { get; set; }

        public Calcular()
        {

        }

        public double calcularCelsiusKelvin(double celsius)
        {
            Celsius =  celsius + 273;
            return Celsius;
        }

        public double calcularCelsiusForehnhiet(double celsius)
        {
            Celsius =  (celsius *9 / 5)+ 32;
            return Celsius;
        }
        public double calcularForehnhietcelsius(double forehnhiet)
        {
            Forehnhiet = (forehnhiet - 32) * 5 / 9;
            return Forehnhiet;
        }

        public double calcularForehnhietKelvin(double forehnhiet)
        {
            Forehnhiet = (forehnhiet - 32) * 5 / 9 + 273;
            return Forehnhiet;
        }

        public double calcularKelvinCelsius(double kelvin)
        {
            Kelvin = kelvin - 273/5;
            return Kelvin;
        }

        public double calcularKelvinForehnhit(double kelvin)
        {
            Kelvin =( kelvin - 273) * 9 / 5 +32;
            return Kelvin;
        }

    }
}
