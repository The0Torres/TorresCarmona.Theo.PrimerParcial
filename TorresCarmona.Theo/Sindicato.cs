namespace Laburos
{
    public class Sindicato
    {
        private List<Trabajador> Trabajador = new List<Trabajador>();

        public static Sindicato operator +(Sindicato coleccion, Trabajador trabajador)
        {
            if (!coleccion.Trabajador.Contains(trabajador))
            {
                coleccion.Trabajador.Add(trabajador);
            }
            return coleccion;
        }

        public static Sindicato operator -(Sindicato coleccion, Trabajador trabajador)
        {
            if (coleccion.Trabajador.Contains(trabajador))
            {
                coleccion.Trabajador.Remove(trabajador);
            }
            return coleccion;
        }

        public static bool operator ==(Sindicato coleccion, Trabajador trabajador)
        {
            return coleccion.Trabajador.Contains(trabajador);
        }

        public static bool operator !=(Sindicato coleccion, Trabajador trabajador)
        {
            return !(coleccion == trabajador);
        }

        public void OrdenarPorNombreAscendente()
        {
            Trabajador.Sort((t1, t2) => t1.nombre.CompareTo(t2.nombre));
        }

        public void OrdenarPorNombreDescendente()
        {
            Trabajador.Sort((t1, t2) => t2.nombre.CompareTo(t1.nombre));
        }

        public void OrdenarPorApellidoAscendente()
        {
            Trabajador.Sort((t1, t2) => t1.apellido.CompareTo(t2.apellido));
        }

        public void OrdenarPorApellidoDescendente()
        {
            Trabajador.Sort((t1, t2) => t2.apellido.CompareTo(t1.apellido));
        }

        public void OrdenarPorSalarioAscendente()
        {
            Trabajador.Sort((t1, t2) => t1.salario.CompareTo(t2.salario));
        }

        public void OrdenarPorSalarioDescendente()
        {
            Trabajador.Sort((t1, t2) => t2.salario.CompareTo(t1.salario));
        }

    }
}
