using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Entities;
using MongoDB.Driver;

namespace BLL
{
    public class AutenticacionBLL
    {
        private const string MensajeCredenciales =
            "Usuario y/o contraseña incorrectos";

        private readonly UsuarioRepositorio repositorio;

        public AutenticacionBLL(UsuarioRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public RespuestaAutenticacion AutenticarUsuario(SolicitudLogin solicitud)
        {
            if (solicitud == null)
            {
                return Fallo(MensajeCredenciales);
            }

            string usuarioPlano;
            string contrasenaPlana;

            try
            {
                usuarioPlano = Cifrado.Descifrar(solicitud.Usuario);
                contrasenaPlana = Cifrado.Descifrar(solicitud.Contrasena);
            }
            catch (Exception ex) when (
                ex is FormatException ||
                ex is CryptographicException ||
                ex is ArgumentException)
            {
                Consola.Error("No se pudieron descifrar las credenciales recibidas", ex);
                return Fallo(MensajeCredenciales);
            }

            List<UsuarioDocumento> candidatos;

            try
            {
                candidatos = repositorio.ObtenerTodos()
                    .Where(u => u.Estado == "activo")
                    .ToList();
            }
            catch (Exception ex)
            {
                Consola.Error("No se pudo consultar MongoDB", ex);

                return Fallo("Error de MongoDB: " + ex.ToString());
            }
            /*
            catch (Exception ex) when (
                ex is MongoException ||
                ex is TimeoutException)
            {
                Consola.Error("No se pudo consultar MongoDB", ex);
                return Fallo("No se pudo consultar la base de datos de usuarios.");
            }*/

            foreach (var candidato in candidatos)
            {
                if (Coincide(candidato, usuarioPlano, contrasenaPlana))
                {
                    return new RespuestaAutenticacion
                    {
                        Resultado = true,
                        Id = candidato.Identificacion,
                        Tipo = candidato.Tipo,
                        Mensaje = "Exitoso"
                    };
                }
            }

            return Fallo(MensajeCredenciales);
        }

        private bool Coincide(
            UsuarioDocumento candidato,
            string usuario,
            string contrasena)
        {
            try
            {
                return Cifrado.Descifrar(candidato.Usuario) == usuario
                    && Cifrado.Descifrar(candidato.Contrasena) == contrasena;
            }
            catch (Exception ex) when (
                ex is FormatException ||
                ex is CryptographicException ||
                ex is ArgumentException)
            {
                Consola.Error(
                    "Usuario con datos cifrados invalidos en la base: "
                    + candidato.Identificacion, ex);

                return false;
            }
        }

        private RespuestaAutenticacion Fallo(string mensaje)
        {
            Consola.Error(mensaje);

            return new RespuestaAutenticacion
            {
                Resultado = false,
                Mensaje = mensaje
            };
        }
    }
}