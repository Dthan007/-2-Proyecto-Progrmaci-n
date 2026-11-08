using System.ServiceModel;
using Entities;

[ServiceContract]
public interface IVerificadorService
{
    [OperationContract]
    RespuestaServicio MantenimientoCliente(SolicitudCliente solicitud);

    [OperationContract]
    RespuestaServicio RegistrarCompra(SolicitudCompra solicitud);
}