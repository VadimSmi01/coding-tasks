using System;

namespace task_1_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstNumber, secondNumber;
                string deistvie;

                try
                {
                    Console.WriteLine("Введите первое число");
                    firstNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    secondNumber = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели не число, попробуйте ещё раз!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите действие: '+' '-' '*' '/' '^' 'sqrt'");
                deistvie = Console.ReadLine();

                switch (deistvie)
                {
                    case "*":
                        Console.WriteLine(firstNumber * secondNumber);
                        break;

                    case "+":
                        Console.WriteLine(firstNumber + secondNumber);
                        break;

                    case "-":
                        Console.WriteLine(firstNumber - secondNumber);
                        break;

                    case "^":
                        Console.WriteLine(Math.Pow(firstNumber, secondNumber));
                        break;

                    case "sqrt":
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Не верное математическое действие");
                        }
                        else
                        {
                            Console.WriteLine(Math.Pow(firstNumber, 1 / secondNumber));
                        }
                        break;

                    case "/":
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Не верное математическое действие");
                        }
                        else
                        {
                            Console.WriteLine(firstNumber / secondNumber);
                        }
                        break;

                    default:
                        Console.WriteLine("Ошибка, ввели не то действие");
                        break;
                }
                Console.ReadLine();









            }
        }
    }
}
