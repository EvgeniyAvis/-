// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Sum(int number)
{
    int result = 0;
       while ( number/10 > 0)
    {
         result = result + number % 10;
         number = number/10;
    }
    result = result + number;
    return result;
}
int sum = Sum(num);
Console.WriteLine($"Сумма цифр числа {num} = {sum}"); 
