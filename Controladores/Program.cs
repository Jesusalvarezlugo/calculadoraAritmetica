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
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("Ha introducido la opcion suma");
                        //Pedimos los operadores

                        Console.WriteLine("Introduce el primer operador: ");
                        int operador1 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce el segundo operador: ");
                        int operador2 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado de la operacion es: {0}",operador1+operador2);
                        break;

                    case 2:

                        Console.WriteLine("Ha introducido la opcion resta");
                        //Pedimos los operadores

                        Console.WriteLine("Introduce el primer operador: ");
                        int operador3 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce el segundo operador: ");
                        int operador4 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado de la operacion es: {0}", operador3 - operador4);
                        break;

                    case 3:

                        Console.WriteLine("Ha introducido la opcion multiplicación");
                        //Pedimos los operadores

                        Console.WriteLine("Introduce el primer operador: ");
                        int operador5 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce el segundo operador: ");
                        int operador6 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado de la operacion es: {0}", operador5 * operador6);
                        

                        break;

                    case 4:
                        Console.WriteLine("Ha introducido la opcion multiplicación");
                        //Pedimos los operadores

                        Console.WriteLine("Introduce el primer operador: ");
                        int operador5 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce el segundo operador: ");
                        int operador6 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado de la operacion es: {0}", operador5 * operador6);
                        break;

                    case 5:
                        break;
                }
        
            }
        }
    }
}
