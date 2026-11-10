using System.Runtime.Serialization;

namespace ServiciosEntities.Almacen
{
    [DataContract]
    public class Compra //Los nombres de las propiedades no pueden ser iguales a los
                        //nombres de las columnas de la base de datos, ya que al serializar
                        //el objeto se genera un error. Por eso se agrega un guion bajo al
                        //final del nombre de la propiedad Compra.
    {
        [DataMember]
        public int TipoTransaccion { get; set; }
        [DataMember]
        public string Ingreso { get; set; } = string.Empty;
        [DataMember]
        public string Compra_ { get; set; } = string.Empty;
        [DataMember]
        public string Juridica { get; set; } = string.Empty;
        [DataMember]
        public string NoProducto { get; set; } = string.Empty;
        [DataMember]
        public string Cantidad { get; set; } = string.Empty;
    }
}
