using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia7
{
    class Ejercicio4
    {
        public void ejer4()
        {
            int[,] matriz = new int[5, 5];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine("Ingrese los valores de la fila: " + (i + 1));
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*******************************************************************");
            trnspst(matriz);
            Console.ReadKey();
        }

        static void trnspst(int[,] trans)
        {
            for (int i = 0; i < trans.GetLength(0); i++)
            {
                for (int j = 0; j < trans.GetLength(1); j++)
                {
                    Console.Write(trans[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
