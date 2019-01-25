using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6 {
    class Program {
        static void Main(string[] args) {
            double salario;
            Console.WriteLine("Ingrese su salario:");
            salario = double.Parse(Console.ReadLine());
            if (salario < 1656232) {
                Console.WriteLine("Su couta moderadora es : Tarifa A: 3.200");

            }
            if (salario >= 1656232 && salario < 4140580) {
                Console.WriteLine("Su couta moderadora es : Tarifa B: 12.700");

            }
            if (salario >= 4140580) {
                Console.WriteLine("Su couta moderadora es : Tarifa C: 33.500");

            }
        }
    }
}
