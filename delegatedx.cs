namespace Mytool
{
    public delegate void MyDel();
    public class Publisher
        {
            public MyDel? Onsomethinghappend;
            public void Dosomething()
            {
                Console.WriteLine("发布者做了一些事情");
                Onsomethinghappend?.Invoke();
            }
        }



    public class Subscriber
    {
        Todosomething Todo = new Todosomething();
        public void reaction()
        {
            Console.WriteLine("已收到发布者的通知，开始做出反应");
            Todo.ContorlTheNext();
            Console.WriteLine("已完成反应");
        }

    }

    public class Todosomething
    {
        public void ContorlTheNext()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine($"事件已完成，我将推导出结果为: {c}");
        }

    }
    
}