using Microsoft.AspNetCore.Mvc;
using td_api.NetCore6.Connection;
using td_api.NetCore6.Models;

namespace td_api.NetCore6.Controllers
{
    //[ApiKeyAuth]
    [Route("td-producto")]
    [ApiController]
    public class TD_ProductoController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<TD_ProductoController> _logger;

        public TD_ProductoController(
            ConexionBDContext context,
            ILogger<TD_ProductoController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> TDProductoGetAll(
             CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDProductoGetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<dynamic> TDProductoGetById(
            int id,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDProductoGetById(
                id,
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("idCategoria/{idCateg:int}")]
        public async Task<IEnumerable<dynamic>> TDProductoGetByIdCateg(
            int idCateg,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDProductoGetByIdCateg(
                idCateg,
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("idSucursal/{idSucur:int}")]
        public async Task<IEnumerable<dynamic>> TDProductoGetByIdSucur(
            int idSucur,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDProductoGetByIdSucur(
                idSucur,
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpPost]
        [Route("")]
        public async Task<dynamic> TDProductoPost(
            TD_Producto tb,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDProductoPost(
                tb,
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpPut]
        [Route("")]
        public async Task<dynamic> TDProductoPut(
            TD_Producto tb,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDProductoPut(
                tb,
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<dynamic> TDProductoDelete(
           int id,
           CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDProductoDelete(
                id,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
