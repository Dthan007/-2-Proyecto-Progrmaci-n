using System.Configuration;
using BLL;
using Entities;

public class AutenticacionService : IAutenticacionService
{
    public RespuestaAutenticacion AutenticarUsuario(SolicitudLogin solicitud)
    {
        return new AutenticacionBLL(CrearRepositorio()).AutenticarUsuario(solicitud);
    }

    public RespuestaServicio CrearUsuario(SolicitudCrearUsuario solicitud)
    {
        return new UsuarioBLL(CrearRepositorio()).CrearUsuario(solicitud);
    }

    public RespuestaServicio ModificarUsuario(DatosUsuario solicitud)
    {
        return new UsuarioBLL(CrearRepositorio()).ModificarUsuario(solicitud);
    }

    public RespuestaServicio CambiarEstadoUsuario(SolicitudCambioEstado solicitud)
    {
        return new UsuarioBLL(CrearRepositorio()).CambiarEstado(solicitud);
    }

    private UsuarioRepositorio CrearRepositorio()
    {
        var cadena = ConfigurationManager.AppSettings["MongoConexion"];
        var baseDatos = ConfigurationManager.AppSettings["MongoBaseDatos"];

        return new UsuarioRepositorio(cadena, baseDatos);
    }

    public RespuestaConsultaUsuario ObtenerUsuarioPorIdentificacion(string identificacion)
    {
        return new UsuarioBLL(CrearRepositorio())
            .ObtenerUsuarioPorIdentificacion(identificacion);
    }
}