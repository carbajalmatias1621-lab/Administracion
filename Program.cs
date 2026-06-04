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
                Console.WriteLine("========================================");
                Console.WriteLine("   SISTEMA DE VOLUNTARIADO");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Gestion de Voluntarios");
                Console.WriteLine("2. Gestion de Coordinadores");
                Console.WriteLine("0. Salir");
                Console.WriteLine("========================================");
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
                Console.WriteLine("========================================");
                Console.WriteLine("   VOLUNTARIOS");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Agregar voluntario");
                Console.WriteLine("2. Ver todos los voluntarios");
                Console.WriteLine("3. Buscar voluntario por ID");
                Console.WriteLine("4. Eliminar voluntario");
                Console.WriteLine("0. Volver");
                Console.WriteLine("========================================");
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
                else if (opcion == 3)
                {
                    BuscarVoluntario();
                }
                else if (opcion == 4)
                {
                    EliminarVoluntario();
                }

            } while (opcion != 0);
        }

        static void AgregarVoluntario()
        {
            Console.Clear();
            Console.WriteLine("--- AGREGAR VOLUNTARIO ---");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Horas trabajadas: ");
            int horas = int.Parse(Console.ReadLine());

            Voluntario v = new Voluntario(contadorId, nombre, apellido, horas);
            voluntarios.Add(v);
            contadorId++;

            Console.WriteLine("Voluntario agregado correctamente!");
            Console.ReadKey();
        }

        static void VerVoluntarios()
        {
            Console.Clear();
            Console.WriteLine("--- LISTA DE VOLUNTARIOS ---");

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

        static void BuscarVoluntario()
        {
            Console.Clear();
            Console.WriteLine("--- BUSCAR VOLUNTARIO ---");
            Console.Write("Ingrese ID: ");
            int id = int.Parse(Console.ReadLine());

            Voluntario encontrado = null;

            foreach (Voluntario v in voluntarios)
            {
                if (v.id == id)
                {
                    encontrado = v;
                }
            }

            if (encontrado != null)
            {
                encontrado.MostrarInfo();
            }
            else
            {
                Console.WriteLine("No se encontro ningun voluntario con ese ID.");
            }

            Console.ReadKey();
        }

        static void EliminarVoluntario()
        {
            Console.Clear();
            Console.WriteLine("--- ELIMINAR VOLUNTARIO ---");
            Console.Write("Ingrese ID del voluntario a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            Voluntario encontrado = null;

            foreach (Voluntario v in voluntarios)
            {
                if (v.id == id)
                {
                    encontrado = v;
                }
            }

            if (encontrado != null)
            {
                voluntarios.Remove(encontrado);
                Console.WriteLine("Voluntario eliminado.");
            }
            else
            {
                Console.WriteLine("No se encontro el voluntario.");
            }

            Console.ReadKey();
        }
        static void MenuCoordinadores()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("   COORDINADORES");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Agregar coordinador");
                Console.WriteLine("2. Ver todos los coordinadores");
                Console.WriteLine("3. Buscar coordinador por ID");
                Console.WriteLine("4. Eliminar coordinador");
                Console.WriteLine("0. Volver");
                Console.WriteLine("========================================");
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
                else if (opcion == 3)
                {
                    BuscarCoordinador();
                }
                else if (opcion == 4)
                {
                    EliminarCoordinador();
                }

            } while (opcion != 0);
        }

        static void AgregarCoordinador()
        {
            Console.Clear();
            Console.WriteLine("--- AGREGAR COORDINADOR ---");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Area asignada: ");
            string area = Console.ReadLine();

            Console.Write("Cantidad de personas a cargo: ");
            int personas = int.Parse(Console.ReadLine());

            Coordinador c = new Coordinador(contadorId, nombre, apellido, area, personas);
            coordinadores.Add(c);
            contadorId++;

            Console.WriteLine("Coordinador agregado correctamente!");
            Console.ReadKey();
        }

        static void VerCoordinadores()
        {
            Console.Clear();
            Console.WriteLine("--- LISTA DE COORDINADORES ---");

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

        static void BuscarCoordinador()
        {
            Console.Clear();
            Console.WriteLine("--- BUSCAR COORDINADOR ---");
            Console.Write("Ingrese ID: ");
            int id = int.Parse(Console.ReadLine());

            Coordinador encontrado = null;

            foreach (Coordinador c in coordinadores)
            {
                if (c.id == id)
                {
                    encontrado = c;
                }
            }

            if (encontrado != null)
            {
                encontrado.MostrarInfo();
            }
            else
            {
                Console.WriteLine("No se encontro ningun coordinador con ese ID.");
            }

            Console.ReadKey();
        }

        static void EliminarCoordinador()
        {
            Console.Clear();
            Console.WriteLine("--- ELIMINAR COORDINADOR ---");
            Console.Write("Ingrese ID del coordinador a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            Coordinador encontrado = null;

            foreach (Coordinador c in coordinadores)
            {
                if (c.id == id)
                {
                    encontrado = c;
                }
            }

            if (encontrado != null)
            {
                coordinadores.Remove(encontrado);
                Console.WriteLine("Coordinador eliminado.");
            }
            else
            {
                Console.WriteLine("No se encontro el coordinador.");
            }

            Console.ReadKey();
        }
    }
}
