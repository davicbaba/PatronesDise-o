using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Decorator
{
    public class DecoratorClient
    {
        public void Execute(ISalesReportGenerator generator)
        {

            List<ReportItem> items = new List<ReportItem>();

            DateTime now = DateTime.Now;

            items.Add(new ReportItem(1, "Davis", DateTime.Now, 10.00));
            items.Add(new ReportItem(2, "Pedro", DateTime.Now, 19.00));
            items.Add(new ReportItem(3, "Marcela", DateTime.Now, 29.00));
            items.Add(new ReportItem(4, "Jennifer", DateTime.Now, 39.00));

            string filePath = generator.Generate(items);

            Console.WriteLine(filePath);
        }

    }
}
