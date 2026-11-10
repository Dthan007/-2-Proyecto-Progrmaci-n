using System.ServiceModel;
using Entities;

[ServiceContract]
public interface IAutenticacionService
{
    [OperationContract]
    RespuestaAutenticacion AutenticarUsuario(SolicitudLogin solicitud); //Iniciar sesión.

    [OperationContract]
    RespuestaServicio CrearUsuario(SolicitudCrearUsuario solicitud); //Registrar un usuario.

    [OperationContract]
    RespuestaServicio ModificarUsuario(DatosUsuario solicitud); //Modificar los datos de un usuario.

    [OperationContract]
    RespuestaServicio CambiarEstadoUsuario(SolicitudCambioEstado solicitud); //Activar o desactivar una cuenta.

    [OperationContract]
    RespuestaConsultaUsuario ObtenerUsuarioPorIdentificacion(string identificacion);
}