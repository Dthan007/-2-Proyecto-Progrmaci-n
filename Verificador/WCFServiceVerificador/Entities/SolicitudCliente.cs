using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class SolicitudCliente
    {
        [DataMember]
        public string TipoTransaccion {  get; set; }
        [DataMember]
        public string Identificacion { get; set; }
        [DataMember]
        public string PaisOrigen { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string PrimerApellido { get; set; }

        [DataMember]
        public string SegundoApellido { get; set; }

        [DataMember]
        public string CorreoElectronico { get; set; }

        [DataMember]
        public string Telefono { get; set; }

        [DataMember]
        public string Direccion { get; set; }
    }
}
