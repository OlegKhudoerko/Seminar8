// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = 3; // Задаем количество строк массива
int n = 3; // Задаем количество столбцов массива
int[,] firstMatrix = GetArray(m, n); // Заполняем массивы...
int[,] secondMatrix = GetArray(m, n); 
PrintArray(); // Выводим массивы как в задании
PrintMultiplyArray(); // Выводим результат произведения массивов

int[,] GetArray(int m, int n) // Метод заполнения массивов
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) matrix[i, j] = new Random().Next(10);
    }
    return matrix;
}

void PrintArray() // Метод вывода массивов
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            Console.Write(firstMatrix[i, j] + "   ");
        }
        Console.Write(" |   ");
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            Console.Write(secondMatrix[i, k] + "   ");
        }
        Console.WriteLine();
    }
}

void PrintMultiplyArray() // Метод вывода мпроизведения масивов 
{
    Console.WriteLine();
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            Console.Write(firstMatrix[i, j] * secondMatrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
