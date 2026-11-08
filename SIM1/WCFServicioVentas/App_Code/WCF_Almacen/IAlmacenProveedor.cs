using System.ServiceModel;
[ServiceContract]
public interface IAlmacenProveedor
{
    [OperationContract]
    RespuestaAlmacen MantenimientoProveedor(
        int tipoTransaccion,
        string IDjuridica,
        string nombreProveedor,
        string nombreContacto,
        string telefono,
        string correo,
        int estado
    );
}