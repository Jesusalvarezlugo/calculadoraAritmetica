using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraAritmetica.Servicios
{
    internal interface operacionesInterfaz
    {
        public double Suma(double num, double num1);

        ///<summary>
        ///Método que hace la resta y la muestra por consola.
        /// </summary>

        public double Resta(double num, double num1);

        ///<summary>
        ///Método que hace la multiplicación y la muestra por consola.
        /// </summary>

        public double multiplicacion(double num, double num1);

        ///<summary>
        ///Método que hace la división y la muestra por consola.
        /// </summary>

        public double Division(double num, double num1);
    }
}
