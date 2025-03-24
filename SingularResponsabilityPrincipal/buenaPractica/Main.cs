

namespace SingularResponsabilityPrincipal.buenaPractica
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            GuardarEmpleados guardarEmpleados = new GuardarEmpleados();
            ImprimirEmpleados imprimirEmpleados = new ImprimirEmpleados();

            Empleado empleado1 = new Empleado("Juan", 1000);
            Empleado empleado2 = new Empleado("Pedro", 2000);
            Empleado empleado3 = new Empleado("Maria", 3000);

            guardarEmpleados.agregarEmpleado(empleado1);
            guardarEmpleados.agregarEmpleado(empleado2);
            guardarEmpleados.agregarEmpleado(empleado3);

            imprimirEmpleados.imprimirEmpleados();
        }
    }
}
