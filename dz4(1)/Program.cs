double itog;
string sign;
Console.WriteLine("Введите число 1");
int operand1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int operand2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Виберите операцию над переменными: \nОперация сложения (+)\n операция вычитания(-)\n операция умножения(*)\n операция деления(/)\n операция получение остатка от целочисленного деления(%)\n");
sign = Console.ReadLine();

switch (sign)
{
    case "+":
     {
         itog= operand1 + operand2;
            Console.WriteLine($"Операция сложения = {itog} ");
            break;
     }
    case "-":
        {
            itog = operand1 - operand2;
            Console.WriteLine($"операция вычитания = {itog} ");
            break;
        }
    case "*":
        {
            itog = operand1 * operand2;
            Console.WriteLine($"операция умножения = {itog} ");
            break;
        }
    case "/":
        {
            if (operand1 == 0)
            {
                Console.WriteLine("на ноль делить нельзя ╰（‵□′）╯");
            }
            else if (operand2 == 0)
            {
                Console.WriteLine("на ноль делить нельзя ╰（‵□′）╯");
            }
            else
            {
                itog = operand1 / operand2;
                Console.WriteLine($"операция деления = {itog} ");
            }
            break;
            
        }
    case "%":
        {
            itog = operand1 % operand2;
            Console.WriteLine($"операция получение остатка от целочисленного деления = {itog} ");
            break;
        }
}
Console.ReadKey();