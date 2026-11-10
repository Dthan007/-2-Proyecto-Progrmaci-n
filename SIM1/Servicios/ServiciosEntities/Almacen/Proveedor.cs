using System.Runtime.Serialization;

namespace ServiciosEntities.Almacen
{
    [DataContract]
    public class Proveedor
    {
        [DataMember]
        public int TipoTransaccion { get; set; }
        [DataMember]
        public string IdJuridica { get; set; } = string.Empty;
        [DataMember]
        public string NombreProveedor { get; set; } = string.Empty;
        [DataMember]
        public string NombreContacto { get; set; } = string.Empty;
        [DataMember]
        public string Telefono { get; set; } = string.Empty;
        [DataMember]
        public string Correo { get; set; } = string.Empty;
        [DataMember]
        public int Estado { get; set; }
    }
}
