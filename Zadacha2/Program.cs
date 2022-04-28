// По заданному номеру дня недели вывести его название

Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
int a = int.Parse(Console.ReadLine());

if (a == 1)
{
    Console.Write("Monday");
}
if (a == 2)
{
    Console.Write("Tuesday");
}
if (a == 3)
{
    Console.Write("Wednesday");
}
if (a == 4)
{
    Console.Write("Thursday");
}
if (a == 5)
{
    Console.Write("Friday");
}
if (a == 6)
{
    Console.Write("Saturday");
}
if (a == 7)
{
    Console.Write("Sunday");
}
