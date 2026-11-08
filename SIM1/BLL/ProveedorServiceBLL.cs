using ProveedorServiceReference; 
namespace BLL
{
    public class ProveedorServiceBLL
    {
        public RespuestaAlmacen MantenimientoProveedores(
            int tipoTransaccion,
            string idJuridica,
            string nombreproveedor,
            string nombreContacto,
            string telefono,
            string correo,
            int estado)
        {
            AlmacenProveedorClient cliente = new AlmacenProveedorClient();
            
            try
            {
                return cliente.MantenimientoProveedor(
                    tipoTransaccion,
                    idJuridica,
                    nombreproveedor,
                    nombreContacto,
                    telefono,
                    correo,
                    estado
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
