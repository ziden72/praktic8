using System;

namespace praktic8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("1) Двумерный массив: ");
            int[,] h = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Random k = new Random();
                    int f = k.Next(0, 10);
                    h[i, j] = f;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write(String.Format("{0,3}", h[i, j]));
                Console.WriteLine();
            }
            //2
            int n = 0;
            long sum = h[0, 0];
            for (int i = 0; i < 10; i++)
            {
                if (sum < h[i, n])
                {
                    sum = h[i, n];
                }
                n++;
            }
            int u = 0;
            for (int i = 0; i < 10; i++)
            {
                if (h[i, u] == sum)
                {
                    Console.WriteLine("2) Максимальный элемент главной диагонали = " + h[i, u] + "\n2) Координаты: " + i + "," + u);
                    break;
                }
                u++;
            }
            int g = 0;
            long sum1 = h[0, 9];
            for (int i = 9; i > 0; i--)
            {
                if (sum1 < h[g, i])
                {
                    sum1 = h[g, i];
                }
                g++;
            }
            int u1 = 0;
            for (int i = 9; i > 0; i--)
            {
                if (h[u1, i] == sum1)
                {
                    Console.WriteLine("2) Максимальный элемент побочной диагонали = " + sum1 + "\n2) Координаты: " + i + "," + u1);
                    break;
                }
                u1++;
            }
            //3
            int r = 0;
            int d = 0;
            for (int i = 0; i < 10; i++)
            {
                d++;
                for (int j = 0; j < 10; j++)
                {
                    r = r + h[j, i];
                    if (j == 9)
                    {
                        Console.WriteLine("3) Сумма элементов " + d + " " + "столбца = " + r);
                        r = 0;
                    }
                }
            }
        }
    }
}