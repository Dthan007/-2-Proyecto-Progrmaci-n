package Entity;  

public class NuevoProducto
{
    private int transaccion;
    private String producto;
    private String nombre; 
    private double precio;

    public NuevoProducto (int transaccion, String producto, String nombre, double precio)
    {
        this.transaccion = transaccion;
        this.producto = producto;
        this.nombre = nombre; 
        this.precio = precio;
    }

    public int getTransaccion()
    {return transaccion;}

    public String getProducto()
    {return producto;}

    public String getNombre()
    {return nombre;}

    public double getPrecio()
    {return precio;}

}//Producto. 



