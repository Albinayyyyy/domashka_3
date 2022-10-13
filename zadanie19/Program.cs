
Console.Clear();
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length(Console.ReadLine()!);
if (len == 5)
{
    while (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}
