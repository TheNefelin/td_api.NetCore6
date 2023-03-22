using Microsoft.AspNetCore.Mvc;
using td_api.NetCore6.Connection;

namespace td_api.NetCore6.Controllers
{
    [Route("f1-reportes")]
    [ApiController]
    public class F1_ReportesController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<F1_ReportesController> _logger;

        public F1_ReportesController(
            ConexionBDContext context,
            ILogger<F1_ReportesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("tabla-posiciones")]
        public async Task<IEnumerable<dynamic>> SpTablaPosiciones(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.SpTablaPosiciones(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("tabla-escuderias")]
        public async Task<IEnumerable<dynamic>> SpTablaEscuderia(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.SpTablaEscuderia(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("tabla-abandonos")]
        public async Task<IEnumerable<dynamic>> SpTablaAbandonos(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.SpTablaAbandonos(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("tabla-fallecidos")]
        public async Task<IEnumerable<dynamic>> SpTablaFallecidos(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.SpTablaFallecidos(
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
