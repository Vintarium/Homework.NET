using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace Homework_1
{
    public class Executor
    {
        public void Run()
        {
            Console.WriteLine("Приветствуем Вас в нашей вычислительной машинке ЭВМ-184");
            Console.WriteLine();

            while (true)
            {
                double firstOperand;
                double secondOperand;
                string typeOfOperation;

                Console.Write("Введите первое число для вычисления: ");
                firstOperand = GetNumberFromUser();

                Console.Write("Введите второе число для вычисления: ");
                secondOperand = GetNumberFromUser();

                typeOfOperation = GetOperationFromUser();
                try
                {
                    switch (typeOfOperation)
                    {
                        case "+":
                            Console.WriteLine($"Результат сложения: {Calculator.Add(firstOperand, secondOperand)}");
                            Console.WriteLine();
                            break;
                        case "-":
                            Console.WriteLine($"Результат вычитания: {Calculator.Subtract(firstOperand, secondOperand)}");
                            Console.WriteLine();
                            break;
                        case "*":
                            Console.WriteLine($"Результат умножения: {Calculator.Multiply(firstOperand, secondOperand)}");
                            Console.WriteLine();
                            break;
                        case "/":
                            Console.WriteLine($"Результат деления: {Calculator.Divide(firstOperand, secondOperand)}");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Ошибка: Деление на 0  {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                }
                Console.WriteLine("Если вы желаете продолжить работу, введите 'Y' и нажмите Enter");
                Console.WriteLine("Если не желаете просто нажмите Enter для завершения работы ЭВМ-184:");

                if (Console.ReadLine()?.ToLower() != "y")
                {
                    Console.WriteLine("Спасибо за то что воспользовались нашей ЭВМ-184!");
                    break;
                }
            }
        }
        public double GetNumberFromUser()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (double.TryParse(input, out double number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Ошибка! Вы ввели не число!");
                    Console.Write("Попробуйте еще раз: ");
                }
            }
        }
        public string GetOperationFromUser()
        {
            string[] operations = { "+", "-", "*", "/" };

            Console.Write("Введите тип операции для вычисления (+ , - , *, /) : ");

            while (true)
            {
                var input = Console.ReadLine();

                if (input != null && operations.Contains(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Введена не верная операция!");
                    Console.Write("Попробуйте еще раз: ");
                }
            }
        }
    }
}

