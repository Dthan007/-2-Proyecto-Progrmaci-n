package DAL;


import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class ConexionSQL {

    private static final String URL =
        "jdbc:sqlserver://localhost:1433;" +
        "databaseName=ALMACEN1;" +
        "encrypt=true;" +
        "trustServerCertificate=true;" +
        "integratedSecurity=true;";

    public static Connection conectar() {

        try {
            return DriverManager.getConnection(URL);

        } catch (SQLException e) {
            System.err.println(
                "Error de conexión: " + e.getMessage()
            );
            return null;
        }
    }
}
