
package DAL;

import Entity.NuevaSalida;
import Entity.DetalleSalida;

import com.microsoft.sqlserver.jdbc.SQLServerCallableStatement;
import com.microsoft.sqlserver.jdbc.SQLServerDataTable;

import java.sql.Connection;
import java.sql.CallableStatement;
import java.sql.ResultSet;
import java.sql.Date;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

public class SalidaDAL {

    public String insertarSalida(NuevaSalida salida) {

        String sql = "{CALL SP_RegistrarSalida(?, ?, ?)}";

        try (
            Connection conexion = ConexionSQL.conectar();
            CallableStatement comando = conexion.prepareCall(sql)
        ) {

            DateTimeFormatter formato =
                DateTimeFormatter.ofPattern("yyyyMMdd");

            LocalDate fecha =
                LocalDate.parse(salida.getFechaVenta(), formato);

            Date fechaSQL = Date.valueOf(fecha);

            SQLServerDataTable detalles = new SQLServerDataTable();

            detalles.addColumnMetadata(
                "NoProducto",
                java.sql.Types.VARCHAR
            );

            detalles.addColumnMetadata(
                "Cantidad",
                java.sql.Types.INTEGER
            );

            for (DetalleSalida detalle : salida.getDetalles()) {

                detalles.addRow(
                    detalle.getNoProducto(),
                    detalle.getCantidad()
                );
            }

            comando.setString(1, salida.getNoFactura());
            comando.setDate(2, fechaSQL);

            SQLServerCallableStatement comandoSQL =
                comando.unwrap(SQLServerCallableStatement.class);

            comandoSQL.setStructured(
                3,
                "dbo.TipoDetalleSalida",
                detalles
            );

            try (ResultSet resultado = comando.executeQuery()) {

                if (resultado.next()) {
                    return resultado.getString("Resultado");
                }
            }

            return "ERROR: El procedimiento no devolvió respuesta.";

        } catch (Exception e) {

            return "ERROR: " + e.getMessage();
        }
    }
}
