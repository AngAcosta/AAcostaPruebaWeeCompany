using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLComsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[4];

            int v;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingresa un Numero:");
                v = int.Parse(Console.ReadLine());
                numero[i] = v;
            }

            int max = numero[0], min = numero[0];

            for (int i = 0; i < 4; i++)
            {
                if (numero[i] > max)
                {
                    max = numero[i];
                }
                else if (numero[i] < min)
                {
                    min = numero[i];
                }
            }

            Console.WriteLine("El numero mayor: " + max);
            Console.WriteLine("El numero menor: " + min);
            Console.ReadKey();
            //--------------------------------------------------------------------
            //int[] numero = new int[5];
            //int v, max = numero[0], min = numero[0];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Ingresa un Numero: ");
            //    v = int.Parse(Console.ReadLine());
            //    numero[0] = v;
            //}
            //Console.WriteLine("El numero mayor: " + numero.Max());
            //Console.WriteLine("El numero menor: " + numero.Min());
            //Console.ReadKey();
        }
    }
}