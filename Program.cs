using System;

namespace laba2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] s = createarray(n, m);
            for (int i = 0; i < s.GetLength(0); i++)
            {
                for (int j = 0; j < s.GetLength(1); j++)
                {
                    Console.Write(s[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("_____________________");
            int[,] trans = swap(s);
            for (int i = 0; i < trans.GetLength(0); i++)
            {
                for (int j = 0; j < trans.GetLength(1); j++)
                {
                    Console.Write(trans[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] createarray(int n, int m)
        {
            int[,] mas = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = random.Next(-3, 10);
                }
            }
            return mas;
        }
        public static int[,] swap(int[,] mas)
        {
            int[,] jorikTrans = new int[mas.GetLength(1), mas.GetLength(0)];
            for (int i = 0; i < jorikTrans.GetLength(0); i++)
            {
                for (int j = 0; j < jorikTrans.GetLength(1); j++)
                {
                    jorikTrans[i, j] = mas[j, i];

                }
            }
            return jorikTrans;
        }

    }
}
