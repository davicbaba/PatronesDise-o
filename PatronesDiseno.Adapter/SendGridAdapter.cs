using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Adapter
{
    public class SendGridAdapter : IEmailSender
    {
        public void Send(string from, string to, string subject, string body)
        {
            Console.WriteLine("Enviando con sendgrid");
        }
    }
}
