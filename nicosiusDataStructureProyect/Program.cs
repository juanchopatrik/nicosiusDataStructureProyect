using System;
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
        static void Main(string[] args)
        {
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
            int cantidad = 8;
            int sumatoria = 0;
            int factorial = 0;

            Calculador(cantidad, out sumatoria, out factorial);
            Console.WriteLine("Sumatoria = {0}, factorial = {1}", sumatoria, factorial);
        }

        private static void Calculador(int cantidad, out int sumatoria, out int factorial)
        {
            sumatoria = 0;
            factorial = 1;

            for (int m = 1; m < cantidad; m++)
            {
                sumatoria = sumatoria + m;
                factorial = factorial * m;
            }
        }
    }
}
