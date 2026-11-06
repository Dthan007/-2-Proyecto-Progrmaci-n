using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class SolicitudCompra
    {
        [DataMember]
        public string NumeroCompra { get; set; }

        [DataMember]
        public string IdentificacionCliente { get; set; }

        [DataMember]
        public string FechaCompra { get; set; }

        [DataMember]
        public string TotalCompra { get; set; }

        [DataMember]
        public string TarjetaCifrada { get; set; }

        [DataMember]
        public string VencimientoCifrado { get; set; }

        [DataMember]
        public string CvvCifrado { get; set; }

        [DataMember]
        public List<ProductoCompra> Productos { get; set; }
    }
}
