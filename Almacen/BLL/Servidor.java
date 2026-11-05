package BLL;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.nio.charset.StandardCharsets;
import Bitacora.BitacoraService;

public class Servidor {

    private static final int PUERTO = 5000;

    public static void main(String[] args) {

        try (ServerSocket servidor = new ServerSocket(PUERTO)) {

            System.out.println("Servidor iniciado en el puerto " + PUERTO);

            Bitacora.iniciarHilo("bitacora_almacen.log"); //Almacen 5
            BitacoraService bitacoraService = new BitacoraService();
            
            while (true) {

                Socket cliente = servidor.accept();

                System.out.println("Cliente conectado");

                atenderCliente(cliente, bitacoraService);
            }

        } catch (IOException ex) {

            System.out.println("Error del servidor: " + ex.getMessage());
        }
    }//main.

    private static void atenderCliente(Socket cliente, BitacoraService bitacoraService) 
    {
        try (
            Socket socket = cliente;
            InputStream entrada = socket.getInputStream();
            OutputStream salida = socket.getOutputStream()
        ) {

            ProductoBLL productoBLL = new ProductoBLL();
            ProveedorBLL proveedorBLL = new ProveedorBLL();
            CompraBLL compraBLL = new CompraBLL();

            SalidaBLL salidaBLL = new SalidaBLL(); //Almacen 4

            byte[] buffer = new byte[1024];

            while (true) {

                int cantidadBytes = entrada.read(buffer);

                if (cantidadBytes == -1) {
                    System.out.println("Cliente desconectado");
                    break;
                }

                String mensaje = new String(
                    buffer,
                    0,
                    cantidadBytes,
                    StandardCharsets.UTF_8
                );

                System.out.println("Mensaje recibido: " + mensaje);
                
                //No borrar por si falla algo. 
                //bitacoraService.registrar(mensaje);
                //Bitacora.registrar(mensaje);

                String[] datos = mensaje.split("\\|", -1);
                System.out.println("TIPO DE TRAMA: [" + datos[0] + "]");

                String respuesta;

                if (datos[0].equals("PRODUCTO"))
                {
                    respuesta = productoBLL.procesoTrama(mensaje);
                }
                else if (datos[0].equals("PROVEEDOR"))
                {
                    respuesta = proveedorBLL.procesoTrama(mensaje);
                }
                else if (datos[0].equals("COMPRA"))
                {
                    respuesta = compraBLL.procesoTrama(mensaje);
                }
                else if (datos[0].equals("SALIDA")){
                    respuesta = salidaBLL.procesoTrama(mensaje);
                }
                else
                {
                    respuesta = "ERROR: Tipo de trama no reconocido";
                }

                byte[] datosRespuesta =
                    respuesta.getBytes(StandardCharsets.UTF_8);

                salida.write(datosRespuesta);
                salida.flush();
            }

        } catch (IOException ex) {

            System.out.println("Error con el cliente: " + ex.getMessage());
        }
    }//atenderCliente.
}//Servidor.
