using System;
using MyLibrary;

/**
 * @brief Главный класс консольного приложения.
 * 
 * Отвечает за точку входа в программу и взаимодействие с библиотекой MyLibrary.
 */
class Program
{
    /**
     * @brief Метод Main является точкой входа в приложение.
     * 
     * Вызывает метод Sum из библиотеки MyLibrary и выводит результат в консоль.
     * 
     * @param args (string[]) Массив строковых аргументов командной строки, передаваемых при запуске.
     * @return (void) Метод не возвращает значений.
     */
    static void Main(string[] args)
    {
        int testResult = Calculator.Sum(5, 7);
        Console.WriteLine($"Результат из библиотеки: 5 + 7 = {testResult}");
        Console.ReadKey();
    }
}