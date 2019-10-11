using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia7
{
    class Ejercicio1
    {
        public void ejer1()
        {
            int mayor = 0, menor = 0;
            Console.WriteLine("Ingrese cuantas personas: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] edades = new int[n];
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Ingrese la edad de la persona "+(i+1));
                edades[i] = Convert.ToInt32(Console.ReadLine());
                if (edades[i]>=18)
                {
                    mayor++;
                }
                else
                {
                    menor++;
                }
            }
            Console.Clear();
            Console.WriteLine("\n=================================");
            Console.WriteLine("Personas Mayores de edad: "+mayor);
            Console.WriteLine("Personas Menores de edad: "+menor);
            Console.WriteLine("=================================");
            Console.WriteLine("\nPresione <ENTER> para continuar");
            Console.ReadKey();
        }
    }
}
