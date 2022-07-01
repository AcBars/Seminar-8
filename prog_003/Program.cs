/*
Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых
расположен наименьший элемент.
*/

using System;
using static System.Console;

Clear();

WriteLine("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
int[,] array = GetArray(m, n);
PrintArray(array);



int [,] GetArray (int m, int n)
{
    int [,] result=new int [m, n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]=new Random().Next(-10,11);
        }
    }
    return result;
}

void PrintArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Write($"{result[i, j]} \t ");
        }
        WriteLine();
    }
}

int [,] ArrayNoMin(int [,] arr)
{
    
}