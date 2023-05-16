using Objetos.Clases;
using System;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciar: crear algo real (ya sea un objeto o darle valores)
            Persona persona = new Persona();            //persona es la variable para el objeto
            persona.Nombre = "Juana";
            persona.Apellido = "De la Cruz";
            persona.Edad = 35;
            persona.Salario = 10858.53;
            persona.Imprimir();     //aqui mandamos a llamar al metodo 'Imprimir' que esta dentro de persona
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("==========================================================");
            Console.ForegroundColor= ConsoleColor.White;

            Persona persona2 = new Persona();
            persona2.Nombre = "Leonarda";
            persona2.Apellido = "Rojas";
            persona2.Edad = 18;
            persona2.Salario = 8058.53;
            persona2.Imprimir();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================================================");
            Console.ForegroundColor = ConsoleColor.White;

            Persona persona3 = new Persona();
            persona3.Nombre = "Chayanne";
            persona3.Apellido = "Lopez";
            persona3.Edad = 24;
            persona3.Salario = 530.8;
            persona3.Imprimir();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================================================");
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
