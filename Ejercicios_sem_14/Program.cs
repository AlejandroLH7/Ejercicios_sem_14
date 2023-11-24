using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_sem_14
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Ordenar números");
                Console.WriteLine("===============================");
                Console.WriteLine ("Ingrese una lista de números: ");
                string inputNumeros = Console.ReadLine();

                MostrarColumnasOrdenadas(inputNumeros);

                Console.WriteLine("===============================");
                Console.Write("Ingrese una opción (Presione Enter para salir): ");
                string opcion = Console.ReadLine();

                if (opcion == "")
                {
                    break;
                }
            }
        }

        static void MostrarColumnasOrdenadas(string inputNumeros)
        {
            List<int> numeros = inputNumeros.Split(',').Select(int.Parse).ToList();

            numeros.Sort();

            List<List<int>> columnas = new List<List<int>>();
            for (int i = 0; i < numeros.Count; i += 4)
            {
                List<int> columna = numeros.Skip(i).Take(4).ToList();
                columnas.Add(columna);
            }

            foreach (var columna in columnas)
            {
                Console.WriteLine("[" + string.Join("] [", columna.Select(num => num.ToString("D3"))) + "]");
            }
        }
    }

}
        

