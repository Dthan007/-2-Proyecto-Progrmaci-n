
package DAL;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class ConexionSQL {

    private static final String SERVIDOR = "localhost";
    private static final String PUERTO = "1433";
    private static final String BASE_DATOS = "Almacen";

    private static final String URL =
        "jdbc:sqlserver://" + SERVIDOR + ":" + PUERTO +
        ";databaseName=" + BASE_DATOS +
        ";encrypt=true" +
        ";trustServerCertificate=true" +
        ";integratedSecurity=true";

    public static Connection conectar() {

        try {
            Connection conexion = DriverManager.getConnection(URL);

            System.out.println("Conexión exitosa con SQL Server.");

            return conexion;

        } catch (SQLException e) {

            System.err.println("Error al conectar con SQL Server:");
            System.err.println(e.getMessage());

            return null;
        }
    }
}
