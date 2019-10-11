using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia7
{
    class Ejercicio5
    {
        public void ejer5()
        {
            int[,] mat1 = new int[3, 3];
            int[,] mat2 = new int[3, 3];
            Console.WriteLine("Matriz 1");
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                Console.WriteLine("Ingrese los valores para la fila: "+ (i + 1));
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    mat1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz 2");
            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                Console.WriteLine("Ingrese los valores para la fila: " + (i + 1));
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    mat2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            suma(mat1, mat2);
            Console.ReadLine();
        }
        static void suma(int[,] mat1, int[,] mat2)
        {
            int[,] suma = new int[3, 3];
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    suma[i, j] = mat1[i, j] + mat2[i, j];
                    Console.Write(suma[i, j] + "");
                }
                Console.WriteLine();
            }
        }
    }
}
