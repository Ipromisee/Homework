using System;

namespace myapp
{
    class AllPrimefactors
    {
        static bool judge(int n)//判断n是否为素数
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int putin;
            Console.Write("输入一个数，程序将输出其所有得素数因子：");
            putin = Convert.ToInt32(Console.ReadLine());
            if(putin <= 1)
            {
                Console.WriteLine("没有素数因子");
            }
            for (int i = 2; i <= putin; i++)
            {
                int n = i;
                while ((putin % n) == 0)
                {
                    if (judge(n)) Console.Write($"{n},");
                    putin = putin / n;
                }
            }
        }
    }
}