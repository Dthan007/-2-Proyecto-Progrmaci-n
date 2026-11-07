using System;
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
    }
}
