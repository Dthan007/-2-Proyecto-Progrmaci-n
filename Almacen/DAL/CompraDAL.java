package DAL;

import Entity.NuevaCompra;
import Entity.DetalleCompra;

import com.microsoft.sqlserver.jdbc.SQLServerCallableStatement;
import com.microsoft.sqlserver.jdbc.SQLServerDataTable;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.CallableStatement;
import java.sql.ResultSet;
import java.sql.Date;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

public class CompraDAL
{
    private final String url =
        "jdbc:sqlserver://localhost:1433;" +
        "databaseName=Almacen;" +
        "encrypt=false;" +
        "trustServerCertificate=true;" +
        "integratedSecurity=true";

    public String insertarCompra(NuevaCompra compra)
    {
        String sql = "{CALL SP_InsertarCompra(?, ?, ?, ?)}";

        try
        (
            Connection conexion = DriverManager.getConnection(url);
            CallableStatement comando =
                conexion.prepareCall(sql)
        )
        {
            DateTimeFormatter formato =
                DateTimeFormatter.ofPattern("yyyyMMdd");

            LocalDate fecha =
                LocalDate.parse(compra.getFechaCompra(), formato);

            Date fechaSQL =
                Date.valueOf(fecha);

            SQLServerDataTable detalles =
                new SQLServerDataTable();

            detalles.addColumnMetadata(
                "NoProducto",
                java.sql.Types.VARCHAR
            );

            detalles.addColumnMetadata(
                "Cantidad",
                java.sql.Types.INTEGER
            );

            for (DetalleCompra detalle : compra.getDetalles())
            {
                detalles.addRow(
                    detalle.getNoProducto(),
                    detalle.getCantidad()
                );
            }

            comando.setString(1, compra.getNoIngreso());
            comando.setDate(2, fechaSQL);
            comando.setString(3, compra.getIdJuridica());

            SQLServerCallableStatement comandoSQL =
                comando.unwrap(SQLServerCallableStatement.class);

            comandoSQL.setStructured(
                4,
                "dbo.TipoDetalleCompra",
                detalles
            );

            ResultSet resultado =
                comando.executeQuery();

            if (resultado.next())
            {
                return resultado.getString("Resultado");
            }

            return "ERROR: El procedimiento no devolvió respuesta.";
        }
        catch (Exception e)
        {
            return "ERROR: " + e.getMessage();
        }
    }//insertarCompra.
}//CompraDAL.