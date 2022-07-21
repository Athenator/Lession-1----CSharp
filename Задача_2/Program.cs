int a = 0;

Console.Write(" Введите число, соответвующее дню недели, от 1 до 7:  ");

string username = Console.ReadLine();

a = int.Parse(username);

if (a == 1)
{
    Console.Write("Сегодня Понедельник");
}
if (a == 2)
{
    Console.Write("Сегодня Вторник");
}
if (a == 3)
{
    Console.Write("Сегодня Среда");
}
if(a == 4)
{
    Console.Write("Сегодня Четверг");
}
if(a == 5)
{
    Console.Write("Сегодня Пятница");
}
if(a == 6)
{   
    Console.Write("Сегодня Суббота");
}
if(a == 7)
{
    Console.Write("Сегодня Воскресенье");
}
if(a > 7)
{
    Console.Write("Введите число от 1 до 7!");
}
if(a < 1)
{
    Console.Write("Введите число от 1 до 7!");
}