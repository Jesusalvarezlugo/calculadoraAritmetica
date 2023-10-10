using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraAritmetica.Servicios
{
    /// <summary>
    /// Interfaz con la relación de métodos de la funcionalidad menú
    /// 091023 - jal
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra mensaje de bienvenida la calculadora.
        /// </summary>
        void MensajeBienvenida();

        ///<summary>
        ///Método que muestra  el menu de la calculadora
        /// </summary>

        public int mostrarMenuYSeleccion();

        ///<summary>
        ///Método que hace la suma y la muestra por consola.
        /// </summary>

        public double Suma(double num,double num1);

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

        public double Division(double num,double num1);

        ///<summary>
        ///Método que pide el operador.
        /// </summary>

        public double PedirOperador();

    }
}
