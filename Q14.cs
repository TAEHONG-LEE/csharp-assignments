using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Notification
    {
        public abstract void Send();
    }

    class Email : Notification
    {
        public override void Send()
        {
            Console.WriteLine("이메일 전송");
        }
    }
    class SMS : Notification
    {
        public override void Send()
        {
            Console.WriteLine("문자 발송");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notification email = new Email();
            Notification sms = new SMS();
            email.Send();
            sms.Send();

        }
    }
}
