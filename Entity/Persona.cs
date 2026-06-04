public abstract class Persona
{
    private string nombre;
    private string dni;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Dni { get => dni; set => dni = value; }
    public Persona(string nombre, string dni)
    {
        this.Nombre = nombre;
        this.Dni = dni;
    }
}