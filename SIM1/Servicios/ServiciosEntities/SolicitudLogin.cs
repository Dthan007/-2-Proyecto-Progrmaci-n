using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Entities
{
    [DataContract]
    public class SolicitudLogin
    {
        [DataMember]
        public string Usuario { get; set; }

        [DataMember]
        public string Contrasena { get; set; }

        [DataMember]
        public string Tipo { get; set; }
    }
}
