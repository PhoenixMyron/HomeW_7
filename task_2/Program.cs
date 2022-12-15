// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) 
// {
//     for (int j = 0; j < matr.GetLength(1); j++) 
//     {
//         Console.Write($"{matr[i, j]} \t");
//     }
//   Console.WriteLine();
// }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) 
// {
//     for (int j = 0; j < matr.GetLength(1); j++) 
//     {
//         matr[i, j] = new Random().Next(1, 100);
//     }
// }

// }
// void FindArray(int[,] matr, int m, int n)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) 
// {
//     for (int j = 0; j < matr.GetLength(1); j++) 
//     {
//         if (i == m && j == n)
//         {
//              Console.Write($"{matr[i, j]} \t");
//         }
//         else
//         Console.Write(" Такой позиции нет ");
//     }
// }
// }





// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// string[] numbers = Console.ReadLine().Split(" ");
// int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
// Console.Write("Введите искомую позицию: ");
// string[] number = Console.ReadLine().Split(" ");
// int m = int.Parse(number[0]);
// int n = int.Parse(number[1]);
// PrintArray(matrix);
// FillArray(matrix);
// PrintArray(matrix);
// FindArray(matrix,m,n);
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
if ( m > matrix.Length(0) - 1 || n > matrix.Length(1) )
{
    Console.Write(" Такой позиции нет");
}
Console.Write($"{matrix[m, n]} \t");