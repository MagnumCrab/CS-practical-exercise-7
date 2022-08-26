// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");
double[,] matrix = new double[m, n];
EnterTheMatrix(matrix);
WriteArray(matrix);
Console.WriteLine();

void EnterTheMatrix(double[,] matrix)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      matrix[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray(double[,] matrix)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double numbers = Math.Round(matrix[i, j], 1);
        Console.Write(numbers + " ");
      }
      Console.WriteLine();
  }
}