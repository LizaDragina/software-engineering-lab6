// Автор: студентка группы АБД(м)-51
//Проверка ветки
//Проверка ветки 2
//Проверка ветки 3
using System;
using MyLibrary;

class Program
{
    static void Main(string[] args)
    {
        int result = Calculator.Sum(5, 7);
        Console.WriteLine($"Результат из библиотеки: 5 + 7 = {result}");
        Console.ReadKey();
    }
}