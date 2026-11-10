using System;
using System.Security.Cryptography;
using Entities;
using MongoDB.Driver;

namespace BLL
{
    public class UsuarioBLL
    {
        private const string MensajeCrear = "Usuario ya existe o datos incorrectos o incompletos.";
        private const string MensajeModificar = "Usuario no existe o datos incorrectos o incompletos.";
        private const string MensajeEstado = "Usuario no existe o datos incorrectos.";
        private const string MensajeBaseDatos = "No se pudo acceder a la base de datos de usuarios.";

        private readonly UsuarioRepositorio repositorio;

        public UsuarioBLL(UsuarioRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public RespuestaServicio CrearUsuario(SolicitudCrearUsuario solicitud) //	Valida que no exista la identificación ni el nombre de usuario y registra la cuenta.
        {
            string usuario;
            string contrasena;

            if (!DatosValidos(solicitud, out usuario, out contrasena))
            {
                return Fallo(MensajeCrear);
            }

            var estado = (solicitud.Estado ?? "").Trim().ToLower();
            var tipo = (solicitud.Tipo ?? "").Trim();

            if (estado != "activo" || (tipo != "1" && tipo != "2"))
            {
                Consola.Error("Estado o tipo invalido para un usuario nuevo");
                return Fallo(MensajeCrear);
            }

            try
            {
                var documento = ConstruirDocumento(solicitud, usuario, contrasena);

                if (repositorio.ObtenerPorIdentificacion(documento.Identificacion) != null || ExisteNombreUsuario(usuario, documento.Identificacion))
                {
                    return Fallo(MensajeCrear);
                }

                documento.Estado = "activo";
                documento.Tipo = int.Parse(tipo);

                repositorio.Insertar(documento);
            }
            catch (Exception ex) when (ex is MongoException || ex is TimeoutException)
            {
                Consola.Error("No se pudo crear el usuario en MongoDB", ex);
                return Fallo(MensajeBaseDatos);
            }

            return Exito();
        }

        public RespuestaServicio ModificarUsuario(DatosUsuario solicitud) //	Comprueba que el usuario exista y actualiza sus datos
        {
            string usuario;
            string contrasena;

            if (!DatosValidos(solicitud, out usuario, out contrasena))
            {
                return Fallo(MensajeModificar);
            }

            try
            {
                var documento = ConstruirDocumento(solicitud, usuario, contrasena);

                if (repositorio.ObtenerPorIdentificacion(documento.Identificacion) == null || ExisteNombreUsuario(usuario, documento.Identificacion))
                {
                    return Fallo(MensajeModificar);
                }

                repositorio.ActualizarDatos(documento);
            }
            catch (Exception ex) when (ex is MongoException || ex is TimeoutException)
            {
                Consola.Error("No se pudo modificar el usuario en MongoDB", ex);
                return Fallo(MensajeBaseDatos);
            }

            return Exito();
        }

        public RespuestaServicio CambiarEstado(SolicitudCambioEstado solicitud) //	Comprueba que el usuario exista y cambia su estado a activo o inactivo.
        {
            if (solicitud == null || !ValidacionesUsuario.EsIdentificacionValida(solicitud.Identificacion))
            {
                return Fallo(MensajeEstado);
            }

            var estado = (solicitud.Estado ?? "").Trim().ToLower();

            if (estado != "activo" && estado != "inactivo")
            {
                return Fallo(MensajeEstado);
            }

            try
            {
                var identificacion = solicitud.Identificacion.Trim();

                if (repositorio.ObtenerPorIdentificacion(identificacion) == null)
                {
                    return Fallo(MensajeEstado);
                }

                repositorio.ActualizarEstado(identificacion, estado);
            }
            catch (Exception ex) when (ex is MongoException || ex is TimeoutException)
            {
                Consola.Error("No se pudo cambiar el estado del usuario en MongoDB", ex);
                return Fallo(MensajeBaseDatos);
            }

            return Exito();
        }

        private bool DatosValidos(DatosUsuario datos, out string usuario, out string contrasena) //Descifra las credenciales y valida los datos recibidos.
        {
            usuario = null;
            contrasena = null;

            if (datos == null)
            {
                return Invalido("No se recibieron datos");
            }

            try
            {
                usuario = Cifrado.Descifrar(datos.Usuario);
                contrasena = Cifrado.Descifrar(datos.Contrasena);
            }
            catch (Exception ex) when (ex is FormatException || ex is CryptographicException || ex is ArgumentException)
            {
                Consola.Error("No se pudieron descifrar el usuario y la contraseña", ex);
                return false;
            }

            if (!ValidacionesUsuario.EsIdentificacionValida(datos.Identificacion))
            {
                return Invalido("identificacion");
            }

            if (!ValidacionesUsuario.EsNombreValido(datos.Nombre))
            {
                return Invalido("nombre");
            }

            if (!ValidacionesUsuario.EsNombreValido(datos.PrimerApellido))
            {
                return Invalido("primer apellido");
            }

            if (!ValidacionesUsuario.EsNombreValido(datos.SegundoApellido))
            {
                return Invalido("segundo apellido");
            }

            if (!ValidacionesUsuario.EsCorreoValido(datos.CorreoElectronico))
            {
                return Invalido("correo electronico");
            }

            if (!ValidacionesUsuario.EsUsuarioValido(usuario))
            {
                return Invalido("usuario");
            }

            if (!ValidacionesUsuario.EsContrasenaValida(contrasena))
            {
                return Invalido("contraseña");
            }

            return true;
        }

        private UsuarioDocumento ConstruirDocumento(DatosUsuario datos, string usuario, string contrasena) //Convierte los datos de la solicitud en un UsuarioDocumento
        {
            return new UsuarioDocumento
            {
                Identificacion = datos.Identificacion.Trim(),
                Nombre = datos.Nombre.Trim(),
                PrimerApellido = datos.PrimerApellido.Trim(),
                SegundoApellido = datos.SegundoApellido.Trim(),
                CorreoElectronico = datos.CorreoElectronico.Trim(),
                Usuario = Cifrado.Cifrar(usuario),
                Contrasena = Cifrado.Cifrar(contrasena)
            };
        }

        private bool ExisteNombreUsuario(string usuario, string identificacionExcluida) //Evita que dos usuarios compartan el mismo nombre de usuario.
        {
            foreach (var existente in repositorio.ObtenerTodos())
            {
                if (existente.Identificacion == identificacionExcluida)
                {
                    continue;
                }

                try
                {
                    if (Cifrado.Descifrar(existente.Usuario) == usuario)
                    {
                        return true;
                    }
                }
                catch (Exception ex) when (ex is FormatException || ex is CryptographicException || ex is ArgumentException)
                {
                    Consola.Error("Usuario con datos cifrados invalidos en la base: " + existente.Identificacion, ex);
                }
            }

            return false;
        }

        private bool Invalido(string motivo)
        {
            Consola.Error("Dato invalido: " + motivo);
            return false;
        }

        private RespuestaServicio Exito()
        {
            return new RespuestaServicio { Resultado = true, Mensaje = "Exitoso" };
        }

        private RespuestaServicio Fallo(string mensaje)
        {
            Consola.Error(mensaje);

            return new RespuestaServicio { Resultado = false, Mensaje = mensaje };
        }
    }
}