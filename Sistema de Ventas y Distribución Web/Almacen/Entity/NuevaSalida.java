package Entity;

import java.util.List;

public class NuevaSalida {
    private String noFactura;
    private String fechaVenta;
    private List<DetalleSalida> detalles;
 
    public NuevaSalida(
        String noFactura,
        String fechaVenta,
        List<DetalleSalida> detalles)
    {
        this.noFactura = noFactura;
        this.fechaVenta = fechaVenta;
        this.detalles = detalles;
    }
 
    public String getNoFactura()
    {
        return noFactura;
    }
 
    public String getFechaVenta()
    {
        return fechaVenta;
    }
 
    public List<DetalleSalida> getDetalles()
    {
        return detalles;
    }
}//NuevaSalida.
