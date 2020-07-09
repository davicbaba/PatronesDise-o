using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Decorator
{
    /// <summary>
    /// decorador concreto
    /// </summary>
    public class ObfuscatorReportGenerator : ReportDecorator
    {
        public ObfuscatorReportGenerator(ISalesReportGenerator salesReportGenerator) : base(salesReportGenerator)
        {
        }

        public override string Generate(List<ReportItem> items)
        {
            List<ReportItem> newReports = new List<ReportItem>();

            foreach(var item in items)
            {
                ReportItem reportItem = new ReportItem(item.SaleId, ObfuscateName(), item.DateTime, item.Ammount);

                newReports.Add(reportItem);
            }

            ISalesReportGenerator generator = GetTargetGenerator();

            return generator.Generate(newReports);
        }


        public string ObfuscateName()
        {
            string name = "No disponible";

            return name;
        }
    }
}
