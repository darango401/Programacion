using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, Ingrese el numero de jugadores(Solo 1 persona) ");
            int jugadores = int.Parse(Console.ReadLine());
            while ( jugadores != 1)
            {
                Console.WriteLine("Error. Ingrese cuantos jugadores son(1 persona)");
                jugadores = int.Parse(Console.ReadLine());
                    
            }
            Random random = new Random();
            Console.WriteLine("Bienvenido, Inicio del juego");
            int total = 0;
            int dado1 = random.Next(1, 6), dado2 = random.Next(1, 6);
            double cont = 0, con = 1;
            total = dado1 + dado2;
            String respuesta;
            Console.WriteLine("Al lanzar los dados salio "+total );
            Console.WriteLine("El dado 1 fue: " + dado1 + ", y el dado 2 fue:" + dado2);
            Console.WriteLine("Desea lanzar nuevamente los dados ?");
            respuesta = Console.ReadLine();
            while (respuesta == "s" && total <= 100)
            {
                con++;
                if ((dado1 +dado2)>6)
                {
                    cont++;
                }
                dado1 = random.Next(1, 6);
                dado2 = random.Next(1, 6);
                total += (dado1 + dado2);

                Console.WriteLine("Al lanzar los dados salio " +dado1+" y " +dado2+" y el total va en: "+ total );
                Console.WriteLine("Desea lanzar nuevamente los dados ?");
                respuesta = Console.ReadLine();
                if (dado1 == 1 && dado2 == 1)
                {
                    Console.WriteLine("Usted ha perdido");
                    Console.WriteLine("Desea continuar ?");
                    respuesta = Console.ReadLine();
                    break;
                   }
                int contador = 0;
                while(dado1 == dado2){
                    contador++;
                    if(contador == 3)
                    {
                        Console.WriteLine("Usted ha ganado!!");
                        break;
                     }
                   }
            }
            if (respuesta == "n") Console.WriteLine("Usted ha decidio terminar el juego su puntaje final fue:" +total);
            double x = ((cont / con) * 100);
            Console.WriteLine("El porcentaje de lanzamientos mayores a 6 fueron " +x+"%");
        }

    }
}
