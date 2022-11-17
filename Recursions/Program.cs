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
int numM = 4;
int numN2 = 8;
SumBetweenRecursion(numM, numN2);

void SumBetweenRecursion(int number1, int number2)
{
    for (int sum = number1 + number2; number2 > number1; number2--)
    {
        SumBetweenRecursion(number1, number2);
        Console.Write($"{sum}, ");
    }


}