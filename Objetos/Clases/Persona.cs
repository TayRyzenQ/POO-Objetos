using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Objetos.Clases
{

    //la clase  es una plantilla que contiene objetos y metodos
    public class Persona
    {
        //
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }         // double se puso por le tamaño de la variable

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + this.Nombre);        //el 'this' esta en un nombre que ya esta declarado, se puede ocupar en distintos metodos
            Console.WriteLine("Apellido: " + this.Apellido);
            Console.WriteLine("Edad:" + this.Edad);
            Console.WriteLine("Salario: " + this.Salario);
        }
    }
}
