// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
{
    for (int j = 0; j < matr.GetLength(1); j++) 
    {
        Console.Write($"{matr[i, j]} \t");
    }
  Console.WriteLine();
}
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
{
    for (int j = 0; j < matr.GetLength(1); j++) 
    {
        matr[i, j] = new Random().Next(1, 100);
    }
}

}

void ReleaseMatrix(int[, ] matrix, int m, int n)
{
    if (m >= matrix.GetLength(0) || n >= matrix.GetLength(1) || m < 0 || n < 0)
        Console.WriteLine("К сожалению, такая позиция отсуствует");
    else
        Console.Write($"{matrix[m - 1, n - 1]} \t");
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
Console.Write("Введите искомую позицию: ");
string[] number = Console.ReadLine().Split(" ");
int m = int.Parse(number[0]);
int n = int.Parse(number[0]);
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
ReleaseMatrix(matrix, m, n);

