// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number <= 99 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int digit1 = number/100 * 100;
    number = number - digit1;
    int digit2 = number/10;
    Console.WriteLine($"Ответ: {digit2}");
}