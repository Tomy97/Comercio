using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comercio.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public virtual int? ClienteID { get; set; }
        public virtual int? MozoID { get; set; }

        public DateTime Fecha { get; set; }
    }
}
