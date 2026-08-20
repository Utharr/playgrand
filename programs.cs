// See https://aka.ms/new-console-template for more information
using plactics_01;
using plactics_02;
using Mytool;

//策略模式的使用
say_hello.Dosomething("hello world! beautiful world!");


//
ImessageSender sender = new QQMailSender();
ImessageSender sender2 = new NetEaseMailSender();

NoticeService service = new NoticeService(sender);
NoticeService service2 = new NoticeService(sender2);

service.notify();
service2.notify();

//委托的使用
Publisher pub = new Publisher();
Subscriber sub = new Subscriber();

pub.Onsomethinghappend += sub.reaction;

pub.Dosomething();