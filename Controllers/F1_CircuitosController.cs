using Microsoft.AspNetCore.Mvc;
using td_api.NetCore6.Connection;

namespace td_api.NetCore6.Controllers
{
    [Route("f1-circuitos")]
    [ApiController]
    public class F1_CircuitosController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<F1_CircuitosController> _logger;

        public F1_CircuitosController(
            ConexionBDContext context,
            ILogger<F1_CircuitosController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> SpCircuitos(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.SpCircuitos(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<dynamic> SpCircuitosById(
            int id,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.SpCircuitosById(
                id,
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<dynamic> SpCircuitosSetById(
            int id,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.SpCircuitosSetById(
                id,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
