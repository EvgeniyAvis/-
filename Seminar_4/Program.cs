// Задача 25. Напишите цикл, который принимает на вход два числа А и В и возводит А в натуральную степень В.
Console.Clear();
Console.WriteLine("This programm implements raising your number to the power (A^B).");
Console.Write("Enter your number A: ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter your natural number B (the power): ");
int numberB = Convert.ToInt32(Console.ReadLine());
double result=0;

  if (numberB>0)// the power should be natural number
    {
     result = Power(numberA,numberB);
    }
  else
    {
     Console.WriteLine("ERROR! The power should be natural number,i.e. 1,2,3,4,5... Try again!");
     return;
    }

Console.WriteLine($"Raising {numberA} to the power {numberB} is equal to {result}.");

//*********************************************************************************//
double Power(double basis, int power)// this function return the power of the basis
{
 double powerResult=1;

 for(int index=1; index<=power; index++)
   {
    powerResult=powerResult * basis;
   }

 return powerResult;
}
//*********************************************************************************//
