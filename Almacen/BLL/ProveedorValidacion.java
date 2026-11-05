package BLL;

public class ProveedorValidacion
{
    public String validar(String[] datos)
    {
        //Cantidad de datos
        if (datos.length != 8)
        {
            return "La trama debe contener 8 datos";
        }

        //Identificador
        if (!datos[0].equals("PROVEEDOR"))
        {
            return "Operación no válida";
        }

        //Transacción
        if (datos[1].isEmpty())
        {
            return "La transacción está vacía";
        }

        if (datos[1].length() != 1)
        {
            return "La transacción debe ocupar 1 espacio";
        }

        if (!datos[1].equals("0") && !datos[1].equals("1"))
        {
            return "La transacción debe ser 0 o 1";
        }

        //ID Jurídica
        if (datos[2].isEmpty())
        {
            return "La identificación jurídica está vacía";
        }

        if (datos[2].length() != 10)
        {
            return "La identificación jurídica debe tener 10 caracteres";
        }

        if (!datos[2].matches("\\d{10}"))
        {
            return "La identificación jurídica debe contener únicamente números";
        }

        //Nombre empresa
        if (datos[3].isEmpty())
        {
            return "El nombre de la empresa está vacío";
        }

        if (datos[3].length() > 100)
        {
            return "El nombre de la empresa no puede superar 100 caracteres";
        }

        //Nombre contacto
        if (datos[4].isEmpty())
        {
            return "El nombre del contacto está vacío";
        }

        if (datos[4].length() > 75)
        {
            return "El nombre del contacto no puede superar 75 caracteres";
        }

        //Teléfono
        if (datos[5].isEmpty())
        {
            return "El teléfono está vacío";
        }

        if (datos[5].length() != 8)
        {
            return "El teléfono debe tener 8 caracteres";
        }

        if (!datos[5].matches("\\d{8}"))
        {
            return "El teléfono debe contener únicamente números";
        }

        //Correo
        if (datos[6].isEmpty())
        {
            return "El correo está vacío";
        }

        if (datos[6].length() > 75)
        {
            return "El correo no puede superar 75 caracteres";
        }

        if (!datos[6].matches("^[A-Za-z0-9+_.-]+@[A-Za-z0-9.-]+$"))
        {
            return "El correo no tiene un formato válido";
        }

        //Estado
        if (datos[7].isEmpty())
        {
            return "El estado está vacío";
        }

        if (datos[7].length() != 1)
        {
            return "El estado debe ocupar 1 espacio";
        }

        if (!datos[7].equals("0") && !datos[7].equals("1"))
        {
            return "El estado debe ser 0 o 1";
        }

        return "OK";
    }//validar.
}//ProveedorValidacion.