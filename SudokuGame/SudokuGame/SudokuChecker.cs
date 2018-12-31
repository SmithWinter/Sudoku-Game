using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuGame
{
    public class SudokuChecker
    {
        public static bool safe(int[,] a, int x, int y, int value)
        {
            for (int i = 0; i < 9; i++)
                if (a[x, i] == value || a[i, y] == value)
                {
                    return false;
                }
            x = (x / 3) * 3;
            y = (y / 3) * 3;
            for (int i = x; i < x + 3; i++)
            {
                for (int j = y; j < y + 3; j++)
                {
                    if (a[i, j] == value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool check(int[,] a, ref int x, ref int y)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (a[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool solve(int[,] a, int x, int y)
        {
            if (check(a, ref x, ref y))
            {
                return true;
            }
            for (int i = 1; i <= 9; i++)
            {
                if (safe(a, x, y, i))
                {
                    a[x, y] = i;
                    if (solve(a, x, y))
                    {
                        return true;
                    }
                    else
                    {
                        a[x, y] = 0;
                    }
                }
            }
            return false;

        }
    }
}
