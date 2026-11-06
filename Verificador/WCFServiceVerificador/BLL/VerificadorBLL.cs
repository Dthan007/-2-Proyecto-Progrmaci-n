using System;
using Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VerificadorBLL
    {
        private readonly string ip;
        private readonly int puerto;

        public VerificadorBLL(string ip, int puerto)
        {
            this.ip = ip;
            this.puerto = puerto;
        }

        public RespuestaServicio MantenimientoCLiente(SolicitudCliente solicitud)
        {
            if (solicitud == null)
            {
                return Fallo("No se recibieron datos.");
            }

            var trama = new
            {
                tipo_transaccion = (solicitud.TipoTransaccion ?? "").Trim().ToLower(),
                identificacion = solicitud.Identificacion,
                pais_origen = solicitud.PaisOrigen,
                nombre = solicitud.Nombre,
                primer_apellido = solicitud.PrimerApellido,
                segundo_apellido = solicitud.SegundoApellido,
                telefono = solicitud.Telefono,
                correo_electronico = solicitud.CorreoElectronico,
                direccion = solicitud.Direccion
            };

            var conexion = new ConexionSocket(ip, puerto);

            if (!conexion.Conectar())
            {
                return Fallo("No se pudo conectar con el verificador");
            }

            var respuestaJson = conexion.EnviarYRecibir(JsonConvert.SerializeObject(trama));
            conexion.Desconectar();

            return InterpretarRespuesta(respuestaJson);
        }

        private RespuestaServicio InterpretarRespuesta(string respuestaJson)
        {
            string status;

            try
            {
                status = (string)JObject.Parse(respuestaJson)["status"];
            }
            catch (JsonException)
            {
                return Fallo(respuestaJson);
            }

            if (status == "OK")
            {
                return new RespuestaServicio { Resultado = true, Mensaje = "Exitoso" };
            }

            return Fallo(TraducirStatus(status));
        }

        private string TraducirStatus(string status)
        {
            switch (status)
            {
                case "1": return "Datos invalidos";
                case "2": return "El cliente ya existe";
                case "3": return "El cliente no existe";
                case "4": return "Error no controlado";
                default: return status;
            }
        }

        private RespuestaServicio Fallo(string detalle)
        {
            return new RespuestaServicio
            {
                Resultado = false,
                Mensaje = "Problemas al incluir la informacion." + detalle
            };
        }
    }
}
