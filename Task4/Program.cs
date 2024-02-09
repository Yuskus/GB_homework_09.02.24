// Задача 4: Напишите программу, которая на вход принимает 
// натуральное число N, а на выходе показывает его цифры через запятую.
//
// P.S. Решила сделать вывод слева направо и справа налево.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int reversedNumber = 0;
int digit = 0;
Console.WriteLine("Цифры числа справа налево:");
while (number > 0)
{
    digit = number % 10;
    Console.Write(digit);
    reversedNumber += digit;
    if (number > 9)
    {
        reversedNumber *= 10;
        Console.Write(", ");
    }
    else
    {
        Console.Write(".\n");
    }
    number /= 10;
}
Console.WriteLine("Цифры числа слева направо:");
while (reversedNumber > 0)
{
    digit = reversedNumber % 10;
    Console.Write(reversedNumber % 10);
    if (reversedNumber > 9)
    {
        Console.Write(", ");
    }
    else
    {
        Console.Write(".");
    }
    reversedNumber /= 10;
}