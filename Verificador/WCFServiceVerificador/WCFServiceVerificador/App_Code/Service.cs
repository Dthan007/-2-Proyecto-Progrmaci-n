using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class Service : IService
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
