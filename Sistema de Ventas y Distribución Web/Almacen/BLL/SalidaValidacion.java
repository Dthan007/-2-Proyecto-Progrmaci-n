package BLL;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.format.DateTimeParseException;

public class SalidaValidacion {

    public String validar(String[] datos){
        if (datos.length < 5){
            return "La salida debe contener al menos un producto";
        }

        if (!datos[0].equals("SALIDA")){
            return "Operacion ni valida";
        }

        if (!datos[1].equals("6")){
            return "La transaccion de salida debe ser 6";
        }

        if (datos[2].isEmpty()){
            return "El numero de factura esta vacio";
        }

        if (datos[2].length() != 10){
            return "El numero de factura debe tener 10 caracteres";
        }

        if (!datos[2].matches("\\d{10}")) {
            return "El numero de factura debe contener unicamente numeros";
        }

        if (datos[3].isEmpty()){
            return "La fecha de venta esta vacia";
        }

        if (!datos[3].matches("\\d{8}")) {
            return "La fecha debe tener al formato YYYYMMDD";
        }

        try{
            DateTimeFormatter formato = DateTimeFormatter.ofPattern("yyyyMMdd");

            LocalDate fechaVenta = LocalDate.parse(datos[3], formato);

            if (fechaVenta.isAfter(LocalDate.now())){
                return "La fecha de venta no puede ser a futuro";
            }
        } catch (DateTimeParseException e) {
            return "La fecha de venta no es valida";
        }

        if ((datos.length - 4) % 2 != 0) {
            return "Cada producto debe tener una cantidad";
        }

        for ( int i = 4; i < datos.length; i+=2){
            String noProducto = datos[i];
            String cantidad = datos[i + 1];

            if (noProducto.isEmpty()){
                return "El numero de producto esta vacio";
            }

            if (noProducto.length() != 10){
                return "El numero de producto debe tener 10 caracteres";
            }

            if (noProducto.matches("\\d{10}")){
                return "El numero de factura debe contener unicamente numeros";
            }

            if (cantidad.isEmpty())
            {
                return "La cantidad del producto esta vacia";
            }

            if (cantidad.length() != 7){
                return "La cantidad debe tener 7 caracteres";
            }

            if (!cantidad.matches("\\\\d{7}")){
                return "La cantidad debe contener unicamente numeros";
            }

            try{
                int cantidadNumero = Integer.parseInt(cantidad);

                if(cantidadNumero <= 0){
                    return "La cantidad debe ser mayor que cero";
                }
            } catch (NumberFormatException e) {
                return "La cantidad no es valida";
            }
        }

        return "OK";
    }//validar.
}//SalidaValidacion.
