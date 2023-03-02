using Microsoft.AspNetCore.Mvc;
using td_api.NetCore6.Connection;
using td_api.NetCore6.Models;

namespace td_api.NetCore6.Controllers
{
    //[ApiKeyAuth]
    [Route("td-categoria")]
    [ApiController]
    public class TD_CategoriaController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<TD_CategoriaController> _logger;

        public TD_CategoriaController(
            ConexionBDContext context,
            ILogger<TD_CategoriaController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> TDCategoriaGetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDCategoriaGetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpPost]
        [Route("")]
        public async Task<dynamic> TDCategoriaPost(
            TD_Categoria tb,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDCategoriaPost(
                tb,
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpPut]
        [Route("")]
        public async Task<dynamic> TDCategoriaPut(
            TD_Categoria tb,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDCategoriaPut(
                tb,
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<dynamic> TDCategoriaDelete(
           int id,
           CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.TDCategoriaDelete(
                id,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
