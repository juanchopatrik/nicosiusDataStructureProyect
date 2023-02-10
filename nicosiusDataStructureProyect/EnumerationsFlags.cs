using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace nicosiusDataStructureProyect
{
    [Flags]
    public enum Condimentos
    {
        nada = 0, Tomate = 1, Lechuga = 2, Cebolla = 4, Queso = 8
    }
    static class EnumerationsFlags
    {
        public static void probando()
        {
            Condimentos condimentos = Condimentos.Queso;
            DibujaHamburgueas(condimentos);
            condimentos = condimentos | Condimentos.Tomate;
            DibujaHamburgueas(condimentos);
            Console.WriteLine(condimentos.GetType());
        }

        private static void DibujaHamburgueas(Condimentos pCond)
        {
            //Dibujamos Tapa
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("(=====)");

            //Verificamos si se tiene tomate
            if ((pCond & Condimentos.Tomate) != 0)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" (=====)");
            }
            
            if ((pCond & Condimentos.Lechuga) != 0)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ^^^^^");
            }

            if ((pCond & Condimentos.Cebolla) != 0)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" #####");
            }

            if ((pCond & Condimentos.Queso) != 0)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" -----");
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" =====");
            

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("(=====)");

            Console.WriteLine("\r\n -------------- \r\n");
        }
    }
}
