using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia7
{
    class Ejercicio_2
    {
        public void ejer2()
        {
            int par = 0, imp = 0;
            Console.WriteLine("Ingrese cuantos numeros: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] edades = new int[n];
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Ingrese numero " + (i + 1));
                edades[i] = Convert.ToInt32(Console.ReadLine());
                if (edades[i] % 2 ==0)
                {
                    par++;
                }
                else
                {
                    imp++;
                }
            }
            Console.Clear();
            Console.WriteLine("\n=================================");
            Console.WriteLine("Numeros PARES: \t" +par );
            Console.WriteLine("Numeros IMPARES: \t" + imp);
            Console.WriteLine("=================================");
            Console.WriteLine("\nPresione <ENTER> para continuar");
            Console.ReadKey();
        }
    }
}
