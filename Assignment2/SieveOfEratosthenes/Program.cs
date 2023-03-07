using System;

namespace myApp
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int[] record = new int[101];//用来记录是否为素数。为0代表是素数，1代表不是素数
            record[0] = record[1] = 1;//0、1不是素数
            //外层循环表示是i的倍数，只需要循环到i*i<=100
            for (int i = 2; i * i <= 100; i++)
            {
                //如果i是素数，则将i*i开始的所有i的倍数去掉
                if (record[i] == 0)
                {
                    for (int j = i * i; j <= 100; j += i)
                    {
                        record[j] = 1;
                    }
                }
            }
            for(int i=2;i<=100;i++)
            {
                if (record[i]==0)
                {
                    Console.Write($"{i},");
                }
            }
        }
    }
}