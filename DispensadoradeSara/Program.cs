// See https://aka.ms/new-console-template for more information
using Dispensador;
Dispensadora dispensador = new Dispensadora();
Console.WriteLine("Bienvenidos a la dispensadora de Sara");
while (true)
{


    Console.WriteLine(dispensador.ListarProducto());


    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Eliminar producto");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Producto producto = new Producto();
            Console.WriteLine("Codigo");
            producto.Codigo = Console.ReadLine();

            Console.WriteLine("Nombre");
            producto.Nombre = Console.ReadLine();

            Console.WriteLine("Categoria");
            producto.Categoria = Console.ReadLine();

            Console.WriteLine("Cantidad");
            producto.Cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor");
            producto.Valor = double.Parse(Console.ReadLine());

            dispensador.AgregarProducto(producto);

            break;
        case "2":
            Console.Write("Codigo");
            string codigo = Console.ReadLine();

            dispensador.EleminarProducto(codigo);
            break;


    }
    //Romper el ciclo infinito del while si responde "si" o seguir en el si responde "no".
    Console.WriteLine("Desea continuar si/no");

    if (Console.ReadLine() == "no")
    {
        break;
    }

}


