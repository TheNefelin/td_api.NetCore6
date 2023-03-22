using Microsoft.AspNetCore.Mvc;
using td_api.NetCore6.Connection;

namespace td_api.NetCore6.Controllers
{
    [Route("f1-pilotos")]
    [ApiController]
    public class F1_PilotosController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<F1_PilotosController> _logger;

        public F1_PilotosController(
            ConexionBDContext context,
            ILogger<F1_PilotosController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> SpPilotos(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.SpPilotos(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("vivos")]
        public async Task<IEnumerable<dynamic>> SpPilotosActivos(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.SpPilotosActivos(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<dynamic> SpPilotosSetById(
            int id,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.SpPilotosSetById(
                id,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
