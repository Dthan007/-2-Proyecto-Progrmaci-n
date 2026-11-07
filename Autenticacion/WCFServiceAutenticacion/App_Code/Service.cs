using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Configuration;
using BLL;
using Entities;

public class Service : IService
{
    public RespuestaAutenticacion AutenticarUsuario(SolicitudLogin solicitud)
    {
        return CrearAutenticacion().AutenticarUsuario(solicitud);
    }

    private AutenticacionBLL CrearAutenticacion()
    {
        var cadena = ConfigurationManager.AppSettings["MongoConexion"];
        var baseDatos = ConfigurationManager.AppSettings["MongoBaseDatos"];

        return new AutenticacionBLL(new UsuarioRepositorio(cadena, baseDatos));
    }
}
