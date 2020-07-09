using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PatronesDiseno.Decorator
{
    /// <summary>
    /// Componente concreto
    /// </summary>
    public class CsvReportGenerator : ISalesReportGenerator
    {
        public string Generate(List<ReportItem> items)
        {
            FileStream file = File.Create($"Reporte {Guid.NewGuid()}.csv");

          
            using (StreamWriter sr = new StreamWriter(file))
            {
                foreach (var item in items)
                {
                    sr.WriteLine($"{item.SaleId},{item.CustomerName},{item.DateTime},{item.Ammount}");

                }

            }

            return file.Name;

        }
    }
}
