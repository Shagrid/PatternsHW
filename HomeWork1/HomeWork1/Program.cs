using System;

namespace HomeWork1
{
    class Program
    {
        private const string ExitSymbol = "q"; 
        static void Main(string[] args)
        {
            try
            {
                if (GetNumFromConsole(out var number))
                {
                    var factorial = GetFactorial( number );
                    var sum = GetSumFrom1ToN( number );
                    var maxEvenNumber = GetMaxEvenNumber( number );
                    
                    Console.WriteLine( $"Факториал равен {factorial}");
                    Console.WriteLine( $"Сумма от 1 до N равна {sum} ");
                    Console.WriteLine( $"Максимальное четное число меньше N равно { maxEvenNumber}");
                }
            }
            catch (Exception e)
            {
               Console.WriteLine("Видимо что-то служилось. Программа закрывается \r Обратитесь к системному администратору!");
            }
            Console.ReadLine();
        }

        private static int GetMaxEvenNumber(int number)
        {
            var maxEvenNumber = 0;

            for ( var i = 1; i < number; i++ )
            {
                if ( i % 2 == 0 )
                {
                    maxEvenNumber = i;
                }
            }
            return maxEvenNumber;
        }

        private static int GetSumFrom1ToN(int number)
        {
            var sum = 0;

            for ( var i = 1; i <= number; i++ )
            {
                sum += i;
            }
            return sum;
        }

        private static int GetFactorial(int number)
        {
            var factorial = 1;
            for ( var i = 1; i <= number; i++ )
            {
                factorial *= i;
            }
            return factorial;
        }

        private static bool GetNumFromConsole(out int number)
        {
            Console.WriteLine("Здравствуйте, Вас приветствует математическая программа.");
            Console.WriteLine($"Пожалуйста, введите число. Для выхода введите {ExitSymbol}");
            var inputData = Console.ReadLine();
            while(!int.TryParse(inputData, out number))
            {
                if ( inputData == ExitSymbol )
                {
                    number = 0;
                    return false;
                }
                Console.WriteLine( $"Вы ввели неправильное значение. Пожалуйста, введите именно число. Для выхода введите {ExitSymbol}");
                inputData = Console.ReadLine();
            }
            return true;
        }
    }
}