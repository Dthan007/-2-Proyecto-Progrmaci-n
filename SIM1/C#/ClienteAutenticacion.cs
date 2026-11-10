using System;
using System.ServiceModel;
using ServicioAutenticacion;

namespace Sistema_de_Ventas_y_Distribución
{
    public static class ClienteAutenticacion
    {
        public static RespuestaAutenticacion AutenticarUsuario(SolicitudLogin solicitud)
        {
            return Ejecutar(
                cliente => cliente.AutenticarUsuario(solicitud),
                () => new RespuestaAutenticacion
                {
                    Id = string.Empty
                }
            );
        }

        public static RespuestaServicio CrearUsuario(SolicitudCrearUsuario solicitud)
        {
            return Ejecutar(
                cliente => cliente.CrearUsuario(solicitud),
                CrearRespuestaError
            );
        }

        public static RespuestaServicio ModificarUsuario(DatosUsuario solicitud)
        {
            return Ejecutar(
                cliente => cliente.ModificarUsuario(solicitud),
                CrearRespuestaError
            );
        }

        public static RespuestaServicio CambiarEstadoUsuario(SolicitudCambioEstado solicitud)
        {
            return Ejecutar(
                cliente => cliente.CambiarEstadoUsuario(solicitud),
                CrearRespuestaError
            );
        }

        private static T Ejecutar<T>(
            Func<AutenticacionServiceClient, T> operacion,
            Func<T> respuestaError)
        {
            var cliente = new AutenticacionServiceClient();

            try
            {
                var respuesta = operacion(cliente);

                cliente.Close();

                return respuesta;
            }
            catch (Exception ex) when (
                ex is CommunicationException ||
                ex is TimeoutException)
            {
                cliente.Abort();

                return respuestaError();
            }
        }

        private static RespuestaServicio CrearRespuestaError()
        {
            return new RespuestaServicio
            {
                Resultado = false,
                Mensaje = "No se pudo comunicar con el servicio de autenticación. Verifique que esté en ejecución."
            };
        }
    }
}