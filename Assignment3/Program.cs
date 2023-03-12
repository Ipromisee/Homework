using System;

namespace Shapes
{
    //shape接口
    public interface Shape
    {
        double getArea();
        bool isLegal();
    }

    //长方形类
    class Rectangle : Shape
    {
        double Length { get; set; }
        double Width { get; set; }

        public double Area
        {
            get { return getArea(); }
        }

        public Rectangle(double l, double w)
        {
            Length = l; 
            Width = w;
        }
        public bool isLegal()
        {
            return Length > 0 && Width > 0;
        }
        public double getArea()
        {
            if (!isLegal())
            {
                Console.WriteLine("Illegal!!!返回-1.0");
                return -1.0;
            }
            return Length * Width;
        }
        
    }
    //正方形类
    class Square : Shape
    {
        double Side { get; set; }//用属性来定义

        //使用side边长来定义唯一的正方形
        public Square(double side)
        {
            Side = side;
        }
        
        public double Area
        {
            get { return getArea(); }
        }

        //判断是否合法
        public bool isLegal()
        {
            return Side > 0;
        }

        public double getArea()
        {
            if (!isLegal())
            {
                Console.WriteLine("Illegal!!!返回-1.0");
                return -1.0;
            }
            return Side * Side;
        }
    }
    

    class Triangle : Shape
    {
        double FirstSide {  get; set; }
        double SecondSide {  get; set; }
        double ThirdSide { get; set; }
        public double Area
        {
            get { return getArea(); }
        }

        public Triangle(double a, double b, double c)
        {
            FirstSide = a;
            SecondSide = b;
            ThirdSide = c;

        }
        public bool isLegal()
        {
            return FirstSide > 0 && SecondSide > 0 && ThirdSide > 0 &&
                FirstSide + SecondSide > ThirdSide && FirstSide + ThirdSide > SecondSide &&
                SecondSide + ThirdSide > FirstSide;
        }
        public double getArea()
        {
            if (!isLegal())
            {
                Console.WriteLine("Illegal!!!返回-1.0");
                return -1.0;
            }
            double p = FirstSide + SecondSide + ThirdSide;
            return System.Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
        }
    }

    
    class ShapeFactory
    {
        public static Shape getShape(int seed)
        {
            Random rd = new Random(seed);
            int key = rd.Next(0, 3);//key随机生成0-2的整数
            Shape shape = null;
            switch (key)
            {
                case 0:
                    double side = rd.Next(0, 10) + rd.NextDouble();
                    shape = new Square(side);
                    Console.WriteLine($"生成了一个边长为{side}的正方形"); 
                    break;
                case 1:
                    double FirstSide = rd.NextDouble() + rd.Next(2, 5);
                    double SecondSide = rd.NextDouble() + rd.Next(2, 5);
                    double ThirdSide = rd.NextDouble() + rd.Next(2, 5);
                    shape = new Triangle(FirstSide, SecondSide, ThirdSide);
                    Console.WriteLine($"生成了一个三边分别为{FirstSide},{SecondSide},{ThirdSide}的三角形");
                    break;
                case 2:
                    double length = rd.NextDouble() + rd.Next(0, 10);
                    double width = rd.NextDouble() + rd.Next(0, 10);
                    shape = new Rectangle(length, width);
                    Console.WriteLine($"生成了一个长为{length},宽为{width}的矩形");
                    break;
            }
            return shape;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            double totalArea = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("第" + i + "个图形：");
                Shape shape = ShapeFactory.getShape(i);
                if(shape.getArea()!=-1)
                {
                    totalArea += shape.getArea();
                    Console.WriteLine($"this area={shape.getArea()}");
                }
                else
                {
                    Console.WriteLine("这是一个不正规的图像！");
                }
            }
            Console.WriteLine($"除去不合法图形后总面积为：{totalArea}");
        }
    }
}
