using System;
using System.Net.Sockets;
using System.Text;

namespace BLL
{
    public class ConexionSocket
    {
        private TcpClient clienteTCP;
        private NetworkStream streamNW;

        private readonly string ipServidor;
        private readonly int puertoServidor;

        public ConexionSocket(string ip, int puerto)
        {
            ipServidor = ip;
            puertoServidor = puerto;
        }

        public bool Conectar()
        {
            try
            {
                clienteTCP = new TcpClient();
                clienteTCP.Connect(ipServidor, puertoServidor);

                streamNW = clienteTCP.GetStream();

                return true;
            }
            catch (Exception)
            {
                Desconectar();
                return false;
            }
        }

        public string EnviarYRecibir(string mensaje)
        {
            if (streamNW == null)
            {
                return "ERROR: No existe conexión con el servidor.";
            }

            try
            {
                byte[] datos = Encoding.UTF8.GetBytes(mensaje);

                streamNW.Write(datos, 0, datos.Length);
                streamNW.Flush();

                streamNW.ReadTimeout = 5000;

                byte[] buffer = new byte[4096];

                int cantidad = streamNW.Read(buffer, 0, buffer.Length);

                if (cantidad == 0)
                {
                    return "ERROR: El servidor no envió respuesta.";
                }

                return Encoding.UTF8.GetString(buffer, 0, cantidad);
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        public void Desconectar()
        {
            streamNW?.Close();
            clienteTCP?.Close();
        }
    }//ConexionSocket.
}//BLL.