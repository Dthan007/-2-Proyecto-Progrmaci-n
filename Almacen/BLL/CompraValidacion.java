package BLL;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.format.DateTimeParseException;

public class CompraValidacion
{
    public String validar(String[] datos)
    {
        if (datos.length < 7)
        {
            return "La compra debe contener al menos un producto";
        }

        if (!datos[0].equals("COMPRA"))
        {
            return "Operación no válida";
        }

        //if (!datos[1].equals("5"))
        //{
        //    return "La transacción de compra debe ser 5";
        //}

        if (datos[2].isEmpty())
        {
            return "El número de ingreso está vacío";
        }

        if (datos[2].length() != 10)
        {
            return "El número de ingreso debe tener 10 caracteres";
        }

        if (!datos[2].matches("\\d{10}"))
        {
            return "El número de ingreso debe contener únicamente números";
        }

        if (datos[3].isEmpty())
        {
            return "La fecha de compra está vacía";
        }

        if (!datos[3].matches("\\d{8}"))
        {
            return "La fecha debe tener el formato YYYYMMDD";
        }

        try
        {
            DateTimeFormatter formato =
                DateTimeFormatter.ofPattern("yyyyMMdd");

            LocalDate.parse(datos[3], formato);
        }
        catch (DateTimeParseException e)
        {
            return "La fecha de compra no es válida";
        }

        if (datos[4].isEmpty())
        {
            return "La cédula jurídica está vacía";
        }

        if (datos[4].length() != 10)
        {
            return "La cédula jurídica debe tener 10 caracteres";
        }

        if (!datos[4].matches("\\d{10}"))
        {
            return "La cédula jurídica debe contener únicamente números";
        }

        if ((datos.length - 5) % 2 != 0)
        {
            return "Cada producto debe tener una cantidad";
        }

        for (int i = 5; i < datos.length; i += 2)
        {
            String noProducto = datos[i];
            String cantidad = datos[i + 1];

            if (noProducto.isEmpty())
            {
                return "El número de producto está vacío";
            }

            if (noProducto.length() != 10)
            {
                return "El número de producto debe tener 10 caracteres";
            }

            if (!noProducto.matches("\\d{10}"))
            {
                return "El número de producto debe contener únicamente números";
            }

            if (cantidad.isEmpty())
            {
                return "La cantidad del producto está vacía";
            }

            if (cantidad.length() != 7)
            {
                return "La cantidad debe tener 7 caracteres";
            }

            if (!cantidad.matches("\\d{7}"))
            {
                return "La cantidad debe contener únicamente números";
            }

            try
            {
                int cantidadNumero = Integer.parseInt(cantidad);

                if (cantidadNumero <= 0)
                {
                    return "La cantidad debe ser mayor que cero";
                }
            }
            catch (NumberFormatException e)
            {
                return "La cantidad no es válida";
            }
        }

        return "OK";
    }//validar.
}//CompraValidacion.