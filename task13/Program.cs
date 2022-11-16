// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
// else if (number >= 100 && number <= 999)
// {
//     Console.WriteLine($"Третья цифра: {number%10}");
// }
else 
{
string num = number.ToString();
Console.WriteLine(num[2]);
}
