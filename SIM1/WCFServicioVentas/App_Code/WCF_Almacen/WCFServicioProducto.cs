using BLL;
using Entities;
using ServiciosEntities.Almacen;
using System;
using System.Globalization;  //CultureInfo.InvariantCulture

public class WCFServicioProducto : IWCFServicioProducto
    {
        public RespuestaServicio MantenimientoProducto(Producto producto)
        {
            string precio = (producto.Precio * 100).ToString(
                "00000000",
                CultureInfo.InvariantCulture
            );

            string trama =
                "PRODUCTO|" +
                producto.TipoTransaccion + "|" +
                producto.NumeroProducto + "|" +
                producto.NombreProducto + "|" +
                precio;

            ConexionSocket socket = new ConexionSocket("127.0.0.1", 5000);

            try
            {
                if (!socket.Conectar())
                {
                    return new RespuestaServicio
                    {
                        Resultado = false,
                        Mensaje = "Problemas con el Producto. No se pudo conectar con Almacén."
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
                    Mensaje = "Problemas con el Producto. " + respuesta
                };
            }
            catch (Exception ex)
            {
                return new RespuestaServicio
                {
                    Resultado = false,
                    Mensaje = "Problemas con el Producto. " + ex.Message
                };
            }
            finally
            {
                socket.Desconectar();
            }
        }
    }
