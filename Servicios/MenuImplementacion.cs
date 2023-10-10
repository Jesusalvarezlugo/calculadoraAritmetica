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

        public double multiplicacion(double num, double num1)
        {
            double operacion;
            operacion = num * num1;
            
            Console.WriteLine("El resultado de la operacion es: {0}", operacion);
            return operacion;
        }

        public double PedirOperador()
        {
            //Pedimos los operadores

            Console.WriteLine("Introduce un operador: ");
            double operador1 = Double.Parse(Console.ReadLine());

            return operador1;

            
        }

        public double Resta(double num, double num1)
        {
            double operacion;
            operacion = num - num1;
           
            Console.WriteLine("El resultado de la operacion es: {0}", operacion);
            return operacion;
        }

        public double Suma(double num, double num1)
        {


            double operacion;
            operacion= num +num1 ;
            
            Console.WriteLine("El resultado de la operacion es: {0}", operacion);


            return operacion;
        }

        public double Division(double num, double num1)
        {
            double operacion;
            operacion =num / num1;
            
            Console.WriteLine("El resultado de la operacion es: {0}", operacion);


            return operacion;
        }


    }
}
