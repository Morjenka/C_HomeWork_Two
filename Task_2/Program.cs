﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write(("Введите трёхзначное число: "));
int number = int.Parse(Console.ReadLine());
if (number >= 100 && number <1000)
{
    int res = (number % 10);
    Console.Write( "-> "+res);

}
else
{
    Console.Write("третьей цифры нет");
}