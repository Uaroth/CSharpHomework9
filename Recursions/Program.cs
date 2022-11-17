// Задача 1 Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

int numN = 10;
ToOneRecursion(numN);

void ToOneRecursion(int number)
{
    if (number>1)
    {
    Console.Write($"{number}, ");
    number--;
    ToOneRecursion(number);
    }
    else Console.Write($"{1}.");
}
