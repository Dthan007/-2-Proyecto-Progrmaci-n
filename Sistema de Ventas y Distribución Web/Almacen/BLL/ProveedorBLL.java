package BLL;

import DAL.ProveedorDAL;
import Entity.NuevoProveedor;
import java.sql.ResultSet;

public class ProveedorBLL
{
    private ProveedorDAL proveedorDAL = new ProveedorDAL();
    private ProveedorValidacion validacion = new ProveedorValidacion();

    public String procesoTrama(String trama)
    {
        String[] datos = trama.split("\\|", -1);

        String resultadoValidacion = validacion.validar(datos);

        if (!resultadoValidacion.equals("OK"))
        {
            return resultadoValidacion;
        }

        try
        {
            int transaccion = Integer.parseInt(datos[1]);

            NuevoProveedor proveedor = new NuevoProveedor(
                transaccion,
                datos[2],
                datos[3],
                datos[4],
                datos[5],
                datos[6],
                Integer.parseInt(datos[7])
            );

            if (transaccion == 0)
            {
                return proveedorDAL.insertarProveedor(proveedor);
            }

            if (transaccion == 1)
            {
                ResultSet resultado =
                    proveedorDAL.consultarProveedor(proveedor.getIDJuridica());

                if (resultado == null)
                {
                    return "ERROR: No se pudo consultar el proveedor";
                }

                if (!resultado.next())
                {
                    return "NO_EXISTE: El proveedor no existe";
                }

                return proveedorDAL.modificarProveedor(proveedor);
            }

            return "ERROR: Transacción no válida";
        }
        catch (NumberFormatException e)
        {
            return "ERROR: Los datos numéricos no son válidos";
        }
        catch (Exception e)
        {
            return "ERROR: " + e.getMessage();
        }
    }//procesoTrama.
}//ProveedorBLL.
