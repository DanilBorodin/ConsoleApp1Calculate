namespace calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            decimal one, two, result;
            string sign;
            Console.WriteLine("Введите первое число, а затем знак действия (только + или *)");          
            Console.Write("Первое число - ");
            while (!Decimal.TryParse(Console.ReadLine(), out one))
            {
                Console.WriteLine("Введите корректное значение");
                Console.Write("Первое число - ");
            }

            Console.Write("Введите знак действия:");
            sign = Console.ReadLine();
            while (sign != "+" && sign != "*" && sign != "/" && sign != "-")
            {
                Console.WriteLine("Введите корректный знак");
                Console.Write("Введите знак - ");
                sign = Console.ReadLine();

            }

            Console.Write("Второе число - ");
            while (!Decimal.TryParse(Console.ReadLine(), out two))
            {
                Console.WriteLine("Введите корректное значение");
                Console.Write("Второе число - ");
            }

            if (sign == "+")
            {
                result = one + two;
                Console.WriteLine("Сумма ваших чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == "*")
            {
                result = one * two;
                Console.WriteLine("Умножение ваших чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
            }
            else if (sign == "-")
            {
                result = one - two;
                Console.WriteLine("Вычитание ваших чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
            }

            else if (sign == "/")
            {
                while (two ==0)
                {
                    Console.WriteLine("Деление на 0 запрещено...");
                    Console.WriteLine("Введите другое число");
                    break;
                }
                    result = one / two;
                    Console.WriteLine("Деление ваших чисел равна " + result);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
            }
        }   
    }
}