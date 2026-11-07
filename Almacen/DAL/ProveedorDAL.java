
package DAL;

import Entity.NuevoProveedor;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;

public class ProveedorDAL {

    public String insertarProveedor(NuevoProveedor proveedor) {

        String sql = "{CALL SP_InsertarProveedor(?, ?, ?, ?, ?, ?, ?)}";

        try (
            Connection conexion = ConexionSQL.conectar();
            CallableStatement comando = conexion.prepareCall(sql)
        ) {

            comando.setString(1, proveedor.getIDJuridica());
            comando.setInt(2, proveedor.getTipoTransaccion());
            comando.setString(3, proveedor.getNombreEmpresa());
            comando.setString(4, proveedor.getNombreContacto());
            comando.setString(5, proveedor.getTelefono());
            comando.setString(6, proveedor.getCorreo());
            comando.setInt(7, proveedor.getEstado());

            try (ResultSet resultado = comando.executeQuery()) {

                if (resultado.next()) {
                    return resultado.getString("Resultado");
                }
            }

            return "ERROR";

        } catch (Exception e) {

            System.out.println(
                "Error al insertar proveedor: " + e.getMessage()
            );

            return "ERROR";
        }
    }

    public ResultSet consultarProveedor(String idJuridica) {

        String sql = "{CALL SP_ConsultarProveedor(?)}";

        try {

            Connection conexion = ConexionSQL.conectar();

            CallableStatement comando = conexion.prepareCall(sql);

            comando.setString(1, idJuridica);

            return comando.executeQuery();

        } catch (Exception e) {

            System.out.println(
                "Error al consultar proveedor: " + e.getMessage()
            );

            return null;
        }
    }

    public String modificarProveedor(NuevoProveedor proveedor) {

        String sql = "{CALL SP_ModificarProveedor(?, ?, ?, ?, ?, ?)}";

        try (
            Connection conexion = ConexionSQL.conectar();
            CallableStatement comando = conexion.prepareCall(sql)
        ) {

            comando.setString(1, proveedor.getIDJuridica());
            comando.setString(2, proveedor.getNombreEmpresa());
            comando.setString(3, proveedor.getNombreContacto());
            comando.setString(4, proveedor.getTelefono());
            comando.setString(5, proveedor.getCorreo());
            comando.setInt(6, proveedor.getEstado());

            try (ResultSet resultado = comando.executeQuery()) {

                if (resultado.next()) {
                    return resultado.getString("Resultado");
                }
            }

            return "ERROR";

        } catch (Exception e) {

            System.out.println(
                "Error al modificar proveedor: " + e.getMessage()
            );

            return "ERROR";
        }
    }
}
