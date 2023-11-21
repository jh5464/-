using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace 队列
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            //增加
            queue.Enqueue(1);
            queue.Enqueue("123");
            queue.Enqueue(1.5f);
            //取
            object a = queue.Dequeue();
            Console.WriteLine(a);
            //查看
            object b = queue.Peek();
            Console.WriteLine(b);
            if(queue.Contains(b))
            {
                Console.WriteLine("队列存在1.5f");
            }
           
        }
       

    }
}
