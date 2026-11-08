using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Documento de Mongo convertido a una clase de C#
// BsonElement enlaza una propiedad con el nombre del campo
namespace BLL
{
    [BsonIgnoreExtraElements]
    public class UsuarioDocumento
    {

        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("identificacion")]
        public string Identificacion { get; set; }


        [BsonElement("nombre")]
        public string Nombre { get; set; }


        [BsonElement("primerApellido")]
        public string PrimerApellido { get; set; }


        [BsonElement("segundoApellido")]
        public string SegundoApellido { get; set; }


        [BsonElement("correoElectronico")]
        public string CorreoElectronico { get; set; }


        [BsonElement("usuario")]
        public string Usuario { get; set; }


        [BsonElement("contrasena")]
        public string Contrasena { get; set; }


        [BsonElement("estado")]
        public string Estado { get; set; }


        [BsonElement("tipo")]
        public int Tipo { get; set; }
    }
}
