
using System.Runtime.Serialization;

namespace Entities
{
    [DataContract]
    public class DatosUsuarioConsulta
    {
        [DataMember]
        public string Identificacion { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string PrimerApellido { get; set; }

        [DataMember]
        public string SegundoApellido { get; set; }

        [DataMember]
        public string CorreoElectronico { get; set; }

        [DataMember]
        public string Usuario { get; set; }
    }
}
