using System;

public class Program
{
    static List<Persona> listaPersonas = new List<Persona>();
    static void Main()
    {
        do
        {
            Console.WriteLine(@"Ingrese una opción
            1. Calcular Salario
            2. Mostrar horas trabajadas
            3. Mostrar datos del coordinador
            4. Salir");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                        CalcularSalario();
                    break;
                case 2:
                        MostrarHorasTrabajadas();
                    break;
                case 3:
                        MostrarDatosCoordinador();
                    break;
                default:
                        Console.WriteLine("Opcion invalida");
                    break;
            }
        } while (opcion != 4);
    }
}