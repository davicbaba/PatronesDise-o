using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Command
{
    /// <summary>
    /// Este es un invocador
    /// </summary>
    public class Form
    {
        private IComando _command;

        public Form(IComando command)
        {
            _command = command;
        }

        public void Save()
        {
            Console.WriteLine("Desde el metodo save del formulario");

            Producto producto = GetProduct();

            _command.Execute(producto);
        }

        private Producto GetProduct()
        {
            int id = new Random().Next(0, 1000);

            return new Producto("1", $"Martillo de id: {id}");
        }
    }
}
