using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Proxy
{
    /// <summary>
    /// El cliente que consume el proxy
    /// </summary>
    public class ProxyClient
    {
        private IUserService _userService;

        public ProxyClient(IUserService userService)
        {
            _userService = userService;
        }

        public void SaveUser(string userName)
        {
            //Logica de negocio .... 
            _userService.Save(userName);
            //Logica.... 

        }

    }
}
