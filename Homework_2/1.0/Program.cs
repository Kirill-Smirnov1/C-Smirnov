﻿// Задача 1:
//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.Write("Введите трехзначное число а: ");
int a = int.Parse(Console.ReadLine());
if ((-1000 < a && a < -100) || (a < 1000 && a > 100))
{
    int d = a % 100; int c = d / 10;
    Console.Write($"Результат обработки: {Math.Abs(c)}");

}
else
Console.Write("Число не трехзначное!");
// Вариант из семинара (самостоятельно разобран, при минусовых значениях выдает результат с минусом).

//string aa(int bb)
//{
//    if((-1000 < bb && bb < -100) || (bb < 1000 && bb > 100))
//       return $"{bb / 10 % 10}";
//    return "Число не трехзначное";    
//}
//Console.Write(aa(int.Parse(Console.ReadLine())));

