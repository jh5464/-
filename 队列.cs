using System;
using System.Collections.Generic;

public class Queue<T>
{
    private LinkedList<T> items;

    public Queue()
    {
        items = new LinkedList<T>();
    }

    public void Enqueue(T item)
    {
        items.AddLast(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T item = items.First.Value;
        items.RemoveFirst();
        return item;
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return items.First.Value;
    }

}
public class Program()
{
    public static void Main(string[] args)
    {

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine(queue.Peek());    // 输出：10

        int item1 = queue.Dequeue();
        Console.WriteLine(item1);           // 输出：10

        int item2 = queue.Dequeue();
        Console.WriteLine(item2);           // 输出：20

        Console.WriteLine(queue.IsEmpty()); // 输出：false

        int item3 = queue.Dequeue();
        Console.WriteLine(item3);           // 输出：30

        Console.WriteLine(queue.IsEmpty()); // 输出：true



    }



}
