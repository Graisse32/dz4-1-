Console.WriteLine("Введите число [от 0 до 100]");
int operand = Convert.ToInt32(Console.ReadLine());

if (operand <= 14)
{
    if (operand >= 0)
        Console.WriteLine("Число лежит в промежутке [0-14]");
}
else if (operand <= 35)
{
    if (operand >= 15)
        Console.WriteLine("Число лежит в промежутке [15-35]");
}
else if (operand <= 50)
{
    if (operand >= 36)
        Console.WriteLine("Число лежит в промежутке [36-50]");
}
else if (operand <= 100)
{
    if (operand >= 51 )
        Console.WriteLine("Число лежит в промежутке [50-100]");
}
Console.ReadKey();