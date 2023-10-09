using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraAritmetica.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void MensajeBienvenida()
        {
            string mensaje = "Bienvenido a la Calculadora Aritmética";

            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcion;
            Console.WriteLine("\t\t\t╔══════════════════════════════╗");
            Console.WriteLine("\t\t\t║             MENU             ║");
            Console.WriteLine("\t\t\t╠══════════════════════════════╣");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t║    1.- Suma                  ║");
            Console.WriteLine("\t\t\t║    2.- Resta                 ║");
            Console.WriteLine("\t\t\t║    3.- Multiplicación        ║");
            Console.WriteLine("\t\t\t║    4.- División              ║");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t║          0) Salir            ║");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t╚══════════════════════════════╝");
            Console.Write("\t\tIntroduce una opción: ");

            opcion=Console.ReadKey(true).KeyChar-('0');

            return opcion;
        }
    }
}
