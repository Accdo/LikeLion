using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    class Program
    {
        delegate void MessageHandler(string message);

        static void DisplayMessage(string message)
        {
            Console.WriteLine($"메세지 : {message}");
        }

        static void DisplayUpperMessage(string message)
        {
            Console.WriteLine($"메세지 : {message.ToUpper()}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("델리게이트1");

            MessageHandler messageHandler = DisplayMessage;
            messageHandler("안녕하세요");
            //
            Console.WriteLine("여러 메서드 호출 : ");

            messageHandler += DisplayUpperMessage;
            messageHandler("Hello");
        }
    }
}
