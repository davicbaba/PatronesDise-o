using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Command
{
    public class SaveCommand : IComando
    {
        private ProductService _service;

        public SaveCommand(ProductService service)
        {
            _service = service;
        }

        public void Execute(Producto product)
        {
            //Llamar al receptor
            _service.Save(product);
        }
    }
}
