
public class Tienda_DM
{

    // Constructor Tienda_DM()
    public Tienda_DM()
    {

    }

    private int BuscaProducto()
    {
        return 0;
    }

    public void BuscaDisco()
    {

    }

    public void BuscaPelicula()
    {

    }

    public float CompraPelicula(int numEjemplares)
    {
        return 0;
    }

    public float CompraDisco(int numEjemplares)
    {
        return 0;
    }
}

// Interface

interface ICliente
{
    public int AplicaDescuento(Producto producto )
    {
        return 0;
    }

    public bool Pagar (float Cantidad)
    {
        return true;
    }
}

// Relación de Implementación / Realización ente Cliente_Registrado y la interfaz ICliente
class Cliente_Registrado
{
    private string? Nombre { get; set; }
    private string? Apellidos { get; set; }
    private string? DNI_NIF { get; set; }
    private string? Telefono { get; set; }
    private float Saldo { get; set; }
    private int Descuento { get; set; } = 2;

    public bool valida_Dni()
    {
        return true;
    }

    public bool es_Vip()
    {
        return true;
    }

    private void actualizaDescuento()
    {

    }

}

class Cliente_No_Registrado
{
    // Un cliente no registrado, solo puede
    // obtener descuentos si el producto tiene
    // descuento
}


public abstract class Producto
{
    protected string? Titulo { get; set; }
    protected float precio { get; set; }
    protected int AnoPublicacion { get; set; }
    protected int DescuentoProducto { get; set; }

    public int ObtenerDescuento()
    {
        return DescuentoProducto;
    }
}

class Disco : Producto
{
    protected string? Grupo { get; set; }
    protected int Stock { get; set; }
    protected Genero_Musica genero;

    new Disco miDisco = new Disco();
    
}

class Pelicula : Producto
{
    protected string? Director { get; set; }
    protected Genero_Pelicula genero;

    
}

public enum Genero_Musica
{
    Rock,
    Metal,
    Grunge,
    Punk,
}

public enum Genero_Pelicula
{
    Ciencia_Ficcion,
    Comedia,
    Drama,
    Terror,
}

class Program
{
    static void main(string[] args)
    {

    }
}
