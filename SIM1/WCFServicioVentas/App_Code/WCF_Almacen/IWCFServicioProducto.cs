using Entities;
using ServiciosEntities.Almacen;
using System.ServiceModel;

[ServiceContract]
public interface IWCFServicioProducto
{
    [OperationContract]
    RespuestaServicio MantenimientoProducto(Producto producto);
}
