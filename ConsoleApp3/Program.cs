namespace calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float one, two, result;
            char sign;
            Console.WriteLine("Введите первое число, а затем знак действия (только +)");
            Console.Write("Первое число - ");
            while (Single.TryParse(Console.ReadLine(), out one) == false)
            {
                Console.WriteLine("Введите корректное значение");
                Console.Write("Первое число - ");
            }
            Console.Write("Введите знак действия : ");
            sign = Convert.ToChar(Console.ReadLine());
            Console.Write("Второе число - ");
            two = Convert.ToSingle(Console.ReadLine());
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
            }
        }
    }
}