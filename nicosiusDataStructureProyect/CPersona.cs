using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nicosiusDataStructureProyect
{
    public class CPersona
    {
        private string nombre;
        private int edad;

        public CPersona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}, edad : {1}", nombre, edad);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is CPersona)
            {
                CPersona tem = (CPersona)obj;
                if (nombre == tem.nombre && edad == tem.edad)
                    return true;
            }
            return false;
        }
    }
}
