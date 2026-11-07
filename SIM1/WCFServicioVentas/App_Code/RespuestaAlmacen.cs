
using System.Runtime.Serialization;

[DataContract]
public class RespuestaAlmacen
{
    [DataMember]
    public bool Resultado { get; set; }

    [DataMember]
    public string Mensaje { get; set; }
}
