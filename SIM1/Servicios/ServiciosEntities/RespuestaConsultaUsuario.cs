
using System.Runtime.Serialization;

namespace Entities
{
    [DataContract]
    public class RespuestaConsultaUsuario : RespuestaServicio
    {
        [DataMember]
        public DatosUsuarioConsulta Usuario { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public int Tipo { get; set; }
    }
}
