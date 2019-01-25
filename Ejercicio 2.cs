using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Suponga tiene un triangulo rectangulo con hipotenusa t = 3.61 y angulo superior a = 33.69. Hallar la base, altura y angulo restante.");
            double y;
            double z;
            double t = 3.61;
            double a1;
            double a2 = 33.69;

            a1 = -90 - 33.69 + 180;
           
            y = t * (Math.Sin(a2));
            z = Math.Sqrt((t * t) - (y * y));


            Console.WriteLine("La base del triangulo rectangulo seria " + y + ",su altura " + z + " y su angulo restante seria de " + a1 + "°");

        }
    }
}
