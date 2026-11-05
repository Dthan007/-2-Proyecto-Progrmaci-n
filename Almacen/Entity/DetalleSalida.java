package Entity;

public class DetalleSalida {
    
    private String noProducto;
    private int cantidad;
 
    public DetalleSalida(
        String noProducto,
        int cantidad)
    {
        this.noProducto = noProducto;
        this.cantidad = cantidad;
    }
 
    public String getNoProducto()
    {
        return noProducto;
    }
 
    public int getCantidad()
    {
        return cantidad;
    }
    
}//DetalleSalida.
