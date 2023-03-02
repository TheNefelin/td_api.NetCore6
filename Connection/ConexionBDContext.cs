using Dapper;
using System.Data;
using System.Data.SqlClient;
using td_api.NetCore6.Models;

namespace td_api.NetCore6.Connection
{
    public class ConexionBDContext
    {
        private readonly string _RutaDeConexion;

        public ConexionBDContext(String RutaDeConexion)
        {
            _RutaDeConexion = RutaDeConexion;
        }

        public IDbConnection CreateConnection() => new SqlConnection(_RutaDeConexion);

        //-- Talento Digital - Sucursales ---------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> TDSucursalGetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Sucursal_GetAll",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> TDSucursalPost(
            TD_Sucursal tb,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Sucursal_Post @{nameof(tb.Id)}, @{nameof(tb.Nombre)}",
                    new { tb.Id, tb.Nombre },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> TDSucursalPut(
            TD_Sucursal tb,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Sucursal_Put @{nameof(tb.Id)}, @{nameof(tb.Nombre)}",
                    new { tb.Id, tb.Nombre },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Talento Digital - Categorias ---------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> TDCategoriaGetAll(
          IDbConnection conexion,
          IDbTransaction? transaccion,
          CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Categoria_GetAll",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> TDCategoriaPost(
            TD_Categoria tb,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Categoria_Post @{nameof(tb.Id)}, @{nameof(tb.Nombre)}",
                    new { tb.Id, tb.Nombre },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> TDCategoriaPut(
            TD_Categoria tb,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Categoria_Put @{nameof(tb.Id)}, @{nameof(tb.Nombre)}",
                    new { tb.Id, tb.Nombre },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> TDCategoriaDelete(
            int id,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Categoria_Delete @{nameof(id)}",
                    new { id },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Talento Digital - Producto -----------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> TDProductoGetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Producto_GetAll",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> TDProductoGetById(
            int id,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Producto_GetById @{nameof(id)}",
                    new { id },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<IEnumerable<dynamic>> TDProductoGetByIdCateg(
            int idCateg,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Producto_GetByIdCateg @{nameof(idCateg)}",
                    new { idCateg },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<IEnumerable<dynamic>> TDProductoGetByIdSucur(
            int idSucur,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Producto_GetByIdSucur @{nameof(idSucur)}",
                    new { idSucur },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> TDProductoPost(
            TD_Producto tb,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Producto_Post @{nameof(tb.Id)}, @{nameof(tb.Nombre)}, @{nameof(tb.Precio)}, @{nameof(tb.Link)}, @{nameof(tb.Stock)}, @{nameof(tb.Etiqueta)}, @{nameof(tb.Descripcion)}, @{nameof(tb.IdCategoria)}, @{nameof(tb.IdSucursal)}",
                    new { tb.Id, tb.Nombre, tb.Precio, tb.Link, tb.Stock, tb.Etiqueta, tb.Descripcion, tb.IdCategoria, tb.IdSucursal },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> TDProductoPut(
            TD_Producto tb,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Producto_Put @{nameof(tb.Id)}, @{nameof(tb.Nombre)}, @{nameof(tb.Precio)}, @{nameof(tb.Link)}, @{nameof(tb.Stock)}, @{nameof(tb.Etiqueta)}, @{nameof(tb.Descripcion)}, @{nameof(tb.IdCategoria)}, @{nameof(tb.IdSucursal)}",
                    new { tb.Id, tb.Nombre, tb.Precio, tb.Link, tb.Stock, tb.Etiqueta, tb.Descripcion, tb.IdCategoria, tb.IdSucursal },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> TDProductoDelete(
            int id,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Producto_Delete @{nameof(id)}",
                    new { id },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Talento Digital - Truncate -----------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<dynamic> TDCategoriaTruncate(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Categoria_Truncate",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> TDProductoTruncate(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Producto_Truncate",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> TDSucuProdTruncate(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Sucu_Prod_Truncate",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> TDSucursalTruncate(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"td_Sucursal_Truncate",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }
        //-----------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------

    }
}
