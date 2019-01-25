using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Suponga tiene un triangulo rectangulo con base y=2 y altura z=3. Hallar la hipotenusa y sus 2 angulos restantes.");
            double y = 2;
            double z = 3;
            double t;
            double a1;
            double a2;

            t = Math.Sqrt((y * y) + (z * z));
            a1 = Math.();
            a2 = 180 - 90 - a1;
            Console.WriteLine("La hipotenusa del triangulo rectangulo es " + t + ",el angulo inferior " + a1 +
                "°, y por ultimo el angulo superior es de " + a2 + "°");

        }
    }
}
