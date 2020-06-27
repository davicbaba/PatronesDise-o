using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.Command
{
    public interface IComando
    {
        void Execute(Producto product);

    }
}
