﻿using System;
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

        

        ///<summary>
        ///Método que pide el operador.
        /// </summary>

        public double PedirOperador();

    }
}
