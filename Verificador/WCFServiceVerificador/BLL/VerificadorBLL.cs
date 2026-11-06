using System;
using System.Globalization;
using System.Security.Cryptography;
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

        private const string PrefijoClientes = "Problemas al incluir la información. ";
        private const string PrefijoCompras = "Problemas al registrar la compra. ";
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
                return Fallo(PrefijoClientes, "No se recibieron datos.");
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

            return EnviarYInterpretar(trama, PrefijoClientes, TraducirStatusCliente);
        }

        public RespuestaServicio RegistrarCompra(SolicitudCompra solicitud)
        {
            if (solicitud == null || solicitud.Productos == null)
            {
                return Fallo(PrefijoCompras, "No se recibieron datos.");
            }

            object trama;

            try
            {
                trama = new
                {
                    historia = "VERIFICADOR2",
                    numero_compra = long.Parse(Cifrado.Descifrar(solicitud.NumeroCompra), CultureInfo.InvariantCulture),
                    identificacion_cliente = Cifrado.Descifrar(solicitud.IdentificacionCliente),
                    fecha_compra = Cifrado.Descifrar(solicitud.FechaCompra),
                    total_compra = decimal.Parse(Cifrado.Descifrar(solicitud.TotalCompra), CultureInfo.InvariantCulture),
                    tarjeta_cifrada = solicitud.TarjetaCifrada,
                    vencimiento_cifrado = solicitud.VencimientoCifrado,
                    cvv_cifrado = solicitud.CvvCifrado,
                    productos = solicitud.Productos.Select(p => new
                    {
                        codigo_producto = long.Parse(Cifrado.Descifrar(p.CodigoProducto), CultureInfo.InvariantCulture),
                        cantidad = int.Parse(Cifrado.Descifrar(p.Cantidad), CultureInfo.InvariantCulture)
                    }).ToList()
                };
            }
            catch (Exception ex) when (ex is FormatException || ex is CryptographicException || ex is OverflowException || ex is ArgumentException)
            {
                Consola.Error("No se pudo descifrar o convertir la compra", ex);
                return Fallo(PrefijoCompras, "Datos cifrados invalidos.");
            }

            return EnviarYInterpretar(trama, PrefijoCompras, TraducirStatusCompra);
        }

        private RespuestaServicio EnviarYInterpretar(object trama, string prefijo, Func<string, string> traducir)
        {
            var conexion = new ConexionSocket(ip, puerto);

            if (!conexion.Conectar())
            {
                return Fallo(prefijo, "No se pudo conectar con el verificador.");
            }

            var respuestaJson = conexion.EnviarYRecibir(JsonConvert.SerializeObject(trama));
            conexion.Desconectar();

            string status;

            try
            {
                status = (string)JObject.Parse(respuestaJson)["status"];
            }
            catch (JsonException ex)
            {
                Consola.Error("La respuesta del verificador no es JSON: " + respuestaJson, ex);
                return Fallo(prefijo, respuestaJson);
            }

            if (status == "OK")
            {
                return new RespuestaServicio { Resultado = true, Mensaje = "Exitoso" };
            }

            return Fallo(prefijo, traducir(status));
        }

        private string TraducirStatusCliente(string status)
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

        private string TraducirStatusCompra(string status)
        {
            switch (status)
            {
                case "1": return "Datos invalidos, el cliente no existe o la compra ya esta registrada";
                case "2": return "El almacen no pudo procesar la compra";
                case "4": return "Error no controlado";
                default: return status;
            }
        }

        private RespuestaServicio Fallo(string prefijo, string detalle)
        {
            Consola.Error(prefijo + detalle);

            return new RespuestaServicio
            {
                Resultado = false,
                Mensaje = prefijo + detalle
            };
        }
    }
}
