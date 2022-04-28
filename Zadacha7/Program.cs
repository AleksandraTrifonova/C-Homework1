// Удалить вторую цифру трёхзначного числа

Console.WriteLine("ВВедите трехзначное число: ");
int x = int.Parse(Console.ReadLine());
int digit1 = x / 100;
int digit2  = (x / 10) % 10;
int digit3 = x % 10;
Console.Write("Ответ на задачу: " + digit1 + digit3);