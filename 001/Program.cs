int a = 0, b = 0;

Console.Write("Ведите первое число:");

string username1 = Console.ReadLine();

a = int.Parse(username1);

Console.Write("Введите второе число: ");

string username2 = Console.ReadLine();

b = int.Parse(username2);

if(a == b * b)
{
    Console.Write("Первое число является квадратом второго.");
}
else 
{
    Console.Write("Первое число не является квадратом второго.");
}


