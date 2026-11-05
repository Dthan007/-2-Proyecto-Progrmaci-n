package BLL;

import Entity.NuevoProducto;
import DAL.ProductoDAL;

public class ProductoBLL 
{
    private ProductoDAL productoDAL = new ProductoDAL();
    private ProductoValidacion validacion = new ProductoValidacion();

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

            NuevoProducto nuevoProducto =
                new NuevoProducto(
                    transaccion,
                    datos[2],
                    datos[3],
                    Double.parseDouble(datos[4]) / 100
                );

            if (transaccion == 0)
            {
                return productoDAL.guardarProducto(nuevoProducto);
            }

            if (transaccion == 1)
            {
                return productoDAL.modificarProducto(nuevoProducto);
            }

            return "ERROR: Transacción no válida";
        }
        catch (NumberFormatException e)
        {
            return "ERROR: Los datos numéricos no son válidos";
        }
    }//procesoTrama.
}//ProductoBLL.
