// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.WriteLine("Введите количество строк массива:");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Int32.Parse(Console.ReadLine());
int[,] matrix = new int[m, n];
void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t"); 
        }
    Console.WriteLine();
    }
}
Console.WriteLine("Массив:");
GetArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine("Введите индексы элемента массива:");
int indexRows = Int32.Parse(Console.ReadLine());
int indexColumns = Int32.Parse(Console.ReadLine());
if(indexRows > m || indexColumns > n)
{
    Console.WriteLine("Такого элемента в массиве нет");
    return;
}
Console.WriteLine($"Искомый элемент {matrix[indexRows, indexColumns]}");