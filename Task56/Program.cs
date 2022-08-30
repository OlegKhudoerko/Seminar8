// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = 4; // Количество строк и столбцов
int sum = int.MaxValue;
int rows = 0;
int[,] matrix = new int[m, m];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int temp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10);
        temp += matrix[i, j];
        Console.Write(matrix[i, j] + "  ");
    }
    if (sum > temp)
    {
        sum = temp;
        rows = i;
    }
    Console.WriteLine($"  сумма  = {temp}");
}
Console.WriteLine($"{rows+1} строка");
