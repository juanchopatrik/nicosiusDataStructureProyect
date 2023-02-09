using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nicosiusDataStructureProyect
{
    static class NulleableOperators
    {
        static string a = null;
        static string b = "Hello";
        static int? ai = null;
        static int? bi = 2;
        static string r;

        // si a es null entonces se escribe was null si no se asigna (a)
        public static void DemoNulleable()
        {
            r = a ?? "was a null";
            Console.WriteLine(r);

            r = b ?? "was a null";
            Console.WriteLine(r);

            Console.WriteLine("---------");
        }

        public static void DemoNulleable2()
        {
            //este se rompe por que no tiene excepcion controlada
            //string rs = a.ToString();

            string rs2 = a?.ToString();
            Console.WriteLine(rs2);

            // Cuando no es tipo nuleable se debe voler nuleable con "?"

            //int quantity = a?.ToString().Length;
            int? quantity = ai?.ToString().Length;
            Console.WriteLine(quantity);

            
            int? quantity2 = bi?.ToString().Length;
            Console.WriteLine(quantity);
            Console.WriteLine(bi);
                           
        }
    }
}
