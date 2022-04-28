// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите число1: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число2 для проверки кратности: ");
int y = int.Parse(Console.ReadLine());

int div = x % y;
if (div == 0)
{
    Console.Write("Число1 кратно числу2 ");
}
else
{
    Console.Write("Остаток от деления числа1 на число2: ");
    Console.Write(div);
}