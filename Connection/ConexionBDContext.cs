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
        //-- F1 Reset -----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<dynamic> SpReset(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"sp_reset",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }
        //-- F1 Circuitos -------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> SpCircuitos(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"sp_circuitos",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> SpCircuitosById(
            int @id,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"sp_circuitosById @{nameof(id)}",
                    new { id },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> SpCircuitosSetById(
            int @id,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"sp_circuitosSetById @{nameof(id)}",
                    new { id },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }
        //-- F1 Pilotos ---------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> SpPilotos(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"sp_pilotos",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<IEnumerable<dynamic>> SpPilotosActivos(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"sp_pilotosActivos",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }
        public async Task<dynamic> SpPilotosSetById(
            int @id,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"sp_pilotosSetById @{nameof(id)}",
                    new { id },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }
        //-- F1 Carrera ---------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> SpCarrera(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"sp_carrera",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> SpCarreraSet(
            F1_Carrera tb,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"sp_carreraSet @{nameof(tb.IdCircuito)}, @{nameof(tb.IdPiloto)}, @{nameof(tb.Distancia)}, @{nameof(tb.Puntaje)}, @{nameof(tb.Lugar)}, @{nameof(tb.CarreraTerminada)}, @{nameof(tb.Incidente)}, @{nameof(tb.Motivo)}",
                    new { tb.IdCircuito, tb.IdPiloto, tb.Distancia, tb.Puntaje, tb.Lugar, tb.CarreraTerminada, tb.Incidente, tb.Motivo },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }
        //---F1 Reportes --------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> SpTablaPosiciones(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"sp_tabla_posiciones",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<IEnumerable<dynamic>> SpTablaEscuderia(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"sp_tabla_escuderia",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<IEnumerable<dynamic>> SpTablaAbandonos(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"sp_tabla_abandonos",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<IEnumerable<dynamic>> SpTablaFallecidos(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"sp_tabla_fallecidos",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }
        //-----------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
    }
}
