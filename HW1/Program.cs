using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 1 до 50: ");

            var tmp = Console.ReadLine();
            int n;                                                        // количество чисел в последовательности
            while (int.TryParse(tmp, out n) == false || n < 1 || n > 50)  // проверка на правильность ввода
            {
                Console.Clear();
                Console.WriteLine("Неправильный ввод");
                tmp = Console.ReadLine();
            }

            int i = 0;                                                    // количество нечетных чисел в последовательности

            while (n != 0)                                                // считаем количество нечетных чисел в последовательности
            {
                if (n % 2 != 0)
                    ++i;
                --n;
            }

            // если нечетных чисел четное количество, то вся последовательность четная
            // если нечетных чисел НЕчетное количество, то вся последовательность НЕчетная
            if (i % 2 == 0)
                Console.WriteLine("black");
            else
                Console.WriteLine("grimy");

        }
    }
}
