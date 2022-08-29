﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = 3; // Количество строк
int n = 4; // Количество столбцов

int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10);
        Console.Write(matrix[i, j] + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int temp;
    for (int k = matrix.GetLength(1); k > 0; k--)
    {
        for (int j = 0; k > j + 1; j++)
        {
            if (matrix[i, j] > matrix[i, j + 1])
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, j + 1];
                matrix[i, j + 1] = temp;
            }
        }
        Console.Write(matrix[i, k - 1] + "  ");
    }
    Console.WriteLine();
}
