using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7 {
    class Program {
        static void Main(string[] args) {
            double salario;
            Console.WriteLine("Ingrese su salario:");
            salario = double.Parse(Console.ReadLine());
            if (salario < 1656232) {
                Console.WriteLine("Su tarifa es : Tarifa A");

            }
            if (salario >= 1656232 && salario < 4140580) {
                Console.WriteLine("Su tarifa es : Tarifa B");

            }
            if (salario >= 4140580) {
                Console.WriteLine("Su tarifa es : Tarifa C");

            }
        }
    }
}
