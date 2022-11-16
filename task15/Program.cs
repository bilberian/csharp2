// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7 включительно: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number < 1 || number > 7)
{
    Console.WriteLine("введено некорректное число");
}
else
{
    switch(number) {
        case 1:
            Console.WriteLine("нет, это вообще-то понедельник");
            break;
        case 2:
            Console.WriteLine("нет, это немного вторник");
            break;
        case 3:
            Console.WriteLine("нет, это все еще среда");
            break;
        case 4:
            Console.WriteLine("нет, это всего лишь четверг");
            break;
        case 5:
            Console.WriteLine("нет, но уже пятница!");
            break;
        case 6:
            Console.WriteLine("да, суббоотонька");
            break;
        case 7:
            Console.WriteLine("да, таки воскресенье");
            break;            
                    
    }
}