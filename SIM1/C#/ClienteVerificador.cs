using System.ServiceModel;
using BLL;
using ServicioVerificador;

namespace Sistema_de_Ventas_y_Distribución
{
    public static class ClienteVerificador
    {
        private const string Direccion = "http://localhost:50893/VerificadorService.svc";

        public static RespuestaServicio MantenimientoCliente(SolicitudCliente solicitud)
        {
            return Ejecutar(cliente => cliente.MantenimientoCliente(solicitud));
        }

        public static RespuestaServicio RegistrarCompra(SolicitudCompra solicitud)
        {
            return Ejecutar(cliente => cliente.RegistrarCompra(solicitud));
        }

        private static RespuestaServicio Ejecutar(Func<VerificadorServiceClient, RespuestaServicio> operacion)
        {
            var cliente = new VerificadorServiceClient(VerificadorServiceClient.EndpointConfiguration.BasicHttpBinding_IVerificadorService, Direccion);

            try
            {
                var respuesta = operacion(cliente);
                cliente.Close();
                return respuesta;
            }
            catch (Exception ex) when (ex is CommunicationException || ex is TimeoutException)
            {
                cliente.Abort();
                Consola.Error("No se pudo comunicar con el servicio del verificador", ex);

                return new RespuestaServicio
                {
                    Resultado = false,
                    Mensaje = "No se pudo comunicar con el servicio. Verifique que este en ejecucion"
                };
            }
        }
    }
}