namespace Laburos
{
    public abstract class Trabajador
    {
        protected string nombre;
        protected string apellido;
        protected double salario;
        protected ETipo tipo;

        public string Nombre
        { get { return nombre; } }

        public string Apellido
        { get { return apellido; } }

        public double Salario
        { get { return salario; } }

        public ETipo Tipo
        { get { return tipo; } }

        public Trabajador(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Trabajador(string nombre, string apellido, double salario)
            : this(nombre, apellido)
        {
            this.salario = salario;
        }

        public Trabajador(string nombre, string apellido, double salario, ETipo tipo)
            : this(nombre, apellido, salario)
        {
            this.tipo = tipo;
        }

        protected abstract void RealizarTarea();

        public virtual string MostrarDatos()
        {
            return $"{nombre} {apellido} - {Tipo} - {salario}$";
        }
        public override string ToString()
        {
            return MostrarDatos();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Trabajador otroTrabajador = (Trabajador)obj;
            return this.nombre == otroTrabajador.nombre && this.apellido == otroTrabajador.apellido;
        }

    }
}