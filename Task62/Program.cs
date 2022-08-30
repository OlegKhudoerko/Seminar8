// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int m = 4; // Количество строк и столбцов (справедливо и для остальных значений)
int[,] matrix = new int[m, m];
int valueArray = 1; //Начало массива (первое значение)
int rows = 0;
int colums = 0;
int right = m - 1;
int left = 0;
for (int k = 0; k < matrix.GetLength(0) - 2; k++) //Заполняем массив по циклу поэтапно...
{
    while (colums <= right && valueArray <= m * m) // Слева направо...
    {
        matrix[rows, colums] = valueArray;
        colums++; valueArray++;
    }
    rows++; colums--; right--;
    while (rows <= colums && valueArray <= m * m) // Сверху в низ...
    {
        matrix[rows, colums] = valueArray;
        rows++; valueArray++;
    }
    rows--; colums--;
    while (colums >= left && valueArray <= m * m) // Справа налево..
    {
        matrix[rows, colums] = valueArray;
        colums--; valueArray++;
    }
    colums++; left++; rows--;
    while (rows > colums + 1 && valueArray <= m * m) //Снизу вверх
    {
        matrix[rows, colums] = valueArray;
        rows--; valueArray++;
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < 10) Console.Write("0"); // Дорисовываем "0" впереди, если значение меньше "10"
        Console.Write(matrix[i, j] + "  ");        // Выводим результат
    }
    Console.WriteLine();
}
