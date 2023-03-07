using System;

namespace myApp
{
    class ConsoleCalculator
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            string operation;
            int answer;
            Console.Write("输入第一个操作数： ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("输入第二个操作数： ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("输入操作符 ( * , / , +, -) ");
            operation = Console.ReadLine();

            if (operation == "*")
            {
                answer = firstNum * secondNum;
                Console.WriteLine(firstNum + " * " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                answer = firstNum / secondNum;
                Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "+")
            {
                answer = firstNum + secondNum;
                Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                answer = firstNum - secondNum;
                Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("格式错误");
                Console.ReadLine();
            }
        }
    }
}