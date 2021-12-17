using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int Codigo { get; set; }
        public int IdTipoProducto { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public Boolean Estado { get; set; }
        public string DescripcionPlato { get; set; }
    }

}
