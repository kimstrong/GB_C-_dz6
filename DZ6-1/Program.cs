﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



Console.Clear();
Console.WriteLine($"Введите числа через пробел для подсчета количества чисел больше 0: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел > 0: {count}");

