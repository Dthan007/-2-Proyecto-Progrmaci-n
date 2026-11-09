using BLL;
using Entities;
using System;
using System.Globalization;

public class AlmacenService : IAlmacenService
{
    public RespuestaServicio MantenimientoProducto(
        int tipoTransaccion,
        string numeroProducto,
        string nombreProducto,
        double precio)
    {
        string precioFormateado = (precio * 100).ToString("00000000",
    CultureInfo.InvariantCulture);

        string trama =
            "PRODUCTO|" +
            tipoTransaccion + "|" +
            numeroProducto + "|" +
            nombreProducto + "|" +
            precioFormateado;

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

            bool exitoso = respuesta.Trim().Equals(
    "EXITOSO",
    StringComparison.OrdinalIgnoreCase);

            return new RespuestaServicio
            {
                Resultado = exitoso,
                Mensaje = exitoso
                    ? "Exitoso"
                    : "Problemas con el Producto. " + respuesta
            };
        }
        finally
        {
            socket.Desconectar();
        }
    }

}
