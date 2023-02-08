using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nicosiusDataStructureProyect
{
    internal class AutomaticClassicClass
    {
        private int value;

        // traditional getters and setters
        public int Value { get => value; set => this.value = value; }

        // automatic property
        public int Coste { get; set; } = 5;

        //constructor
        public AutomaticClassicClass()
        {
            Value = 10;
        }

        public void ShowData()
        {
            Console.WriteLine("Value is {0} , coste is {1}", value, Coste);
        }

    }
}
