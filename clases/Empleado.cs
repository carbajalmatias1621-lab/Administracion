using System;

namespace Voluntariado
{
    abstract class Empleado
    {
        public int id;
        public string nombre;
        public string apellido;
        public Empleado(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public abstract void MostrarInfo();
    }
}
