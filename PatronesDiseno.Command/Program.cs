using System;

namespace PatronesDiseno.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();

            IComando comando = new SaveCommand(productService);

            Form form = new Form(comando);

            Grid grid = new Grid(comando);
            
            form.Save();
            grid.Update();

            Console.ReadLine();
        }
    }
}
