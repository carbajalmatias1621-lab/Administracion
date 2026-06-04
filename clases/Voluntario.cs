using System;

namespace Voluntariado
{
    class Voluntario : Empleado
    {
        public int horasTrabajadas;

        public Voluntario(int id, string nombre, string apellido, int horas)
            : base(id, nombre, apellido)
        {
            this.horasTrabajadas = horas;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("--- Voluntario ---");
            Console.WriteLine("Nombre: " + nombre + " " + apellido);
            Console.WriteLine("Horas trabajadas: " + horasTrabajadas);
            Console.WriteLine();
        }
    }
}
