using Entities;
using System.ServiceModel;

[ServiceContract]
public interface IAlmacenService
{
    [OperationContract]
    RespuestaServicio MantenimientoProducto(
        int tipoTransaccion,
        string numeroProducto,
        string nombreProducto,
        double precio
    );
}
