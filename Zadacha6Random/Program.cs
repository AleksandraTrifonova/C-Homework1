//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int x = new Random().Next(10,100);
Console.WriteLine(x);
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