using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Clases
{
    //CLASE ES UNA PLANTILLA QUE CONTIENE OBJETOS Y METODOS
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }

        public void ImprimirDatos()
        {
            Console.WriteLine("TU NOMBRE ES: " + this.Nombre);
            Console.WriteLine("TU APELLIDO ES: " + this.Apellido);
            Console.WriteLine("TU EDAD ES: " + this.Edad);
            Console.WriteLine("TU SALARIO ES: " + this.Salario);
        }

    }
}
