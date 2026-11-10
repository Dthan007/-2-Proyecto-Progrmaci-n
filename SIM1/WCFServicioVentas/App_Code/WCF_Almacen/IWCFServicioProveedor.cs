using Entities;
using ServiciosEntities.Almacen;
using System.ServiceModel;

[ServiceContract]
public interface IWCFServicioProveedor
{
    [OperationContract]
    RespuestaServicio MantenimientoProveedor(Proveedor proveedor);
}
