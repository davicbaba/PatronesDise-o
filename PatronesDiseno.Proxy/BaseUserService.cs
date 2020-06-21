using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Proxy
{
    /// <summary>
    /// servicio que contiene la logica de negocios para guardar un usuario.
    /// </summary>
    public class BaseUserService:  IUserService
    {
        private readonly List<string> _users;

        public BaseUserService()
        {
            _users = new List<string>();
        }

        public bool Save(string userName)
        {
            if (_users.Contains(userName) == false)
            {
                _users.Add(userName);
                return true;
            }

            return false;
        }
    }
}
