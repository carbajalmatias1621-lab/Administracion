using System;

namespace Voluntariado
{
    class Coordinador : Empleado
    {
        public string area;
        public int personasACargo;

        public Coordinador(string nombre, string apellido, string area, int personasACargo)
            : base(nombre, apellido)
        {
            this.area = area;
            this.personasACargo = personasACargo;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("--- Coordinador ---");
            Console.WriteLine("Nombre: " + nombre + " " + apellido);
            Console.WriteLine("Area asignada: " + area);
            Console.WriteLine("Personas a cargo: " + personasACargo);
            Console.WriteLine();
        }
    }
}
