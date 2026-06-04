using System;
using System.Collections.Generic;

namespace Voluntariado
{
    class Program
    {
        static List<Voluntario> voluntarios = new List<Voluntario>();
        static List<Coordinador> coordinadores = new List<Coordinador>();
        static int contadorId = 1;

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE VOLUNTARIADO");
                Console.WriteLine("1. Gestion de Voluntarios");
                Console.WriteLine("2. Gestion de Coordinadores");
                Console.WriteLine("0. Salir");
                Console.Write("Elegir opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    MenuVoluntarios();
                }
                else if (opcion == 2)
                {
                    MenuCoordinadores();
                }

            } while (opcion != 0);

            Console.WriteLine("Hasta luego!");
        }
        static void MenuVoluntarios()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("VOLUNTARIOS");
                Console.WriteLine("1. Agregar voluntario");
                Console.WriteLine("4. Eliminar voluntario");
                Console.WriteLine("0. Volver");
                Console.Write("Elegir opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    AgregarVoluntario();
                }
                else if (opcion == 2)
                {
                    VerVoluntarios();
                }

            } while (opcion != 0);
        }

        static void AgregarVoluntario()
        {
            Console.Clear();
            Console.WriteLine("AGREGAR VOLUNTARIO");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Horas trabajadas: ");
            int horas = int.Parse(Console.ReadLine());

            Voluntario v = new Voluntario(nombre, apellido, horas);
            voluntarios.Add(v);
            contadorId++;

            Console.WriteLine("Voluntario agregado correctamente!");
            Console.ReadKey();
        }

        static void VerVoluntarios()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE VOLUNTARIOS");

            if (voluntarios.Count == 0)
            {
                Console.WriteLine("No hay voluntarios cargados.");
            }
            else
            {
                foreach (Voluntario v in voluntarios)
                {
                    v.MostrarInfo();
                }
            }

            Console.ReadKey();
        }
        static void MenuCoordinadores()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("   COORDINADORES");
                Console.WriteLine("1. Agregar coordinador");
                Console.WriteLine("2. Ver todos los coordinadores");
                Console.WriteLine("0. Volver");
                Console.Write("Elegir opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    AgregarCoordinador();
                }
                else if (opcion == 2)
                {
                    VerCoordinadores();
                }
        
            } while (opcion != 0);
        }

        static void AgregarCoordinador()
        {
            Console.Clear();
            Console.WriteLine("AGREGAR COORDINADOR");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Area asignada: ");
            string area = Console.ReadLine();

            Console.Write("Cantidad de personas a cargo: ");
            int personas = int.Parse(Console.ReadLine());

            Coordinador c = new Coordinador(nombre, apellido, area, personas);
            coordinadores.Add(c);

            Console.WriteLine("Coordinador agregado correctamente!");
            Console.ReadKey();
        }

        static void VerCoordinadores()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE COORDINADORES");

            if (coordinadores.Count == 0)
            {
                Console.WriteLine("No hay coordinadores cargados.");
            }
            else
            {
                foreach (Coordinador c in coordinadores)
                {
                    c.MostrarInfo();
                }
            }

            Console.ReadKey();
        }
    }
}
