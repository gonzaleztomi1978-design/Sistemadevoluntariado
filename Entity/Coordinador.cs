public class Coordinador : Persona
{
    private List<string> areasAsignadas;
    private int cantidadPersonasACargo;

    public List<string> AreasAsignadas { get => areasAsignadas; set => areasAsignadas = value; }
    public int CantidadPersonasACargo { get => cantidadPersonasACargo; set => cantidadPersonasACargo = value; }

    public Coordinador(string nombre, string dni, List<string> areasAsignadas, int cantidadPersonasACargo)
        : base(nombre, dni)
    {
        this.areasAsignadas = areasAsignadas;
        this.cantidadPersonasACargo = cantidadPersonasACargo;
    }

    public override string MostrarInformacion()
    {
        string areas = string.Join(", ", AreasAsignadas);
        return $"Coordinador | Nombre: {Nombre} | DNI: {Dni} | Áreas asignadas: {areas} | Personas a cargo: {CantidadPersonasACargo}";
    }
}
