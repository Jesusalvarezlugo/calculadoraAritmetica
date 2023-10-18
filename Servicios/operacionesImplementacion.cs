using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraAritmetica.Servicios
{
    internal class operacionesImplementacion :operacionesInterfaz
    {
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
            operacion = num + num1;

            Console.WriteLine("El resultado de la operacion es: {0}", operacion);


            return operacion;
        }

        public double Division(double num, double num1)
        {
            double operacion;
            operacion = num / num1;

            Console.WriteLine("El resultado de la operacion es: {0}", operacion);


            return operacion;
        }

        public double multiplicacion(double num, double num1)
        {
            double operacion;
            operacion = num * num1;

            Console.WriteLine("El resultado de la operacion es: {0}", operacion);
            return operacion;
        }
    }
}
