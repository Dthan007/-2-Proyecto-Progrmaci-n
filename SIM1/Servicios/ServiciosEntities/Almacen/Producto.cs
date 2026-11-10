using System.Runtime.Serialization;

namespace ServiciosEntities.Almacen
{
    
        [DataContract]
        public class Producto
        {
            [DataMember]
            public int TipoTransaccion { get; set; }

            [DataMember]
            public string NumeroProducto { get; set; }

            [DataMember]
            public string NombreProducto { get; set; }

            [DataMember]
            public double Precio { get; set; }
        }
    
}
