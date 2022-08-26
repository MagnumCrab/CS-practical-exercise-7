// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите позицию элемента в строке");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента в столбце");
int n = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [3,4];
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}

if (m > numbers.GetLength(0) || n > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {m} строки и {n} столбца -> {numbers[m-1,n-1]}");
}