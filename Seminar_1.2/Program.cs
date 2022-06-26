//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N;
int Count = 1;
Console.WriteLine("Введите число ");
N = Convert.ToInt32(Console.ReadLine());
while (Count<=N)//Предполагаем, что в условии задания N - включая.
{
    if(Count%2==0)
    {
           Console.Write(Count + " "); 
    }

Count++;
}