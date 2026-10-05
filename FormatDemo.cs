using System;

namespace FormatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // # Заголовок первого уровня: Демонстрация Markdown
            // ## Заголовок второго уровня: Основная логика программы

            // Запрашиваем у пользователя первое число
            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            // Запрашиваем у пользователя второе число
            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Выполняем сложение
            double sum = number1 + number2;

            // --- Горизонтальная линия (разделитель) ---

            // ### Форматирование вывода:
            // *Курсив* для обычного текста
            // **Жирный** для акцента
            // ***Жирный курсив*** для важных значений
            // ~~Зачёркнутый~~ для отменённых операций
            // `Код` для технических данных
            
            Console.WriteLine("\n--- Результаты ---");
            
            // Демонстрация форматирования Markdown в консоли (имитация)
            Console.WriteLine($"*Вы ввели числа:* {number1} и {number2}");
            Console.WriteLine($"**Сумма чисел:** {sum}");
            Console.WriteLine($"***Итоговое значение:*** {sum}");
            
            // Пример с зачёркнутым текстом (в консоли не отображается, но в коде видно)
            // ~~Эта строка не должна была выполниться~~
            
            // Пример с блоком кода (в комментарии)
            // ```
            // string name;
            // name = Console.ReadLine();
            // Console.WriteLine(name)
            // ```

            // > Это пример цитаты в комментарии.
            
            Console.ReadKey();
        }
    }
}