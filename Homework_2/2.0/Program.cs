﻿//Задача 2:
//Напишите программу, которая выводит случайное, трёхзначное число и удаляет вторую цифру этого числа.
//645 -> 65
//782 -> 72
//918 -> 98
int Num = new Random().Next(100,1000);
Console.Write($"Случайное 3-значное число: {Num}");
int a = Num % 10; int b = Num/100*10;
Console.Write($" И вот оно без серединки: {b+a}" );
