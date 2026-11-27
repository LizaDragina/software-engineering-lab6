namespace MyLibrary
{
    /**
     * @brief Класс для выполнения базовых математических операций.
     * 
     * Предоставляет статические методы для вычислений в рамках программного комплекса.
     */
    public class Calculator
    {
        /**
         * @brief Поле, хранящее версию модуля вычислений.
         */
        public static string ModuleVersion = "1.0";

        /**
         * @brief Метод Sum вычисляет сумму двух целых чисел.
         * 
         * @param firstNumber (int) Первое слагаемое для операции сложения.
         * @param secondNumber (int) Второе слагаемое для операции сложения.
         * @return (int) Возвращает целочисленный результат сложения параметров. Допустимые значения: от -2147483648 до 2147483647 (без учета переполнения).
         */
        public static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}