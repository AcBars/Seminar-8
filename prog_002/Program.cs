/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент входных данных.
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
FrequencyDictionary(array);



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
void FrequencyDictionary(int [,] array)
{
    for(int k=-10; k<11; k++)        
    {
        int count=0;
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
            count+=k==array[i,j]? 1: 0;
            }
        }
       if(count!=0) WriteLine($"{k} встречается {count} раз");
        
    }
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