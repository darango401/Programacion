using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Suponga tiene un triangulo rectangulo con altura z = 3 y angulo inferior c = 56.31. Hallar la base, hipotenusa y angulo restante.");
            double y;
            double z = 3;
            double t;
            double a1 = 56.31;
            double a2;
            double cosX;
            a2 = -90 - 56.31 + 180;
            cosX = Math.Cos(a2);
            y = z * (cosX);
            t = Math.Sqrt((z * z) - (y * y));


            Console.WriteLine("La base del triangulo rectangulo seria " + y + ",su hipotenusa " + t + " y su angulo restante seria de " + a2 + "°");

        }
    }
}
