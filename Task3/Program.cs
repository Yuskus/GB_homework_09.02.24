// Задача 3: Напишите программу, которая принимает на вход целое число
// из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Впишите число от 10 до 99 включительно:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9 && number < 100)
{
    int leftDigit = number / 10;
    int rightDigit = number % 10;
    if (leftDigit >= rightDigit)
    {
        Console.WriteLine("Наибольшая цифра числа: " + leftDigit);
    }
    else
    {
        Console.WriteLine("Наибольшая цифра числа: " + rightDigit);
    }
}
else
{
    Console.WriteLine("Ошибка! Введенное число не входит в предполагаемый диапазон.");
}