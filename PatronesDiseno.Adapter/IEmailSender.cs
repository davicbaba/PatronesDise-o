using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Adapter
{
    /// <summary>
    /// Objetivo
    /// </summary>
    public interface IEmailSender
    {
        void Send(string from, string to, string subject, string body);

    }
}
