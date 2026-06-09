public class Voluntario : Persona
{
    private int horasTrabajadas;
    public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }

    public Voluntario(string nombre, string dni, int horasTrabajadas) : base(nombre, dni)
    {
        this.horasTrabajadas = horasTrabajadas;
    }

    public override string MostrarInformacion()
    {
        return $"Voluntario  | Nombre: {Nombre} | DNI: {Dni} | Horas trabajadas: {HorasTrabajadas}";
    }
}
