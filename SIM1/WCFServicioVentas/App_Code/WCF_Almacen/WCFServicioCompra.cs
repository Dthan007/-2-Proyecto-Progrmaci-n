using BLL;
using Entities;
using ServiciosEntities.Almacen;
using System;


public class WCFServicioCompra : IWCFServicioCompra
{
    public RespuestaServicio MantenimientoCompra(Compra compra)
    {
        string trama =
            "COMPRA|" +
            compra.TipoTransaccion + "|" +
            compra.Ingreso + "|" +
            compra.Compra_ + "|" +
            compra.Juridica + "|" +
            compra.NoProducto + "|" +
            compra.Cantidad;

        ConexionSocket socket = new ConexionSocket("127.0.0.1", 5000);

        try
        {
            if (!socket.Conectar())
            {
                return new RespuestaServicio
                {
                    Resultado = false,
                    Mensaje = "Problemas con la Compra. No se pudo conectar con Almacén."
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
                Mensaje = "Problemas con la Compra. " + respuesta
            };
        }
        catch (Exception ex)
        {
            return new RespuestaServicio
            {
                Resultado = false,
                Mensaje = "Problemas con la Compra. " + ex.Message
            };
        }
        finally
        {
            socket.Desconectar();
        }
    }   
}
