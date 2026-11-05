package BLL;

public class ProductoValidacion
{
    public String validar(String[] datos)
    {
        //VALIDACIONES DE LA TRAMA

        if (datos == null)
        {
            return "DATO INVÁLIDO: Debe completar todos los campos.";
        }

        if (datos.length != 5)
        {
            return "DATO INVÁLIDO: Debe completar todos los campos.";
        }

        if (datos[0] == null || datos[0].isEmpty())
        {
            return "DATO INVÁLIDO: El tipo de operación está vacío";
        }
        
        //TRANSACCIÓN
        if (datos[1] == null)
        {
            return "DATO INVÁLIDO: Transacción.";
        }

        if (datos[1].isEmpty())
        {
            return "DATO INVÁLIDO: Campo transacción está vacía";
        }

        if (!datos[1].equals("0") && !datos[1].equals("1"))
        {
            return "DATO INVÁLIDO";
        }


        
        //PRODUCTO
        if (datos[2] == null)
        {
            return "DATO INVÁLIDO: Campo NoProducto no puede estar vacío.";
        }

        if (datos[2].isEmpty())
        {
            return "DATO INVÁLIDO: Campo NoProducto no puede estar vacío.";
        }

        if (datos[2].length() != 10)
        {
            return "DATO INVÁLIDO: El código de producto debe ocupar 10 espacios";
        }

        if (!datos[2].matches("\\d+"))
        {
            return "DATO INVÁLIDO: El código de producto debe contener únicamente números";
        }

        if (datos[2].equals("0000000000"))
        {
            return "DATO INVÁLIDO: El código de producto no puede ser 0000000000";
        }


        //NOMBRE
        if (datos[3] == null)
        {
            return "DATO INVÁLIDO: Campo Nombre no puede estar vacío.";
        }

        if (datos[3].isEmpty())
        {
            return "DATO INVÁLIDO: Campo Nombre no puede estar vacío.";
        }

        if (datos[3].trim().isEmpty())
        {
            return "DATO INVÁLIDO: El nombre no puede contener únicamente espacios";
        }

        if (!datos[3].matches(".*[a-zA-ZáéíóúÁÉÍÓÚñÑ].*"))
        {
            return "DATO INVÁLIDO: El nombre debe contener al menos una letra";
        }


        
        //PRECIO
        if (datos[4] == null)
        {
            return "DATO INVÁLIDO: Campo precio no puede estar vacío.";
        }

        if (datos[4].isEmpty())
        {
            return "DATO INVÁLIDO: Campo precio no puede estar vacío.";
        }

        if (datos[4].length() != 8)
        {
            return "DATO INVÁLIDO: El precio debe ocupar 8 espacios";
        }

        if (!datos[4].matches("\\d{8}"))
        {
            return "DATO INVÁLIDO: El precio debe contener únicamente números";
        }

        if (datos[4].equals("00000000"))
        {
            return "DATO INVÁLIDO: El precio debe ser mayor que cero";
        }
        return "OK";
    }//validar.
}//ProductoValidacion.
