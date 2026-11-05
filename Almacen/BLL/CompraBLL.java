package BLL;

import DAL.CompraDAL;
import Entity.NuevaCompra;
import Entity.DetalleCompra;

import java.util.ArrayList;
import java.util.List;

public class CompraBLL
{
    private CompraDAL compraDAL = new CompraDAL();
    private CompraValidacion validacion = new CompraValidacion();

    public String procesoTrama(String trama)
    {
        String[] datos = trama.split("\\|", -1);

        String resultadoValidacion =
            validacion.validar(datos);

        if (!resultadoValidacion.equals("OK"))
        {
            return resultadoValidacion;
        }

        try
        {
            String noIngreso = datos[2];
            String fechaCompra = datos[3];
            String idJuridica = datos[4];

            List<DetalleCompra> detalles =
                new ArrayList<>();

            for (int i = 5; i < datos.length; i += 2)
            {
                String noProducto = datos[i];

                int cantidad =
                    Integer.parseInt(datos[i + 1]);

                DetalleCompra detalle =
                    new DetalleCompra(
                        noProducto,
                        cantidad
                    );

                detalles.add(detalle);
            }

            NuevaCompra compra =
                new NuevaCompra(
                    noIngreso,
                    fechaCompra,
                    idJuridica,
                    detalles
                );

            return compraDAL.insertarCompra(compra);
        }
        catch (NumberFormatException e)
        {
            return "ERROR: La cantidad de un producto no es válida";
        }
        catch (Exception e)
        {
            return "ERROR: " + e.getMessage();
        }
    }//procesoTrama.
}//CompraBLL.