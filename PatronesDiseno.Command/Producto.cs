using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Command
{
    public class Producto
    {
        public Producto(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        private string Id { get; set; }


        public string Nombre { get; set; }

    }
}
