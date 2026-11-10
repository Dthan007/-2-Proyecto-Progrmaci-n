using BLL;
using Entities;
using ServiciosEntities.Almacen;
using System;

public class WCFServicioProveedor : IWCFServicioProveedor
{
    public RespuestaServicio MantenimientoProveedor(Proveedor proveedor)
    {
        string trama =
            "PROVEEDOR|" +
            proveedor.TipoTransaccion + "|" +
            proveedor.IdJuridica + "|" +
            proveedor.NombreProveedor + "|" +
            proveedor.NombreContacto + "|" +
            proveedor.Telefono + "|" +
            proveedor.Correo + "|" +
            proveedor.Estado;
        ConexionSocket socket = new ConexionSocket("127.0.0.1", 5000);

        try
        {
            if (!socket.Conectar())
            {
                return new RespuestaServicio
                {
                    Resultado = false,
                    Mensaje = "Problemas con el Proveedor. No se pudo conectar con Almacén."
                };
            }
            string respuesta = socket.EnviarYRecibir(trama).Trim();
            if (respuesta.Equals("EXITOSO", StringComparison.OrdinalIgnoreCase))
            {
                return new RespuestaServicio
                {
                    Resultado = true,
                    Mensaje = "Exitoso"
                };
            }
            return new RespuestaServicio
            {
                Resultado = false,
                Mensaje = "Problemas con el Proveedor. " + respuesta
            };
        }
        catch (Exception ex)
        {
            return new RespuestaServicio
            {
                Resultado = false,
                Mensaje = "Problemas con el Proveedor. " + ex.Message
            };
        }
        finally
        {
            socket.Desconectar();
        }
    }
}
