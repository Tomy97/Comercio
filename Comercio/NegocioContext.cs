using Comercio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comercio
{
    public class NegocioContext: DbContext
    {

        public NegocioContext(DbContextOptions<NegocioContext> options) : base(options)
        {
        }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Mozo> Mozos { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<PedidoProducto> PedidoProducto { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
    }
}
