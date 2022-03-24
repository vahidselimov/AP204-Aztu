using System;

namespace _24._03._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Send message by email");
            Console.WriteLine("2. Send message by sms");
            Console.WriteLine("0. Quit");
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            EmailSender send = new EmailSender();
            SmsSender Ssend = new SmsSender();

            switch (num)
            {
                case 1:
                    send.messagesender();
                    break;
                case 2:
                    Ssend.messagesender();
                    break;
                case 0:
                    Console.WriteLine("Finish...");
                    break;

                default:
                    Console.WriteLine("Zehmet olmasa gosterilen  ededlerden  birini secin...");
                    break;
            }

        }
    }
}
