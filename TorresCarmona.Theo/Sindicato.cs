namespace Laburos
{
    public class Sindicato
    {
        private List<Trabajador> trabajadores;

        public List<Trabajador> Trabajadores
        {
            get { return trabajadores; }
        }

        public Sindicato()
        {
            trabajadores = new List<Trabajador>();
        }

        public static Sindicato operator +(Sindicato coleccion, Trabajador trabajador)
        {
            if (!coleccion.trabajadores.Contains(trabajador))
            {
                coleccion.trabajadores.Add(trabajador);
            }
            return coleccion;
        }

        public static Sindicato operator -(Sindicato coleccion, Trabajador trabajador)
        {
            if (coleccion.trabajadores.Contains(trabajador))
            {
                coleccion.trabajadores.Remove(trabajador);
            }
            return coleccion;
        }

        public static bool operator ==(Sindicato coleccion, Trabajador trabajador)
        {
            return coleccion.trabajadores.Contains(trabajador);
        }

        public static bool operator !=(Sindicato coleccion, Trabajador trabajador)
        {
            return !(coleccion == trabajador);
        }

        public void OrdenarPorNombreAscendente()
        {
            trabajadores.Sort((t1, t2) => t1.Nombre.CompareTo(t2.Nombre));
        }

        public void OrdenarPorNombreDescendente()
        {
            trabajadores.Sort((t1, t2) => t2.Nombre.CompareTo(t1.Nombre));
        }

        public void OrdenarPorApellidoAscendente()
        {
            trabajadores.Sort((t1, t2) => t1.Apellido.CompareTo(t2.Apellido));
        }

        public void OrdenarPorApellidoDescendente()
        {
            trabajadores.Sort((t1, t2) => t2.Apellido.CompareTo(t1.Apellido));
        }

        public void OrdenarPorSalarioAscendente()
        {
            trabajadores.Sort((t1, t2) => t1.Salario.CompareTo(t2.Salario));
        }

        public void OrdenarPorSalarioDescendente()
        {
            trabajadores.Sort((t1, t2) => t2.Salario.CompareTo(t1.Salario));
        }

    }
}
