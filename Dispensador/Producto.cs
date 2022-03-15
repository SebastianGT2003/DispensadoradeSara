using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dispensador
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set;}
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public double Valor { get; set; }
        public double Cambio { get; set; }  
        //Si el producto se encontro se le suma la cantidad que el usuario ingrese.
        public void SumarCantidad(int cantidad)
        {
            this.Cantidad+= cantidad;
        }

        
                
            
        
        
    }
}