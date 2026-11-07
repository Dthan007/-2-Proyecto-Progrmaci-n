using System;
using AlmacenServiceReference;

namespace BLL
{
    public class AlmacenServiceBLL
    {
        public RespuestaAlmacen MantenimientoProducto(
            int tipoTransaccion,
            string numeroProducto,
            string nombreProducto,
            double precio)
        {
            AlmacenServiceClient cliente = new AlmacenServiceClient();

            try
            {
                return cliente.MantenimientoProducto(
                    tipoTransaccion,
                    numeroProducto,
                    nombreProducto,
                    precio
                );
            }
            catch (Exception ex)
            {
                return new RespuestaAlmacen
                {
                    Resultado = false,
                    Mensaje = ex.ToString()
                };
            }
            finally
            {
                cliente.Close();
            }
        }
    }
}
