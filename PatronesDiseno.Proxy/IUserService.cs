using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace PatronesDiseno.Proxy
{
    public interface IUserService
    {

        bool Save(string userName);
    }
}
