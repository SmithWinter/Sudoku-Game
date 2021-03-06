﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuGame
{
    public class SudokuChecker
    {
        public static bool CheckCellIsSafe(int[,] board, int row, int column, int value)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[row, i] == value || board[i, column] == value)
                {
                    return false;
                }
            }
            row = (row / 3) * 3;
            column = (column / 3) * 3;
            for (int i = row; i < row + 3; i++)
            {
                for (int j = column; j < column + 3; j++)
                {
                    if (board[i, j] == value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool CheckEmptyCell(int[,] board, ref int row, ref int column)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] == 0)
                    {
                        row = i;
                        column = j;
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool SudokuSolver(int[,] board, int row, int column)
        {
            if (CheckEmptyCell(board, ref row, ref column))
            {
                return true;
            }
            for (int i = 1; i <= 9; i++)
            {
                if (CheckCellIsSafe(board, row, column, i))
                {
                    board[row, column] = i;
                    if (SudokuSolver(board, row, column))
                    {
                        return true;
                    }
                    else
                    {
                        board[row, column] = 0;
                    }
                }
            }
            return false;
        }
        public static bool ValidateCell(int[,] a, int x, int y, int value)
        {
            for (int i = 0; i < 9; i++)
            {
                if (a[x, i] == value && i != y)
                {
                    return false;
                }
                if (a[i, y] == value && i != x)
                {
                    return false;
                }
            }
            int oldx = x;
            int oldy = y;
            x = (x / 3) * 3;
            y = (y / 3) * 3;
            for (int i = x; i < x + 3; i++)
            {
                for (int j = y; j < y + 3; j++)
                {
                    if (a[i, j] == value && i != oldx && j != oldy)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool SudokuValidation(int[,] SudokuMatrix)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (SudokuMatrix[i, j] == 0)
                    {
                        return false;
                    }
                    else
                    {
                        if (ValidateCell(SudokuMatrix, i, j, SudokuMatrix[i, j]) == false)
                        {
                            return false;
                        }
                    }
                    
                }
            }
            return true;
        }
    }
}
