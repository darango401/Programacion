using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4 {
    class Program {
        static void Main(string[] args) {
            double d;
            Console.WriteLine("Se tiene una ecuacion cuadratica (ax^2+bx+c=0)");
            Console.WriteLine("Ingrese un valor para a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un valor para b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un valor para c:");
            double c = double.Parse(Console.ReadLine());
            d = (b * b) - (4 * a * c);
            if (d == 0) {

                double x = -b / (2 * a);
                Console.WriteLine("La solucion es unica:" + x);
            }
            if (d > 0) {
                double x1 = (-b - Math.Pow(d, 0.5)) / (2 * a);
                double x2 = (-b + Math.Pow(d, 0.5)) / (2 * a);
                Console.WriteLine("Soluciones: x1=" + x1+" y x2=" + x2);
            }
            if (d < 0) {
                Console.WriteLine("La ecuacion no tiene solucion");

            }

        }

    }
    }

