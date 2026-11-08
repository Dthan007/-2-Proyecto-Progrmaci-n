using System.Configuration;
using BLL;
using Entities;

public class VerificadorService : IVerificadorService
{
    public RespuestaServicio MantenimientoCliente(SolicitudCliente solicitud)
    {
        return CrearVerificador().MantenimientoCliente(solicitud);
    }

    public RespuestaServicio RegistrarCompra(SolicitudCompra solicitud)
    {
        return CrearVerificador().RegistrarCompra(solicitud);
    }

    private VerificadorBLL CrearVerificador()
    {
        var ip = ConfigurationManager.AppSettings["IpVerificador"];
        var puerto = int.Parse(ConfigurationManager.AppSettings["PuertoVerificador"]);

        return new VerificadorBLL(ip, puerto);
    }
}