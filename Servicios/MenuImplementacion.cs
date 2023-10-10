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

        public int multiplicacion(int num, int num1)
        {
            int operacion;
            operacion = num * num1;
            
            Console.WriteLine("El resultado de la operacion es: {0}", operacion);
            return operacion;
        }

        public int PedirOperador()
        {
            //Pedimos los operadores

            Console.WriteLine("Introduce un operador: ");
            int operador1 = Int32.Parse(Console.ReadLine());

            return operador1;

            
        }

        public int Resta(int num, int num1)
        {
            int operacion;
            operacion = num - num1;
           
            Console.WriteLine("El resultado de la operacion es: {0}", operacion);
            return operacion;
        }

        public int Suma(int num, int num1)
        {


            int operacion;
            operacion= num +num1 ;
            
            Console.WriteLine("El resultado de la operacion es: {0}", operacion);


            return operacion;
        }

        public int Division(int num, int num1)
        {
            int operacion;
            operacion =num / num1;
            
            Console.WriteLine("El resultado de la operacion es: {0}", operacion);


            return operacion;
        }


    }
}
