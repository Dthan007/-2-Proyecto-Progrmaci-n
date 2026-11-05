package Entity;

import java.util.List;

public class NuevaCompra
{
    private String noIngreso;
    private String fechaCompra;
    private String idJuridica;
    private List<DetalleCompra> detalles;

    public NuevaCompra(
        String noIngreso,
        String fechaCompra,
        String idJuridica,
        List<DetalleCompra> detalles)
    {
        this.noIngreso = noIngreso;
        this.fechaCompra = fechaCompra;
        this.idJuridica = idJuridica;
        this.detalles = detalles;
    }

    public String getNoIngreso()
    {
        return noIngreso;
    }

    public String getFechaCompra()
    {
        return fechaCompra;
    }

    public String getIdJuridica()
    {
        return idJuridica;
    }

    public List<DetalleCompra> getDetalles()
    {
        return detalles;
    }
}//NuevaCompra
