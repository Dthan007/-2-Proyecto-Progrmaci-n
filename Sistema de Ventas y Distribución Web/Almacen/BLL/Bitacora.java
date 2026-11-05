package BLL;

import java.io.FileWriter;
import java.io.IOException;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.concurrent.BlockingQueue;
import java.util.concurrent.LinkedBlockingQueue;



public class Bitacora {

    private static final BlockingQueue<String> cola = new LinkedBlockingQueue<>();
    private static final DateTimeFormatter formato = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm:ss");

    public static void iniciarHilo(String rutaArchivo) {
        Thread hilo = new Thread(() -> procesarCola(rutaArchivo));
        hilo.setDaemon(true);
        hilo.start();
    } 

    private static void procesarCola(String rutaArchivo){
        while (true) {
            try {
                String entrada = cola.take();

                try (FileWriter escritor = new FileWriter(rutaArchivo, true)) {
                    escritor.write(entrada + System.lineSeparator());
                }
            } catch (InterruptedException | IOException error) {
                System.out.println("ERROR BITACORA: " + error.getMessage());
            }
        }
    }

    public static void registrar(String trama) {
        String fechaHora = LocalDateTime.now().format(formato);
        cola.add(fechaHora + ": " + trama);
    }
    
}
