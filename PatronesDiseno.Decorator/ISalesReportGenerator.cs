using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Decorator
{
    public interface ISalesReportGenerator 
    {
        string Generate(List<ReportItem> items);

    }
}
