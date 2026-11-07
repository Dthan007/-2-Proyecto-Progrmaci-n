using System.ServiceModel;

[ServiceContract]
public interface IAlmacenService
{
    [OperationContract]
    RespuestaAlmacen MantenimientoProducto(
        int tipoTransaccion,
        string numeroProducto,
        string nombreProducto,
        double precio
    );

}
