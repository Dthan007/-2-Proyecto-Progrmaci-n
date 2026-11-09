/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
//Comunica con MongoDB
namespace BLL
{
    public class UsuarioRepositorio
    {
        private static MongoClient cliente;
        private static readonly object candado = new object();

        private readonly IMongoCollection<UsuarioDocumento> coleccion;

        public UsuarioRepositorio(string cadenaConexion, string baseDatos)
        {
            lock (candado)
            {
                if (cliente == null)
                {
                    cliente = new MongoClient(cadenaConexion);
                }
            }

            coleccion = cliente.GetDatabase(baseDatos).GetCollection<UsuarioDocumento>("usuarios");
        }

        public List<UsuarioDocumento> ObtenerActivosPorTipo(int tipo)
        {
            return coleccion.Find(u => u.Tipo == tipo && u.Estado == "activo").ToList();
        }

        public UsuarioDocumento ObtenerPorIdentificacion(string identificacion)
        {
            return coleccion.Find(u => u.Identificacion == identificacion).FirstOrDefault();
        }

        public List<UsuarioDocumento> ObtenerTodos()
        {
            return coleccion.Find(u => true).ToList();
        }

        public void Insertar(UsuarioDocumento usuario)
        {
            coleccion.InsertOne(usuario);
        }

        public void ActualizarDatos(UsuarioDocumento datos)
        {
            var cambios = Builders<UsuarioDocumento>.Update
                .Set(u => u.Nombre, datos.Nombre)
                .Set(u => u.PrimerApellido, datos.PrimerApellido)
                .Set(u => u.SegundoApellido, datos.SegundoApellido)
                .Set(u => u.CorreoElectronico, datos.CorreoElectronico)
                .Set(u => u.Usuario, datos.Usuario)
                .Set(u => u.Contrasena, datos.Contrasena);

            coleccion.UpdateOne(u => u.Identificacion == datos.Identificacion, cambios);
        }

        public void ActualizarEstado(string identificacion, string estado)
        {
            var cambio = Builders<UsuarioDocumento>.Update.Set(u => u.Estado, estado);

            coleccion.UpdateOne(u => u.Identificacion == identificacion, cambio);
        }
    }
}
*/