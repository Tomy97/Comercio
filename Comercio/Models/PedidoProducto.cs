using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comercio.Models
{
    public class PedidoProducto
    {
        public int PedidoProductoID { get; set; }
        public virtual int ProductoID { get; set; }
        public virtual int PedidoID { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
    }
}
