using System;

namespace PatronesDiseno.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto real
            IUserService userService = new BaseUserService();

            //Proxy
            IUserService loggerProxy = new UserServiceLogger(userService);

            ProxyClient client = new ProxyClient(loggerProxy);

            client.SaveUser("dcruz@test.com");
            client.SaveUser("patri@test.com");
            client.SaveUser("dcruz@test.com");

            Console.ReadLine();
        }
    }
}
