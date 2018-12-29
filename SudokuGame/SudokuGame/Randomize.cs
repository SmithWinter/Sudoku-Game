using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuGame
{
    static class Randomize
    {
        static Random random = new Random();
        public static void Transpose(int[,] array)
        {
            int temp = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    temp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = temp;
                }
            }
        }

        public static void SwapRows(int[,] array)
        {
            int a = random.Next(0, 8);
            int b = random.Next(0, 8);
            while (!Allowed(a, b))
            {
                b = random.Next(0, 8);
            }
            int temp;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                temp = array[i, a];
                array[i, a] = array[i, b];
                array[i, b] = temp;
            }
        }

        public static void SwapBigRows(int[,] array)
        {
            int a = random.Next(1, 4);
            int b = random.Next(1, 4);
            if (a == b)
            {
                while (a == b)
                {
                    b = random.Next(1, 3);
                }
            }
            int temp;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    temp = array[i + 3 * (a - 1), j];
                    array[i + 3 * (a - 1), j] = array[i + 3 * (b - 1), j];
                    array[i + 3 * (b - 1), j] = temp;
                }
            }
        }

        public static void SwapColumns(int[,] array)
        {
            int a = random.Next(0, 8);
            int b = random.Next(0, 8);

            while (!Allowed(a, b))
                b = random.Next(0, 8);

            int temp;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                temp = array[a, i];
                array[a, i] = array[b, i];
                array[b, i] = temp;
            }
        }

        public static void SwapBigColumns(int[,] array)
        {
            int a = random.Next(1, 4);
            int b = random.Next(1, 4);
            if (a == b)
            {
                while (a == b)
                {
                    b = random.Next(1, 4);
                }
            }
            int temp;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    temp = array[j, i + 3 * (a - 1)];
                    array[j, i + 3 * (a - 1)] = array[j, i + 3 * (b - 1)];
                    array[j, i + 3 * (b - 1)] = temp;
                }
            }
        }

        public static int[,] Mix(int[,] array)
        {
            int b = random.Next(40, 50); 

            for (int i = 0; i < 40; i++)
            {
                int s = random.Next(1, 7);
                switch (s)
                {
                    case 1:
                        {
                            SwapColumns(array);
                            break;
                        }
                    case 2:
                    case 6:
                        {
                            SwapRows(array);
                            break;
                        }
                    case 3:
                        {
                            Transpose(array);
                            break;
                        }
                    case 4:
                    case 7:
                        {
                            SwapBigColumns(array);
                            break;
                        }
                    case 5:
                        {
                            SwapBigRows(array);
                            break;
                        }
                    default:
                        {
                            SwapRows(array);
                            break;
                        }
                }
            }
            return array;
        }

        public static bool Allowed(int a, int b)
        {
            if ((a == 0) || (a == 3) || (a == 6))
            {
                if ((b == a + 1) || (b == a + 2))
                {
                    return true;
                }
            }

            if ((a == 1) || (a == 4) || (a == 7))
            {
                if ((b == a - 1) || (b == a + 1))
                {
                    return true;
                }
            }
            if ((a == 2) || (a == 5) || (a == 8))
            {
                if ((b == a - 1) || (b == a - 2))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
