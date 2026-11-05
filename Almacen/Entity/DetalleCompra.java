package Entity;

public class DetalleCompra
{
    private String noProducto;
    private int cantidad;

    public DetalleCompra(
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
}//DetalleCompra.
