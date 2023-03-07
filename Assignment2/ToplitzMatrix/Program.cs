using System;

namespace myApp
{
    class ToplitzMatrix
    {
        static bool isToeplitzMatrix(int[,] matrix,int M,int N)
        {
            for (int i = 0; i < M - 1; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    if (matrix[i,j] != matrix[i + 1,j + 1]) return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("输入这个矩阵的行数：");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("输入这个矩阵的列数：");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[M,N];
            Console.WriteLine("输入这个矩阵的数据（按行优先输入，每个数用回车隔开）：");
            for (int i = 0; i < M; i++)
            {
                for(int j=0;j<N;j++)
                {
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //输出该矩阵
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
            bool ans = isToeplitzMatrix(matrix, M, N);
            if (ans == true) Console.WriteLine("True");
            else Console.WriteLine("False");
        }

    }
}