// Задача 1. Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

Console.WriteLine("Задача 1:");
int numN1 = 10;
ToOneRecursion(numN1);

void ToOneRecursion(int number)
{
    if (number > 1)
    {
        Console.Write($"{number}, ");
        number--;
        ToOneRecursion(number);
    }
    else Console.Write($"{1}.");
}
Console.WriteLine();

// Задача 2.Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Задача 2:");
int numM2 = 4;
int numN2 = 8;

SumBetween(numM2, numN2);

void SumBetween(int number1, int number2)
{
    int sum = number1;
    while (number2 > number1)
    {
        sum = sum + number2;

        number2--;

    }
    Console.WriteLine(sum);

}

// Задача 3. Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// (Здесь сам понять не смог уже на уровне функции, поэтому взял в Сети)

Console.WriteLine("Задача 3:");
int numM3 = 3;
int numN3 = 2;
Console.WriteLine(Akkerman (numM3, numN3)); 

int Akkerman(int number1, int number2)
{
  if (number1 == 0)
    return number2 + 1;
  else
    if ((number1 != 0) && (number2 == 0))
      return Akkerman(number1 - 1, 1);
    else
      return Akkerman(number1 - 1, Akkerman(number1, number2 - 1));

}