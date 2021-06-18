using Comercio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Comercio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoProductoController : ControllerBase
    {
        private readonly NegocioContext _context;
        public PedidoProductoController(NegocioContext context)
        {
            _context = context;
        }
        // GET: api/<PedidoProductoController>
        [HttpGet]
        public List<PedidoProducto> Get()
        {
            var pedidos = _context.PedidoProducto.ToList();
            return pedidos;

        }
        // GET api/<PedidoProductoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PedidoProductoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PedidoProductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PedidoProductoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
