using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Adapter
{
    public class AdapterClient
    {
        private IEmailSender _emailSender;

        public AdapterClient(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void Execute()
        {
            string from = "hola@mail.com";
            string to = "destino@mail.com";
            string subject = "Mensaje desde un adaptador";
            string body= "Vamos, vamos, vamos.";

            _emailSender.Send(from, to, subject, body);
        }

    }
}
