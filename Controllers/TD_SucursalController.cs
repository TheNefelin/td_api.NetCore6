using Microsoft.AspNetCore.Mvc;
using td_api.NetCore6.Connection;
using td_api.NetCore6.Models;

namespace td_api.NetCore6.Controllers
{
    //[ApiKeyAuth]
    [Route("td-sucursal")]
    [ApiController]
    public class TD_SucursalController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<TD_SucursalController> _logger;

        public TD_SucursalController(
            ConexionBDContext context,
            ILogger<TD_SucursalController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> TDSucursalGetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDSucursalGetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpPost]
        [Route("")]
        public async Task<dynamic> TDSucursalPost(
            TD_Sucursal tb,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDSucursalPost(
                tb,
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpPut]
        [Route("")]
        public async Task<dynamic> TDSucursalPut(
            TD_Sucursal tb,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDSucursalPut(
                tb,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
