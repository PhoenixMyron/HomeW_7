// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[, ] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double summa = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summa += matrix[i, j];
        }
        Console.WriteLine($"Столбец {j + 1} = {Math.Round(summa / matrix.GetLength(0), 1)}");
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] size = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(size[0]), int.Parse(size[1])];
InputMatrix(matrix);
ReleaseMatrix( matrix);

