using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia7
{
    class Ejercicio6
    {
        public void ejer6()
        {
            int[,] mat = new int[6,6];
            Random ran = new Random();
            int num = 0;
            llenado(mat, num, ran);
            show(mat);

            Console.WriteLine("************************************************");

            Console.WriteLine("\nPresione <ENTER> para continuar");
            Console.ReadKey();
           
        }
        static void show(int[,] mat)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("   "+ mat[i,j]);
                }

                Console.WriteLine(" ");
            }
        }
        static void llenado(int[,] mat, int num, Random ran)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    num = ran.Next(10, 100);
                    while (verfica(mat, num) == false)
                    {
                        num = ran.Next(10, 100);
                    }
                    mat[i, j] = num;
                }
            }
        }
        static bool verfica(int[,] mat, int num)
        {
            bool x = true;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (num == mat[i,j])
                    {
                        x = false;
                    }
                    else
                    {
                        x = true;
                    }
                }
            }
            return x;
        }
    }
}
