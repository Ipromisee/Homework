using System;

namespace myApp
{
    class ArrayOperation
    {
        static void Main(string[] args)
        {
            Console.Write("输入你所需要操作的数组的长度：");
            string str1 = Console.ReadLine();
            int n = Convert.ToInt32(str1);
            Console.WriteLine("输入你的数组(用回车隔开）：");
            int i = 0;
            int[] a=new int[100];
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            int sum = 0;
            while (i<n)
            {
                string str = Console.ReadLine();
                a[i] = Convert.ToInt32(str);
                if (a[i] >= maxNum) maxNum = a[i];
                if (a[i] <= minNum) minNum = a[i];
                sum += a[i];
                i++;
            }
            double average = sum / n;
            Console.WriteLine($"最大值为{maxNum},最小值为{minNum},平均值为{average},和为{sum}");
        }
    }
}