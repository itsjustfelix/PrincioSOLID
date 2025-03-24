

namespace SingularResponsabilityPrincipal.buenaPractica
{
    internal class GuardarEmpleados
    {
        List<Empleado> empleados = new List<Empleado>();

        public void agregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public List<Empleado> getEmpleados()
        {
            return empleados;
        }
    }
}
