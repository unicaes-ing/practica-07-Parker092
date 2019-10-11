using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia7
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("\t*** Guia 7 ***");
                Console.WriteLine("* 1 * Ejercicio 1.");
                Console.WriteLine("* 2 * Ejercicio 2.");
                Console.WriteLine("* 3 * Ejercicio 3.");
                Console.WriteLine("* 4 * Ejercicio 4.");
                Console.WriteLine("* 5 * Ejercicio 5.");
                Console.WriteLine("* 6 * Ejercicio 6.");
                Console.WriteLine("* 7 * Salir.");
                int.TryParse(Console.ReadLine(), out op);
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1 a = new Ejercicio1();
                        a.ejer1();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio_2 b = new Ejercicio_2();
                        b.ejer2();
                        Console.Clear();
                        break;
                    case 3:
                        Ejercicio3 c = new Ejercicio3();
                        c.ejer3();
                        break;
                    case 4:
                        Ejercicio4 d = new Ejercicio4();
                        d.ejer4();
                        break;
                    case 5:
                        Ejercicio5 e = new Ejercicio5();
                        e.ejer5();
                        break;
                    case 6:
                        Ejercicio6 f = new Ejercicio6();
                        f.ejer6();
                        break;
                }
            } while (op!=7);
           
        }
    }
}
