using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nicosiusDataStructureProyect
{
    static class ForAvanzado
    {
        static int firstNumber = 0;
        static int secondNumber = 0;

        public static void  Demostration()
        {       
            Console.WriteLine("ejemplo sin iniciador");
            for (; firstNumber < 5; firstNumber++)
            {
                Console.WriteLine("first number -> {0} ", firstNumber);
            }

            Console.WriteLine("Ejemplo  sin tope");
            for (firstNumber = 0; firstNumber < 5;)
            {
                Console.WriteLine("first number -> {0} ", firstNumber);
                firstNumber++;
            }
           
            Console.WriteLine("Ejemplo dobre iniciador , doble tope");
            for (firstNumber = 0, secondNumber = 5; firstNumber < 5; firstNumber++, secondNumber--)
            {
                Console.WriteLine("first number -> {0}, second number -> {1} ", firstNumber, secondNumber);
            }


            Console.WriteLine("Ejemplo usando condicionales dentro del controlador ");
            for (firstNumber = 1, secondNumber = 1; firstNumber%12!=0 && secondNumber%12!=0; firstNumber++, secondNumber = secondNumber + 3)
            {
                Console.WriteLine("first number -> {0}, second number -> {1} ", firstNumber, secondNumber);
            }

            Console.WriteLine("Usuando una propiedad dentro del controlador");
            for (firstNumber = 1, secondNumber = 1; Comparacion(firstNumber,secondNumber); firstNumber++, secondNumber = secondNumber + 3)
            {
                Console.WriteLine("first number -> {0}, second number -> {1} ", firstNumber, secondNumber);
            }
        }

        private static bool Comparacion(int firstNumber, int secondNumber)
        {
            if (firstNumber % 12 != 0 && secondNumber % 12 != 0) return true;
            else return false;
        }
    }
}
