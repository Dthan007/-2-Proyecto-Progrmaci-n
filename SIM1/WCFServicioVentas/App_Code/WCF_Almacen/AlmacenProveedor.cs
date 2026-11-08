using BLL;
using Entities;
using System;
using System.Globalization;

public class AlmacenProveedor : IAlmacenProveedor
{
    

    public RespuestaServicio MantenimientoProveedor(
        int tipoTransaccion,
        string IDjuridica,
        string nombreProveedor,
        string nombreContacto,
        string telefono,
        string correo,
        int estado)
    {
        string trama =
            "PROVEEDOR|" +
            tipoTransaccion + "|" +
            IDjuridica + "|" +
            nombreProveedor + "|" +
            nombreContacto + "|" +
            telefono + "|" +
            correo + "|" +
            estado;

        ConexionSocket socket = new ConexionSocket("127.0.0.1", 5000);
        if (!socket.Conectar())
        {
            return new RespuestaServicio
            {
                Resultado = false,
                Mensaje = "No se pudo conectar con Almacén."
            };
        }
        try 
        {
            string respuesta = socket.EnviarYRecibir(trama);
            bool exitoso = respuesta.Trim().Equals("EXITOSO",
                StringComparison.OrdinalIgnoreCase);

            return new RespuestaServicio
            {
                Resultado = exitoso,
                Mensaje = exitoso
                    ? "Exitoso"
                    : "Problemas con el Proveedor. " + respuesta
            };
        }
        finally 
        {
            socket.Desconectar();
        }
    }
}