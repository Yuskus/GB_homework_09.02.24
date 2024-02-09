// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Впишите координату x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Впишите координату y:");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("Координатная четверть: 1-ая.");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Координатная четверть: 2-ая.");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Координатная четверть: 3-я.");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Координатная четверть: 4-ая.");
}
else
{
    Console.WriteLine("Одна или обе точки координат лежат на оси, поэтому определить координатную четверть невозможно.");
}