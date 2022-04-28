//Показать четные числа от 1 до N
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int n2 = 2;

while (n2 <= n)
{
    Console.Write(" ");
    Console.Write(n2);
    n2 = n2 + 2;
}
