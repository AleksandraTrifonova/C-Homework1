// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
int square = number2 * number2;
if (number1 == square)
{
    Console.Write("Число1 является квадратом числа2");
}
else
{
    Console.Write("Число1 не является квадратом числа2");
}