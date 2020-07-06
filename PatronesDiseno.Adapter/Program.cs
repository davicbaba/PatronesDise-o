using System;

namespace PatronesDiseno.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmailSender emailSender = new SparkPostAdapter();

            AdapterClient adapterClient = new AdapterClient(emailSender);
            
            adapterClient.Execute();


            IEmailSender emailSender2 = new SendGridAdapter();

            AdapterClient adapterClient2 = new AdapterClient(emailSender2);

            adapterClient2.Execute();

            Console.ReadKey();
        }
    }
}
