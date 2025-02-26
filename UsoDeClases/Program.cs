using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsoDeClases.Modelos;

namespace UsoDeClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancar la clase Persona, en otras palabras crear un objeto
            Persona persona1 = new Persona("Mario", "Alvarenga", 18, DateTime.Parse("2007/05/02"), "06223410-5", "7023-0000", "San Salvador Centro", "marioalvarenga@example.com"); // Creamos el objeto "persona1"
            // Mostrar datos del objeto persona1
            Console.WriteLine(persona1.ToString());

            // Crear objeto persona2
            Persona persona2 = new Persona("Julio", "Menjivar", 19, DateTime.Parse("2006/08/02"), "06223850-5", "7000-4000", "San Salvador Norte", "juliomenjivar@example.com");
            // Mostrar datos del objeto persona2
            Console.WriteLine(persona2.ToString());

            Console.ReadLine();
        }
    }
}
