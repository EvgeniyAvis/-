// Задача 23. Напишите программу, которая принимает на вход число N и выдает таблицу кубов от 1 до N.
Console.Clear();// clear console
Console.WriteLine("This programm calculates cubes of numbers from 1 to entered number.");
Console.Write("Enter your positive integer: ");
int userNumber=Convert.ToInt32(Console.ReadLine());

if (userNumber<0)//check the entered number
{
  Console.Write("Entered number is negative! Do you want to convert your number to positive? y/n: ");
  string? answer=Console.ReadLine();

    if (answer=="y")
      {
        userNumber=-userNumber;
      }
    else
      {
       return;
      }
}

Cube(userNumber);// call our function


void Cube(int number)//this function returns cubes from 1 to entered number
{
  for(int index=1; index<=number; index++)
  {
   double result=Math.Pow(index,3);
   Console.WriteLine($"Cube of {index} is {result}");
  }
}