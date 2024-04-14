namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float one, two, result;
            char sign;
            Console.WriteLine("Введите первое число, а затем знак действия (только +)");
            Console.Write("Первое число - ");
            one = Convert.ToSingle(Console.ReadLine());
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
            

        }

    }
}