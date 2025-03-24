
namespace SingularResponsabilityPrincipal.Violacion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Empleado empleados = new Empleado();
            Empleado empleado1 = new Empleado("Juan", 1000);
            Empleado empleado2 = new Empleado("Pedro", 2000);
            Empleado empleado3 = new Empleado("Maria", 3000);
            empleados.agregarEmpleado(empleado1);
            empleados.agregarEmpleado(empleado2);
            empleados.agregarEmpleado(empleado3);
            empleados.imprimirEmpleados();
        }
    }
}
