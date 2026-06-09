
public abstract class Persona
{
    
    private string nombre;
    private string dni;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Dni { get => dni; set => dni = value; }

   
    protected Persona(string nombre, string dni)
    {
        this.nombre = nombre;
        this.dni = dni;
    }

    
    public abstract string MostrarInformacion();
}
