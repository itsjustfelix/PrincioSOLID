

namespace SingularResponsabilityPrincipal.Violacion
{
    internal class Empleado
    {
        string nombre { get; set; }
        float sueldo { get; set; }
        public Empleado(string nombre, float sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public Empleado()
        {
        }

        List<Empleado> empleados = new List<Empleado>();

        public void agregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public void imprimirEmpleados()
        {
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Nombre: {empleado.nombre}, Sueldo: {empleado.sueldo}");
            }
        }

    }
}
