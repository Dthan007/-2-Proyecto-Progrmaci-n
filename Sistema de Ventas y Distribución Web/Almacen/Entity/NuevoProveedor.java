package Entity;

public class NuevoProveedor 
{
    private int tipoTransaccion;
    private String IDJuridica;
    private String nombreEmpresa;
    private String nombreContacto;
    private String telefono;
    private String correo;
    private int estado;

    public NuevoProveedor(int tipoTransaccion, String IDJuridica, 
        String nombreEmpresa, String nombreContacto, String telefono,
        String correo, int estado)
    {
        this.tipoTransaccion = tipoTransaccion;
        this.IDJuridica = IDJuridica;
        this.nombreEmpresa = nombreEmpresa;
        this.nombreContacto = nombreContacto;
        this.telefono = telefono;
        this.correo = correo;
        this.estado = estado;
    }

    public int getTipoTransaccion()
    {return tipoTransaccion;}

    public String getIDJuridica()
    {return IDJuridica;}

    public String getNombreEmpresa()
    {return nombreEmpresa;}

    public String getNombreContacto()
    {return nombreContacto;}

    public String getTelefono()
    {return telefono;}

    public String getCorreo()
    {return correo;}

    public int getEstado()
    {return estado;}


}//NuevoProveedor
