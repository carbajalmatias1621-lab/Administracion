using System;

namespace Voluntariado
{
    class Voluntario : Empleado
    {
        public int horasTrabajadas;

        public Voluntario(string nombre, string apellido, int horas)
            : base(nombre, apellido)
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
