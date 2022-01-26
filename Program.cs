using Email_Sending_EXP.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSendingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter to Email address");
            string email, subject, body;
            email = Console.ReadLine();
            Console.WriteLine("Enter Subject");
            subject = Console.ReadLine();
            Console.WriteLine("Enter Body");
            body = Console.ReadLine();
            //Call Email sending Function
            Helper obj = new Helper();
            obj.emailgenartaion(email, subject, body);
            Console.ReadKey();
        }
    }
}
