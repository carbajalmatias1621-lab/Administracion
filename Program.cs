using System;
using System.Collections.Generic;
using System.Linq;

namespace AdministracionOrganizacionSolidaria
{
    class Program
    {
        private static List<Persona> personas = new List<Persona>();
        private static int nextId = 1;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool running = true;

            while (running)
            {
                MostrarMenuPrincipal();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarVoluntario();
                        break;
                    case "2":
                        RegistrarCoordinador();
                        break;
                    case "3":
                        MostrarTodosLasPersonas();
                        break;
                    case "4":
                        MostrarVoluntarios();
                        break;
                    case "5":
                        MostrarCoordinadores();
                        break;
                    case "6":
                        RegistrarHorasTrabajadas();
                        break;
                    case "7":
                        BuscarPersona();
                        break;
                    case "8":
                        EliminarPersona();
                        break;
                    case "9":
                        running = false;
                        Console.WriteLine("\n¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                if (running && opcion != "9")
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void MostrarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  SISTEMA DE ADMINISTRACIÓN - ORGANIZACIÓN SOLIDARIA     ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n1. Registrar Voluntario");
            Console.WriteLine("2. Registrar Coordinador");
            Console.WriteLine("3. Mostrar Todas las Personas");
            Console.WriteLine("4. Mostrar Voluntarios");
            Console.WriteLine("5. Mostrar Coordinadores");
            Console.WriteLine("6. Registrar Horas Trabajadas (Voluntarios)");
            Console.WriteLine("7. Buscar Persona");
            Console.WriteLine("8. Eliminar Persona");
            Console.WriteLine("9. Salir");
            Console.Write("\nSeleccione una opción: ");
        }

        static void RegistrarVoluntario()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║              REGISTRO DE VOLUNTARIO                    ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝\n");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Documento de Identidad: ");
            string documento = Console.ReadLine();

            Console.Write("Correo Electrónico: ");
            string email = Console.ReadLine();

            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();

            Console.Write("Fecha de Nacimiento (dd/mm/yyyy): ");
            string fechaNacimiento = Console.ReadLine();

            Voluntario voluntario = new Voluntario(
                nextId++,
                nombre,
                apellido,
                documento,
                email,
                telefono,
                fechaNacimiento
            );

            personas.Add(voluntario);
            Console.WriteLine($"\n✓ Voluntario registrado exitosamente con ID: {voluntario.Id}");
        }

        static void RegistrarCoordinador()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║              REGISTRO DE COORDINADOR                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝\n");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Documento de Identidad: ");
            string documento = Console.ReadLine();

            Console.Write("Correo Electrónico: ");
            string email = Console.ReadLine();

            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();

            Console.Write("Fecha de Nacimiento (dd/mm/yyyy): ");
            string fechaNacimiento = Console.ReadLine();

            Console.Write("Área Asignada: ");
            string area = Console.ReadLine();

            Coordinador coordinador = new Coordinador(
                nextId++,
                nombre,
                apellido,
                documento,
                email,
                telefono,
                fechaNacimiento,
                area
            );

            personas.Add(coordinador);
            Console.WriteLine($"\n✓ Coordinador registrado exitosamente con ID: {coordinador.Id}");
        }

        static void MostrarTodosLasPersonas()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║             TODAS LAS PERSONAS REGISTRADAS             ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝\n");

            if (personas.Count == 0)
            {
                Console.WriteLine("No hay personas registradas.");
                return;
            }

            foreach (var persona in personas)
            {
                persona.MostrarInformacion();
                Console.WriteLine();
            }
        }

        static void MostrarVoluntarios()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                  VOLUNTARIOS REGISTRADOS               ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝\n");

            List<Voluntario> voluntarios = personas.OfType<Voluntario>().ToList();

            if (voluntarios.Count == 0)
            {
                Console.WriteLine("No hay voluntarios registrados.");
                return;
            }

            foreach (var voluntario in voluntarios)
            {
                voluntario.MostrarInformacion();
                Console.WriteLine();
            }
        }

        static void MostrarCoordinadores()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                COORDINADORES REGISTRADOS               ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝\n");

            List<Coordinador> coordinadores = personas.OfType<Coordinador>().ToList();

            if (coordinadores.Count == 0)
            {
                Console.WriteLine("No hay coordinadores registrados.");
                return;
            }

            foreach (var coordinador in coordinadores)
            {
                coordinador.MostrarInformacion();
                Console.WriteLine();
            }
        }

        static void RegistrarHorasTrabajadas()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║            REGISTRAR HORAS TRABAJADAS                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝\n");

            List<Voluntario> voluntarios = personas.OfType<Voluntario>().ToList();

            if (voluntarios.Count == 0)
            {
                Console.WriteLine("No hay voluntarios registrados.");
                return;
            }

            Console.WriteLine("Voluntarios disponibles:\n");
            for (int i = 0; i < voluntarios.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {voluntarios[i].Nombre} {voluntarios[i].Apellido} (ID: {voluntarios[i].Id})");
            }

            Console.Write("\nSeleccione el número del voluntario: ");
            if (int.TryParse(Console.ReadLine(), out int seleccion) && seleccion > 0 && seleccion <= voluntarios.Count)
            {
                Voluntario voluntario = voluntarios[seleccion - 1];

                Console.Write("Ingrese las horas trabajadas: ");
                if (double.TryParse(Console.ReadLine(), out double horas) && horas > 0)
                {
                    voluntario.RegistrarHorasTrabajadas(horas);
                    Console.WriteLine($"\n✓ {horas} horas registradas para {voluntario.Nombre} {voluntario.Apellido}");
                }
                else
                {
                    Console.WriteLine("❌ Horas inválidas.");
                }
            }
            else
            {
                Console.WriteLine("❌ Selección inválida.");
            }
        }

        static void BuscarPersona()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   BUSCAR PERSONA                       ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝\n");

            Console.Write("Ingrese el nombre o apellido a buscar: ");
            string termino = Console.ReadLine().ToLower();

            List<Persona> resultados = personas.Where(p =>
                p.Nombre.ToLower().Contains(termino) ||
                p.Apellido.ToLower().Contains(termino)
            ).ToList();

            if (resultados.Count == 0)
            {
                Console.WriteLine("❌ No se encontraron resultados.");
                return;
            }

            Console.WriteLine($"\n✓ Se encontraron {resultados.Count} resultado(s):\n");
            foreach (var persona in resultados)
            {
                persona.MostrarInformacion();
                Console.WriteLine();
            }
        }

        static void EliminarPersona()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   ELIMINAR PERSONA                     ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝\n");

            Console.Write("Ingrese el ID de la persona a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Persona persona = personas.FirstOrDefault(p => p.Id == id);

                if (persona != null)
                {
                    Console.Write($"\n¿Desea eliminar a {persona.Nombre} {persona.Apellido}? (s/n): ");
                    if (Console.ReadLine().ToLower() == "s")
                    {
                        personas.Remove(persona);
                        Console.WriteLine("✓ Persona eliminada exitosamente.");
                    }
                }
                else
                {
                    Console.WriteLine("❌ Persona no encontrada.");
                }
            }
            else
            {
                Console.WriteLine("❌ ID inválido.");
            }
        }
    }
}
