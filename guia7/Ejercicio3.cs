using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia7
{
    class Ejercicio3
    {
        public static string[][] plantillas;
        public void ejer3()
        {
            int cant;
            Console.WriteLine("Cantidad de Equipos: ");
            int.TryParse(Console.ReadLine(), out cant);
            plantillas = new string[cant][];
            string[] nombres = new string[cant];
            for (int i = 0; i < plantillas.Length; i++)
            {
                Console.WriteLine("Nombre de Equipo ");
                nombres[i] = Console.ReadLine();
                plantillas[i] = new string[11];
                for (int j = 0; j < plantillas[i].Length; j++)
                {
                    Console.WriteLine("Ingrese nombre del Jugador Nª " + (j + 1));
                    plantillas[i][j] = Console.ReadLine();
                }
            }
            showTeams(nombres);
            Console.Clear();
            Console.WriteLine("\nPresione <ENTER> para continuar");
            Console.ReadKey();
        }
        public void showTeams(string[] nombres)
        {
            Console.Clear();
            Console.WriteLine("***Informacion de equipos.***");
            for (int i = 0; i < plantillas.Length; i++)
            {
                Console.WriteLine("\nEquipo: " + nombres[i]);
                for (int j = 0; j < plantillas[i].Length; j++)
                {
                    Console.Write(plantillas[i][j]+", ");
                }

                Console.WriteLine(" ");
            }
        }
    }
}
