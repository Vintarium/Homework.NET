using System;

namespace Homework_1
{
    public class Executor
    {

        public void Run()
        {
            bool cycleManager = true;
            Console.WriteLine("Приветствуем Вас в нашей вычислительной машинке ЭВМ-184");

            while (cycleManager)
            {
                double firstOperand;
                double secondOperand;

                try
                {
                    Console.Write("Введите первый операнд для вычисления: ");
                    firstOperand = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите второй операнд для вычисления: ");
                    secondOperand = Convert.ToDouble(Console.ReadLine());
                }

                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Вы ввели не число!");
                    continue;

                }


                Console.Write("Введите тип операции для вычисления (+ , - , *, /) : ");
                string typeOfOperation = Console.ReadLine() ?? "";


                switch (typeOfOperation)
                {
                    case "+":
                        Console.WriteLine($"Результат сложения: {Calculator.Add(firstOperand, secondOperand)}");
                        break;
                    case "-":
                        Console.WriteLine($"Результат вычитания: {Calculator.Subtract(firstOperand, secondOperand)}");
                        break;
                    case "*":
                        Console.WriteLine($"Результат умножения: {Calculator.Multiply(firstOperand, secondOperand)}");
                        break;
                    case "/":

                        try
                        {
                            Console.WriteLine($"Результат деления: {Calculator.Divide(firstOperand, secondOperand)}");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message} ");
                        }
                        break;

                    default:
                        Console.WriteLine("Указана не корректная операция!");
                        break;
                }

                Console.WriteLine("Если вы желаете продолжить работу, введите 'Y' и нажмите Enter");
                Console.WriteLine("Если не желаете просто нажмите Enter для завершения работы ЭВМ-184:");

                if (Console.ReadLine() != "Y")
                {
                    cycleManager = false;
                    Console.WriteLine("Спасибо за то что воспользовались нашей ЭВМ-184!");
                }
            }
        }
    }
}
