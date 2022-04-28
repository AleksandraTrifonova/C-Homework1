// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());

if (a > 99 && a < 1000)
{
int digit2 = (a / 10) % 10;
Console.Write("Вторая цифра трехзначного числа: ");
Console.Write(digit2);
}
else
{
    Console.Write("Число не является трехзначным");
}