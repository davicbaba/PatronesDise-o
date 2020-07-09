using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Decorator
{
    /// <summary>
    /// Decorador
    /// </summary>
    public abstract class ReportDecorator : ISalesReportGenerator
    {
        private ISalesReportGenerator _salesReportGenerator;

        public ReportDecorator(ISalesReportGenerator salesReportGenerator)
        {
            _salesReportGenerator = salesReportGenerator;
        }

        public abstract string Generate(List<ReportItem> items);

        public ISalesReportGenerator GetTargetGenerator()
        {
            return _salesReportGenerator;
        }
       
    }
}
