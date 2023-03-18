using System;
using System.Security.Cryptography.X509Certificates;

//链表节点
public class Node<T>
{
    public Node<T> Next { get; set; }
    public T Data { get; set; }

    public Node(T t)
    {
        Next = null;
        Data = t;
    }
}
// 泛型链表类
public class GenericList<T>
{
    private Node<T> head;
    private Node<T> tail;

    public GenericList()
    {
        head = tail = null;
    }

    public Node<T> Head { get => head; }

    public void Add(T t)
    {
        Node<T> n = new Node<T>(t);
        if (tail == null)
        {
            head = tail = n;
        }
        else
        {
            tail.Next = n;
            tail = n;
        }
    }

    public void ForEach(Action<T> action)
    {
        for(Node<T> cur = head; cur!=tail; cur=cur.Next)
        {
            action(cur.Data);
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        int sum = 0, min = int.MaxValue, max = int.MinValue;
        GenericList <int> intList= new GenericList<int>();
        int[] a = { 1, 2, 3, 4, 5 };
        //根据数组a创建一个链表
        for(int i = 0; i < a.Length; i++) { intList.Add(a[i]); }
        // 用lambda表达式，=>前面的是形参
        intList.ForEach(data => Console.Write(data+" "));//输出所有元素
        intList.ForEach(data => max = Math.Max(max, data));//找到最大值
        intList.ForEach(data => min = Math.Min(min, data));//找到最小值
        intList.ForEach(data => sum += data);//求和
        Console.WriteLine();
        Console.WriteLine($"最大值：{max},最小值：{min},和：{sum}");
    }
}
