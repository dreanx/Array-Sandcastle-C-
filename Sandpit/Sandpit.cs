using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandpit
{
    internal class Sandpit
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int[] array2 = {15,82,43};

            Console.WriteLine("Printing a value of the empty Array:");
            Console.WriteLine(array1[2]);
            Console.WriteLine("Printing a value of the filled Array:");
            Console.WriteLine(array2[1]);

            Console.WriteLine("Printing Arrays with foreach (print the values):");
            foreach (int i in array1)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            foreach (int i in array2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Printing Arrays with for (prints the indexes)(i):");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Printing Arrays with for (prints the values)(array[i]):");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i]+" ");
            }

            Console.ReadKey();
        }
    }
}
