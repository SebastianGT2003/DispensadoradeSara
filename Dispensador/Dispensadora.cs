using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispensador
{
    public class Dispensadora
    {
        // Se crea una lista que va a contener obejtos tipo producto.
        public List<Producto> Productos { get; set; }
        public string Pago { get; set; }
        public Dispensadora()
        {
            this.Productos = new List<Producto>();  
            //Aqui se crean unos productos por defecto para que siempre aparezcan en el dispensador.

            Producto Cocacola = new Producto();
            Cocacola.Codigo = "01";
            Cocacola.Nombre = "Coca Cola";
            Cocacola.Valor = 3000;
            Cocacola.Categoria = "B";
            Cocacola.Cantidad = 3;

            Producto Solterita = new Producto();
            Solterita.Codigo = "02";
            Solterita.Nombre = "Solterita";
            Solterita.Valor = 2000;
            Solterita.Categoria = "C";
            Solterita.Cantidad = 5;



            Producto Papas = new Producto();
            Papas.Codigo = "03";
            Papas.Valor = 2000;
            Papas.Nombre = "Papas Margaritas";
            Papas.Categoria = "C";
            Papas.Cantidad = 10;

            this.Productos.Add(Cocacola);
            this.Productos.Add(Solterita);
            this.Productos.Add(Papas);
            


        }
        // Valida si existe el producto en la lista.
        public int ValidaProducto(string codigo)
        {
            int encontro = -1;

            for (int i = 0;i<this.Productos.Count;i++)
            {
                if (this.Productos[i].Codigo == codigo)
                {
                    encontro = i;
                }
            }
            return encontro;
        }
        public bool AgregarProducto(Producto producto)
        {
            int enc= this.ValidaProducto(producto.Codigo);
            if (enc>=0)
            {
                this.Productos[enc].SumarCantidad(producto.Cantidad);
            }
            else
            {
                this.Productos.Add(producto);
            }
            return true;
        }
        public bool EleminarProducto(string codigo)
        {
            int enc = this.ValidaProducto(codigo);
            if (enc >= 0) 
            {
                this.Productos.RemoveAt(enc);
                return true;
            }
            return false;
  
        }
        // Este metodo sirve para mostar los productos con sus atributos en la consola.
        public string ListarProducto() 
        {
            string lista = "";
            foreach(Producto item in this.Productos)
            {
                lista += item.Codigo + " " + item.Nombre + " Categoria " + item.Categoria + " Cantidad " + item.Cantidad + " Costo unidad " + item.Valor + "\n";
            }
            return lista;
        }

    }
}
