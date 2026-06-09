using System;
using System.Collections.Generic;

public class Program
{
    static List<Persona> listaPersonas = new List<Persona>();

    static void Main()
    {
        int opcion = -1;
        do
        {
            Console.WriteLine("SISTEMA DE VOLUNTARIADO");
            Console.WriteLine("1. Agregar voluntario");
            Console.WriteLine("2. Agregar coordinador");
            Console.WriteLine("0. Salir");
            Console.Write("Ingrese una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarVoluntario();
                    break;
                case 2:
                    AgregarCoordinador();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }
            Console.WriteLine();
        } while (opcion != 0);
    }

    static void AgregarVoluntario()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("DNI: ");
        string dni = Console.ReadLine();
        Console.Write("Cantidad de horas trabajadas: ");
        int horas = int.Parse(Console.ReadLine());

        Voluntario voluntario = new Voluntario(nombre, dni, horas);
        listaPersonas.Add(voluntario);
        Console.WriteLine("Voluntario agregado correctamente.");
    }

    static void AgregarCoordinador()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("DNI: ");
        string dni = Console.ReadLine();

        Console.Write("Cuantas areas tiene asignadas? ");
        int cantidadAreas = int.Parse(Console.ReadLine());
        List<string> areas = new List<string>();
        for (int i = 0; i < cantidadAreas; i++)
        {
            Console.Write("Area " + (i + 1) + ": ");
            string area = Console.ReadLine();
            areas.Add(area);
        }

        Console.Write("Cantidad de personas a cargo: ");
        int personasACargo = int.Parse(Console.ReadLine());

        Coordinador coordinador = new Coordinador(nombre, dni, areas, personasACargo);
        listaPersonas.Add(coordinador);
        Console.WriteLine("Coordinador agregado correctamente.");
    }
}
