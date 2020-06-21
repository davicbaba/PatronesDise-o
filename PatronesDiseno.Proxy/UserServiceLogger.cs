using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Proxy
{
    /// <summary>
    /// Proxy para guardar un usuario dejando logs de las operaciones.
    /// </summary>
    public class UserServiceLogger : IUserService
    {
        private IUserService _userService;

        public UserServiceLogger(IUserService userService)
        {
            _userService = userService;
        }

        public bool Save(string userName)
        {
            //Se podria usar serilog o log4net si quisieramos escribir el log a un archivo de texto, pero para ejemplo sirve escribirlo en consola.
            Console.WriteLine("Antes de guardar el usuario" + userName);

            bool result = _userService.Save(userName);

            if(result)
                Console.WriteLine("usuario guardado: " + userName);
            else
                Console.WriteLine("usuario No guardado: " + userName);

            return result;

        }
    }
}
