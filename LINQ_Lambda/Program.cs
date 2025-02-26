using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LAMBDA
            //ExpresionesLambda();
            //ExpresionesLINQ();
            RendimientoConsultas();

            Console.ReadLine();
        }

        static void RendimientoConsultas()
        {
            // Creamos un arreglo de enteros y lo inicializamos con 10 números aleatorios
            int[] numeros = { 10, 5, 6, 4, 3, 8, 9, 2, 1, 7 };

            // Ordernar los números
            //numeros = numeros.OrderBy(x => x).ToArray();

            // Medir memoria antes de iniciar el foreach
            long memoriaInicio = GC.GetTotalMemory(true);

            // Usar foreach
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            // Medir memoria después del foreach
            long memoriaFinal = GC.GetTotalMemory(true);
            Console.WriteLine($"Consumo de memoria del foreach: {memoriaFinal - memoriaInicio} bytes");

            // Medir memoria antes de iniciar el foreach
            memoriaInicio = GC.GetTotalMemory(true);

            // Usar string.
            string resultado = string.Join(",", numeros);
            Console.WriteLine(resultado);

            // Medir memoria después del foreach
            memoriaFinal = GC.GetTotalMemory(true);
            Console.WriteLine($"Consumo de memoria con string.Join: {memoriaFinal - memoriaInicio} bytes");

        }

        static void ExpresionesLambda()
        {
            // Creamos un arreglo de enteros y lo inicializamos con 10 números aleatorios
            int[] numeros = { 10, 5, 6, 4, 3, 8, 9, 2, 1, 7 };

            // Obtener todos los números pares del arreglo
            var numerosPares = numeros.Where(n => n % 2 == 0).ToArray();

            // Mostrar la informacion
            Console.WriteLine(string.Join(",", numerosPares));

            // Ordenar los elementos de manera ascendente
            var numerosAscedentes = numeros.OrderBy(n => n).ToArray();

            // Mostrar la informacion
            Console.WriteLine(string.Join(",", numerosAscedentes));

            // Ordenar los elementos de manera ascendente
            var numerosDescedentes = numeros.OrderByDescending(n => n).ToArray();

            // Mostrar la informacion
            Console.WriteLine(string.Join(",", numerosDescedentes));
        }

        static void ExpresionesLINQ()
        {
            // Creamos un arreglo de enteros y lo inicializamos con 10 números aleatorios
            int[] numeros = { 10, 5, 6, 4, 3, 8, 9, 2, 1, 7 };

            // Obtener todos los números pares del arreglo
            var numerosPares = (from numero in numeros
                              where numero % 2 == 0
                              select numero).ToArray();

            // Mostrar la informacion
            Console.WriteLine(string.Join(",", numerosPares));
        }


        static ArrayList ObtenerNumerosPares(int[] numeros)
        {
            ArrayList numerosPares = new ArrayList();

            // Ciclo foreach
            foreach (int numero in numeros)
            {
                if ( numero % 2 == 0)
                {
                    numerosPares.Add(numero);
                }
            }

            return numerosPares;
        }
    }
}
