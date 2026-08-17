namespace plactics_01
{
public class say_hello
{
    public static void Dosomething(string message)
    {
        Console.WriteLine(message);
    }
}

}


namespace plactics_02
{
    public interface ImessageSender
    {
        void Send(string msg);
    }



    public class QQMailSender : ImessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"QQ发送: {message}");
        }
    }

    public class NetEaseMailSender : ImessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"网易发送：{message}");
        }
    }


    public class NoticeService
    {
        private ImessageSender _sender;

        public NoticeService(ImessageSender sender)
        {
            _sender = sender;
        }


    public void notify()
        {
            _sender.Send("今晚加班");
        }
    }
}