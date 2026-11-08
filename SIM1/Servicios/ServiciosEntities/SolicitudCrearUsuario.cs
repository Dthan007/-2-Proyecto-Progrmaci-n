using System.Runtime.Serialization;

namespace Entities
{
    [DataContract]
    public class SolicitudCrearUsuario : DatosUsuario
    {
        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public string Tipo { get; set; }
    }
}