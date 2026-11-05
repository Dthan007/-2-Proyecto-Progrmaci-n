package Bitacora;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.concurrent.BlockingQueue;
import java.util.concurrent.LinkedBlockingQueue;

public class BitacoraService {

    private final BlockingQueue<String> cola;
    private final Thread hiloEscritor;

    private final String archivo = "bitacora.txt";

    private final DateTimeFormatter formatoFecha =
        DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm:ss");

    public BitacoraService() {

        cola = new LinkedBlockingQueue<>();

        hiloEscritor = new Thread(() -> {

            while (true) {

                try {

                    String trama = cola.take();

                    escribirBitacora(trama);

                } catch (InterruptedException e) {

                    Thread.currentThread().interrupt();
                    break;

                } catch (Exception e) {

                    System.out.println(
                        "Error al escribir bitácora: " + e.getMessage()
                    );
                }
            }

        });

        hiloEscritor.setDaemon(true);
        hiloEscritor.start();
    }

    public void registrar(String trama) {

        if (trama == null || trama.isBlank()) {
            return;
        }

        cola.offer(trama);
    }

    private void escribirBitacora(String trama) {

        String json = convertirAJson(trama);

        try (
            BufferedWriter escritor =
                new BufferedWriter(
                    new FileWriter(archivo, true)
                )
        ) {

            escritor.write(json);
            escritor.newLine();

        } catch (IOException e) {

            System.out.println(
                "Error escribiendo bitácora: " + e.getMessage()
            );
        }
    }

    private String convertirAJson(String trama) {

        String[] datos = trama.split("\\|", -1);

        String fecha = LocalDateTime.now().format(formatoFecha);

        String tipoTransaccion = datos.length > 0
            ? datos[0]
            : "DESCONOCIDO";

        StringBuilder json = new StringBuilder();

        json.append("{");

        json.append("\"Fecha bitacora\":\"")
            .append(fecha)
            .append("\",");

        json.append("\"Tipo transaccion\":\"")
            .append(escaparJson(tipoTransaccion))
            .append("\",");

        json.append("\"Detalle\":{");

        for (int i = 1; i < datos.length; i++) {

            json.append("\"Campo")
                .append(i)
                .append("\":\"")
                .append(escaparJson(datos[i]))
                .append("\"");

            if (i < datos.length - 1) {
                json.append(",");
            }
        }

        json.append("}");

        json.append("}");

        return json.toString();
    }

    private String escaparJson(String texto) {

        return texto
            .replace("\\", "\\\\")
            .replace("\"", "\\\"")
            .replace("\n", "\\n")
            .replace("\r", "\\r");
    }
}
