// EX002 Pole
// ----------------------------
// Použití datové struktury pole

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX002_Pole
{
    class Program
    {
        static void Main(string[] args)
        {
            // jednoduché pole a jeho naplnění
            // první způsob
            int[] pole = { 1, 2, 3, 4 };
            foreach (int x in pole)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
            // druhý způsob
            pole = new int[4];
            for (int i = 0; i < 4; i++)
            {
                pole[i] = i;
            }
            foreach (int x in pole)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();


            // dva typy vícerozměrného pole
            int[,] pole1 = new int[4, 3];
            int[][] pole2 = new int[4][];
            pole2[0] = new int[1];
            pole2[1] = new int[2];
            pole2[2] = new int[3];
            pole2[3] = new int[4];

            Console.WriteLine("Multidimenzionální pole:");
            for (int i = 0; i < pole1.GetLength(0); i++)
            {
                for (int j = 0; j < pole1.GetLength(1); j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Pole polí:");
            for (int i = 0; i < pole2.Length; i++)
            {
                for (int j = 0; j < pole2[i].Length; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            // vytvoření vícedimenzionálního pole a pole polí
            int[,] pole3 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[][] pole4 = new int[2][] { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9 } };

            Console.WriteLine("Multidimenzionální pole:");
            for (int i = 0; i < pole3.GetLength(0); i++)
            {
                for (int j = 0; j < pole3.GetLength(1); j++)
                {
                    Console.Write("{0} ",pole3[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pole polí:");
            for (int i = 0; i < pole4.Length; i++)
            {
                for (int j = 0; j < pole4[i].Length; j++)
                {
                    Console.Write("{0} ",pole4[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
