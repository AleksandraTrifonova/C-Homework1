//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Введите число от 10 до 99: ");
int x = int.Parse(Console.ReadLine());
int digit1 = (x/ 10) % 10;
int digit2 = x % 10;
if (digit1 > digit2)
{
Console.Write("Наибольшая цифра числа: ");
Console.Write(digit1);
}
else
{
Console.Write("Наибольшая цифра числа: ");
Console.Write(digit2);    
}