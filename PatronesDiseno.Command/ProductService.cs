using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Command
{
    /// <summary>
    /// Receptor
    /// </summary>
    public class ProductService
    {
        private List<Producto> Productos { get; set; }

        public ProductService()
        {
            this.Productos = new List<Producto>();
        }

        public void Save(Producto producto)
        {
            Console.WriteLine("Guardando producto " + producto.Nombre);

            Productos.Add(producto);
        }

    }
}
