﻿// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine ("Введите пятизначное число");
int num = Convert.ToInt32 (Console.ReadLine ());
if (num > 9999 && num < 100000) //Проверяем число на пятизначность, если да выполняем строки с 16 по 21 
{
int num1 = num / 10000; //Вычисляем первую цифру
int num2 = num / 1000; //Вычисляем вторую цифру
int num3 = num / 10; //Вычисляем четвертую цифру
int num4 = num % 10; //Вычисляем пятую цифру
    if (num1 == num4 && num2 == num3) Console.WriteLine ($"{num} -> да"); //Если 1 и 5-я цифры и 2 и 4 цифры равны выводим "да"
    else Console.WriteLine ($"{num} -> нет"); //Если 1 и 5-я цифры и 2 и 4 цифры не равны выводим "нет"
}
else Console.WriteLine ($"Число {num} не является пятизначным");//Если число не пятизначное выводим сообщение об ошибке