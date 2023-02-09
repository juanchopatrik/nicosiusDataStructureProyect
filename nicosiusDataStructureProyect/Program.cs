using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nicosiusDataStructureProyect
{
    internal class Program
    {
        public enum tipoImagen
        {
            BMP,
            JPG,
            PNG,
            GIF,
            TIFF
        }
        static void Main(string[] args)
        {
            //Operators Null (?)

            NulleableOperators.DemoNulleable();
            NulleableOperators.DemoNulleable2();
            

            //Automatic and Classic Properties
/*            AutomaticClassicClass prueba = new AutomaticClassicClass();
            prueba.ShowData();
*/
            //ForAvanzado.Demostration();
            ////Entendiendo la clase Object

            //CPersona juan = new CPersona("Juan", 27);

            //Console.WriteLine("To String");
            //Console.WriteLine(juan.ToString());

            //Console.WriteLine("Get Type");
            //Console.WriteLine(juan.GetType().BaseType);

            //CPersona Maria = new CPersona("Maria", 20);

            ////Vemos el comportamiento de equals

            //Console.WriteLine("------- Equals ------------");

            //if (juan.Equals(Maria))
            //{
            //    Console.WriteLine("Son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("No son iguales");
            //}
            //CPersona Juan2 = new CPersona("Juan", 27);

            ////Vemos el comportamiento de equals

            //Console.WriteLine("------- Equals ------------");

            //if (juan.Equals(Juan2))
            //{
            //    Console.WriteLine("Son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("No son iguales");





            //Numeraciones
            /*Son tipos creados por el programador
             * Son opciones finitas que sirven para no tener hardcode
             */

            /*            string dato = "";
                        double tamanoImg = 0.0;

                        Console.WriteLine("Write the image zise: ");
                        dato = Console.ReadLine();
                        tamanoImg = Convert.ToDouble(dato);

                        calcularEspacio(tipoImagen.PNG, tamanoImg);
            */
            // uso de foreach
            /*El foreach es unas estructura de datos que se conecta con otra estructura de datos
             el foreach es quien elige como comunicarse con otras estructura
            * tiene dos interface hasNext = bool establece si tiene un dato siguiente
            * Next = devuelve el dato
            * El foreach se acopla segun la estructura que quiere iterar
            * Cuando se usa el foreach se usa unboxing
             */

            //    //arreglos tipoi jagged

            //    int[][] numbers = new int[4][];//cuatro reglones

            //    //instanciar cada reglon
            //    numbers[0] = new int[3];
            //    numbers[1] = new int[4];
            //    numbers[2] = new int[2];
            //    numbers[3] = new int[3];

            ////variables

            //    int n = 0;
            //    int m = 0;
            //    string dato = "";

            //    for ( n = 0; n < 4; n++)
            //    {
            //        for ( m = 0; m < numbers[n].Length; m++)
            //        {
            //            Console.WriteLine("escribe el numero {0} de la region {1}", m, n);
            //            dato = Console.ReadLine();
            //            numbers[n][m] = Convert.ToInt32(dato);
            //        }

            //    }

            // Boxing and unboxing

            //ArrayList miArray = new ArrayList();

            //    miArray.Add(5);
            //    miArray.Add(6);

            ////this line will throw a error

            ///*int result = miArray[0] + miArray[1];*/

            //int result = (int)miArray[0] + (int)miArray[1]; 
            //Console.WriteLine("the result is {0}", result);

            /*            double[] calif = new double[3];
                        double sumatori = 0;
                        double difference = 0;

                        for (int i = 0; i < calif.Length; i++)
                        {
                            Console.WriteLine("Escribir Calificacion");
                            calif[i] = Convert.ToDouble(Console.ReadLine());
                            sumatori += calif[i];
                        }
            */
            /*            bool boolean = false;
                        char characterProobe = 'a';
                        string chaine = "Priviet";

                        switch (boolean)
                        {
                            case true:
                                Console.WriteLine("is true");
                                break;
                            case false:
                                Console.WriteLine("is false");
                                break ;
                        }


                        switch (characterProobe)
                        {
                            case 'a':
                            case 'e':
                            case 'i':
                            case 'o':
                            case 'u':
                                Console.WriteLine("its a  voca");
                                break;
                            default:
                                Console.WriteLine("Is not a vocal");
                                break;
                        }

                        switch (chaine)
                        {
                            case "hola":
                                Console.WriteLine("Espanol");
                                break;
                            case "hello":
                                Console.WriteLine("English");
                                break;
                            case "Priviet":
                                Console.WriteLine("Ruso");
                                break;
                        }
            */
            //int cantidad = 8;
            //int sumatoria = 0;
            //int factorial = 0;
            ////Out obliga a asignar almenos 1 ves valores de la variable dentro del metodo
            //Calculador(cantidad, out sumatoria, out factorial);
            //Console.WriteLine("Sumatoria = {0}, factorial = {1}", sumatoria, factorial);

            ////Calcular promedios con diferente numero de parametros
            //double prome = 0;
            //prome = Promedio(3.5, 6.7, 8.9);
            //Console.WriteLine("The average is {0}", prome);
            //prome = Promedio(8.0,8.7,8.8,10.0,9.0);
            //Console.WriteLine("The average is {0}", prome);
        }

        //    private static void calcularEspacio(tipoImagen pImagen, double tamanoImg)
        //{
        //    double espacio = 0.0;

        //    switch (pImagen)
        //    {
        //        case tipoImagen.BMP:
        //            espacio = tamanoImg * 1.1;
        //            break;
        //        case tipoImagen.JPG:
        //            espacio = tamanoImg * 0.8;
        //            break;
        //        case tipoImagen.PNG:
        //            espacio = tamanoImg * 1.77;
        //            break;
        //        case tipoImagen.GIF:
        //            espacio = tamanoImg * 1.5;
        //            break;
        //        case tipoImagen.TIFF:
        //            espacio = tamanoImg * 0.97;
        //            break;

        //    }
        //    Console.WriteLine("The Final size is {0}", espacio);
        //}

        ////se pueden usar diferente numero de parametros pero siempre la entrada sera un array
        //private static double Promedio(params double[] valores)
        //{
        //    double suma = 0.0;
        //    double prom = 0.0;
        //    int n = 0;

        //    for (int i = 0; i < valores.Length; i++)
        //    {
        //        suma += valores[i];
        //    }

        //    prom = suma / valores.Length;

        //    return prom;
        //}

        //private static void Calculador(int cantidad, out int sumatoria, out int factorial)
        //{
        //    sumatoria = 0;
        //    factorial = 1;

        //    for (int m = 1; m < cantidad; m++)
        //    {
        //        sumatoria = sumatoria + m;
        //        factorial = factorial * m;
        //    }
        //}

    }
}
