package BLL;

import DAL.SalidaDAL;
import Entity.NuevaSalida;
import Entity.DetalleSalida;

import java.util.ArrayList;
import java.util.List;

public class SalidaBLL {
    private SalidaDAL salidaDAL = new SalidaDAL();
    private SalidaValidacion validacion = new SalidaValidacion();    

    public String procesoTrama(String trama){
        String [] datos = trama.split("\\|", -1);

        String resultadoValidacion = validacion.validar(datos);

        if (!resultadoValidacion.equals("OK")){
            return resultadoValidacion;
        }

        try {
            String noFactura = datos[2];
            String fechaVenta = datos[3];

            List<DetalleSalida> detalles = new ArrayList<>();

            for (int i =  4; i<datos.length; i += 2){
                String noProducto = datos[i];

                int cantidad = Integer.parseInt(datos[ i + 1]);

                DetalleSalida detalle = new DetalleSalida(noProducto, cantidad);

                detalles.add(detalle);
            }

            NuevaSalida salida = new NuevaSalida(noFactura, fechaVenta, detalles);

            return salidaDAL.insertarSalida(salida);
        } catch (NumberFormatException e) {
            return "ERROR: La cantidad de un producto no es valida";
        } catch (Exception e) {
            return "ERROR: " + e.getMessage();
        }
    }//procesoTrama.
}//SalidaBLL.
