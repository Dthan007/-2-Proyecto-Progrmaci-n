using System.Runtime.Serialization;

namespace Entities
{
    [DataContract]
    public class RespuestaServicio
    {
        [DataMember]
        public bool Resultado { get; set; }

        [DataMember]
        public string Mensaje { get; set; }
    }
}
