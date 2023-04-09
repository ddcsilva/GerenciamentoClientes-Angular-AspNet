using GerenciamentoClientes.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoClientes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private static List<Cliente> _clientes = new List<Cliente>();

        [HttpGet]
        public IActionResult ObterClientes()
        {
            return Ok(_clientes);
        }

        [HttpPost]
        public IActionResult AdicionarCliente([FromBody] Cliente cliente)
        {
            _clientes.Add(cliente);
            return Ok();
        }
    }
}
