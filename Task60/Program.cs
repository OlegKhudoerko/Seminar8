﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int m = 2;
int[,,] matrix = new int[m, m, m];
int temp = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            foreach (int element in matrix)
            {
                matrix[i, j, k] = new Random().Next(10, 100); // Заполнение массива
                if (matrix[i, j, k] == temp) //Проверка на повтор значений в массиве
                {
                    while (matrix[i, j, k] != temp) matrix[i, j, k] = new Random().Next(10, 100);// Регеннерация дубликата
                }
                temp = matrix[i, j, k];
            }
            Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}

