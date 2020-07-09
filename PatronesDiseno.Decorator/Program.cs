using System;

namespace PatronesDiseno.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ISalesReportGenerator reportGenerator = new CsvReportGenerator();

            ISalesReportGenerator obfuscatorReportGenerator = new ObfuscatorReportGenerator(reportGenerator);

            DecoratorClient client = new DecoratorClient();
            client.Execute(reportGenerator);
            client.Execute(obfuscatorReportGenerator);

            Console.ReadLine();

        }
    }
}
