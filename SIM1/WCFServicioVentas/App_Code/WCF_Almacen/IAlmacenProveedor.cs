using System.ServiceModel;
using Entities;
[ServiceContract]
public interface IAlmacenProveedor
{
    [OperationContract]
    RespuestaServicio MantenimientoProveedor(
        int tipoTransaccion,
        string IDjuridica,
        string nombreProveedor,
        string nombreContacto,
        string telefono,
        string correo,
        int estado
    );
}