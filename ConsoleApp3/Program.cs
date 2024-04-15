namespace calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            decimal one, two, result;
            char sign;
            Console.WriteLine("Введите первое число, а затем знак действия (только +)");
            Console.Write("Первое число - ");
            while (Decimal.TryParse(Console.ReadLine(), out one) == false)
            {
                Console.WriteLine("Введите корректное значение");
                Console.Write("Первое число - ");
            }
            Console.Write("Введите знак действия: ");
            Console.Write("Второе число - ");
            while (Decimal.TryParse(Console.ReadLine(), out two) == false)
            {
                Console.WriteLine("Введите корректное значение");
                Console.Write("Второе число - ");
            }
            if (sign == '+')
            {
                result = one + two;
                Console.WriteLine("Сумма ваших чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == '*')
            {
                result = one * two;
                Console.WriteLine("Умножение ваших чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
                if (sign != '+');
                {
                    Console.WriteLine("Введите корректный знак");
                    Console.ReadKey();
                }
            }
        }
    }
}