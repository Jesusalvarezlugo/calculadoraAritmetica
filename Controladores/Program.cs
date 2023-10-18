using calculadoraAritmetica.Servicios;

namespace calculadoraAritmetica.Controladores
{
    ///<summary>
    ///Clase que controla el flujo de la aplicación
    ///091023-jal
    /// </summary
    class Program
    {

        /// <summary>
        /// Clase desde donde iniciaremos la aplicación
        /// 270923-jal
        /// </summary>
        /// <param name="args"></param>
        internal static void Main(string[] args)
        {
            //llamada al metodo que muestra mensaje de bienvenida a la calculadora.

            MenuInterfaz mi=new MenuImplementacion();
            operacionesInterfaz oi = new operacionesImplementacion();

            mi.MensajeBienvenida();

            //Declaramos la variable para controlar la salida del while

            bool cerrarMenu = false;

            //variable para contener la opcion del usuario

            int opcionSeleccionada;

            //Hacemos el bucle while

            while (!cerrarMenu)
            {
                //guardamos la opcion seleccionada en opcionSeleccionada
                opcionSeleccionada = mi.mostrarMenuYSeleccion();

                

                //hacemos el switch para ejecutar la opcion seleccionada

                switch (opcionSeleccionada){

                    case 0:
                        //pasamos cerrar menu a true para que cerrarMenu valga true y salga del bucle.
                        cerrarMenu = true;
                     break;

                    case 1:
                        Console.WriteLine("Ha introducido la opcion suma");
                        

                        double operador1,operador2;
                        
                        //Pedimos el valor para asignarlo a las variables
                        operador1 = mi.PedirOperador();
                        operador2= mi.PedirOperador();

                        //Mostramos el resultado de la operacion
                        oi.Suma(operador1,operador2);
                        
                     break;

                    case 2:

                        Console.WriteLine("Ha introducido la opcion resta");
                        

                        double operador3, operador4;

                        operador3 = mi.PedirOperador();
                        operador4 = mi.PedirOperador();

                        oi.Resta(operador3,operador4);
                     break;

                    case 3:

                        Console.WriteLine("Ha introducido la opcion multiplicación");
                        
                        double operador5,operador6;

                        operador5 = mi.PedirOperador();
                        operador6 = mi.PedirOperador();


                        oi.multiplicacion(operador5, operador6);
                        

                     break;

                    case 4:
                        Console.WriteLine("Ha introducido la opcion Division");

                        double operador7, operador8;

                        operador7 = mi.PedirOperador();
                        operador8 = mi.PedirOperador();

                        oi.Division(operador7, operador8);
                     break;

                    default:
                        Console.WriteLine("[INFO] opcion seleccionada no valida. Introduzca una de las opciones mostradas.");
                        break;



                    
                }
        
            }
        }
    }
}
