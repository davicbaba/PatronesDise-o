using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Command
{
    /// <summary>
    /// Este es un invocador
    /// </summary>
    public class Grid
    {
        private List<Producto> Productos;

        private IComando _comando;

        public Grid(IComando comando)
        {
            _comando = comando;

            Productos = new List<Producto>();

            Productos.Add(new Producto("101", "Mesa vintage"));
            Productos.Add(new Producto("102", "Silla chic"));
            Productos.Add(new Producto("103", "Lampara clasica"));
        }

        public void Update()
        {
            Console.WriteLine("Desde el metodo Update de la grilla");

            foreach(var producto in Productos)
            {
                _comando.Execute(producto);
            }
        }

    }
}
