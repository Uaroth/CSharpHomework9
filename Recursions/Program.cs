// Задача 1 Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

Console.WriteLine("Здравствуйте! Введите число N");
int numN = int.Parse(Console.ReadLine());

void ToOneRecursion(int number)
{
    if (number>0)
    {
    Console.Write($"{number}, ");
    number--;
    ToOneRecursion(number);
    }
}
