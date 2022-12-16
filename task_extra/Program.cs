// extra task
void InputMatrix(int[, ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(0, 2); // [1, 10]
}
}
}
void InputSecondMatrix(int[, ] SecondMatrix)
{
for (int i = 0; i < SecondMatrix.GetLength(0); i++)
{
for (int j = 0; j < SecondMatrix.GetLength(1); j++)
{
SecondMatrix[i, j] = new Random().Next(0, 2); // [1, 10]
}
}
}
void PrintSecondImage(int[,] SecondMatrix)
{
    for (int i = 0; i < SecondMatrix.GetLength(0); i++) 
{
    for (int j = 0; j < SecondMatrix.GetLength(1); j++) 
    {
        if(SecondMatrix[i, j] == 0) Console.Write($"W \t");
        else Console.Write($"B \t");
    }
  Console.WriteLine();
}
}
void PrintImage(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        if(matrix[i, j] == 0) Console.Write($"B \t");
        else Console.Write($"W \t");
    }
  Console.WriteLine();
}
}
void NegativeImage(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        if(matrix[i, j] == 0) Console.Write($"W \t");
        else Console.Write($"B \t");
    }
  Console.WriteLine();
}
}
void PrintDifference(int[,] matrix, int[,] SecondMatrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (matrix[i, j] != SecondMatrix[i, j])
            {
                count++;
            }
        }
    }
    Console.WriteLine($"{count} ");
}
Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
int[, ] SecondMatrix = new int[size[0], size[1]];
Console.WriteLine(" Исходная картинка: ");
InputMatrix(matrix);
PrintImage(matrix);
Console.WriteLine(" Негатив, предложенный Мишей: ");
InputSecondMatrix(SecondMatrix);
PrintSecondImage(SecondMatrix);
Console.WriteLine(" Правильный негатив: ");
NegativeImage(matrix);
Console.WriteLine(" Количество ошибок в негативе Миши: ");
PrintDifference(matrix,SecondMatrix);

