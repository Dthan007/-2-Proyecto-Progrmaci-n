using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class ProductoCompra
    {
        [DataMember]
        public string CodigoProducto { get; set; }

        [DataMember]
        public string Cantidad { get; set;  }
    }
}
