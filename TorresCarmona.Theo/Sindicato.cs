namespace Laburos
{
    public class Sindicato
    {
        public List<Trabajador> Trabajador = new List<Trabajador>();

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
            Trabajador.Sort((t1, t2) => t1.Nombre.CompareTo(t2.Nombre));
        }

        public void OrdenarPorNombreDescendente()
        {
            Trabajador.Sort((t1, t2) => t2.Nombre.CompareTo(t1.Nombre));
        }

        public void OrdenarPorApellidoAscendente()
        {
            Trabajador.Sort((t1, t2) => t1.Apellido.CompareTo(t2.Apellido));
        }

        public void OrdenarPorApellidoDescendente()
        {
            Trabajador.Sort((t1, t2) => t2.Apellido.CompareTo(t1.Apellido));
        }

        public void OrdenarPorSalarioAscendente()
        {
            Trabajador.Sort((t1, t2) => t1.Salario.CompareTo(t2.Salario));
        }

        public void OrdenarPorSalarioDescendente()
        {
            Trabajador.Sort((t1, t2) => t2.Salario.CompareTo(t1.Salario));
        }

    }
}
