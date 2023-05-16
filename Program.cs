using Objetos.Clases;
using System;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region PERSONA 1
            Persona persona1 = new Persona();
            persona1.Nombre = "Maria";
            persona1.Apellido = "Sosa";
            persona1.Edad = 25;
            persona1.Salario = 12313.312;

            Console.WriteLine(persona1.Nombre);

            persona1.ImprimirDatos();

            Console.WriteLine("__________________________________");
            #endregion
            #region PERSONA 2
            Persona persona2 = new Persona();
            persona2.Nombre = "Jorge";
            persona2.Apellido = "Peña";
            persona2.Edad = 18;
            persona2.Salario = 5;

            persona2.ImprimirDatos();

            Console.WriteLine("__________________________________");
            #endregion
            #region PERSONA 3
            Persona persona3 = new Persona();
            persona3.Nombre = "David";
            persona3.Apellido = "Gonzalez";
            persona3.Edad = 19;
            persona3.Salario = 10;

            persona3.ImprimirDatos();

            Console.WriteLine("__________________________________");
            #endregion
        }
    }
}
