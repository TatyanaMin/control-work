// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

using System;
using static System.Console;
Clear();
 
string[] array = {"hello", "2", "world", ":-)"};

WriteLine($"В исходном массиве [{String.Join(", ", array)}] количество строк, длина которых меньше либо равна трём символам {GetCount(array)} это {FindStringsInArray1(array)}");
WriteLine();

int GetCount(string[] ar)
{
   int count = 0;
   for(int i = 0; i < ar.Length; i++)
   {
       if(ar[i].Length <= 3)
       {
           count++;
       }
   }
   return count;
}
string FindStringsInArray1(string[] arrStr)
{
   string result = String.Empty;
   for(int i = 0; i < arrStr.Length; i++)
   {
       if(arrStr[i].Length <= 3)
       {
           result += $"{arrStr[i]} ";
       }
   }
   return result;
}
