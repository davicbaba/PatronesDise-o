using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Decorator
{
    public class ReportItem
    {
        public ReportItem(int saleId, string customerName, DateTime dateTime, double ammount)
        {
            SaleId = saleId;
            CustomerName = customerName;
            DateTime = dateTime;
            Ammount = ammount;
        }

        public int SaleId { get; set; }

        public string CustomerName { get; set; }

        public DateTime DateTime { get; set; }

        public double Ammount { get; set; }

    }
}
