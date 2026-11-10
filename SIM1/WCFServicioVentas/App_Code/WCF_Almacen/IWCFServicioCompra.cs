using Entities;
using ServiciosEntities.Almacen;
using System.ServiceModel;

[ServiceContract]
public interface IWCFServicioCompra
{
    [OperationContract]
    RespuestaServicio MantenimientoCompra(Compra compra);
}
