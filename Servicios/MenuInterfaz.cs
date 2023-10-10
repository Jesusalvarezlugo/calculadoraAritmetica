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

        public int Suma(int num,int num1);

        public int Resta(int num, int num1);

        public int multiplicacion(int num, int num1);

        public int Division(int num,int num1);

        public int PedirOperador();

    }
}
