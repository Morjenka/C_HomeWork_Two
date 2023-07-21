// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine(("Введите число: "));
int number = int.Parse(Console.ReadLine());
if (number >= 100 && number <1000)
{
    int res = (number % 10);
    Console.Write( "-> "+res);
}
if (number >= 1000 && number <10000)
{
    int res = (number % 100 - number % 10)/10;
    Console.Write( "-> "+res);
}
if (number >= 10000 && number <100000)
{
    int res = (number % 1000 - number % 10)/100;
    Console.Write( "-> "+res);
}