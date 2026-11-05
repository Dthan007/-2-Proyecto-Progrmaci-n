package DAL;

import Entity.NuevoProducto;
import java.sql.Connection;
import java.sql.CallableStatement;
import java.sql.DriverManager;
import java.sql.ResultSet;

public class ProductoDAL
{
    private final String url =
        "jdbc:sqlserver://localhost:1433;" +
        "databaseName=Almacen;" +
        "encrypt=false;" +
        "trustServerCertificate=true;" +
        "integratedSecurity=true";

    public String guardarProducto(NuevoProducto producto)
    {
        String sql = "{CALL SP_InsertarNuevoProducto(?, ?, ?, ?)}";

        try
        (
            Connection conexion = DriverManager.getConnection(url);
            CallableStatement comando = conexion.prepareCall(sql)
        )
        {
            comando.setString(1, producto.getProducto());
            comando.setInt(2, producto.getTransaccion());
            comando.setString(3, producto.getNombre());
            comando.setDouble(4, producto.getPrecio());

            ResultSet resultado = comando.executeQuery();

            if (resultado.next())
            {
                return resultado.getString("Resultado");
            }

            return "ERROR";
        }
        catch (Exception e)
        {
            System.out.println("Error al guardar producto: " + e.getMessage());
            return "ERROR";
        }
    }

    public String modificarProducto(NuevoProducto producto)
    {
        String sql = "{CALL SP_ModificarProducto(?, ?, ?)}";

        try
        (
            Connection conexion = DriverManager.getConnection(url);
            CallableStatement comando = conexion.prepareCall(sql)
        )
        {
            comando.setString(1, producto.getProducto());
            comando.setString(2, producto.getNombre());
            comando.setDouble(3, producto.getPrecio());

            ResultSet resultado = comando.executeQuery();

            if (resultado.next())
            {
                return resultado.getString("Resultado");
            }

            return "ERROR";
        }
        catch (Exception e)
        {
            System.out.println("Error al modificar producto: " + e.getMessage());
            return "ERROR";
        }
    }//modificarProducto.
}//ProductoDAL.
