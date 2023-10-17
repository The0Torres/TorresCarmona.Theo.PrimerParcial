using System.Xml.Serialization;

namespace Laburos
{
    [Serializable]
    [XmlInclude(typeof(Cirujano))]
    [XmlInclude(typeof(Deportista))]
    [XmlInclude(typeof(Periodista))]

    public abstract class Trabajador
    {
        protected string nombre;
        protected string apellido;
        protected double salario;
        protected ETipo tipo;

        public string Nombre
        { 
            get { return nombre; }
            set { nombre = value; }        
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }                   
        }

        public double Salario
        { 
            get { return salario; } 
            set { salario = value; }       
        }

        public ETipo Tipo
        { 
            get { return tipo; }
            set { tipo = value; }
        }

        public Trabajador()
        {

        }

        public Trabajador(string Nombre, string Apellido)
        {
            this.nombre = Nombre;
            this.apellido = Apellido;
        }

        public Trabajador(string Nombre, string Apellido, double Salario)
            : this(Nombre, Apellido)
        {
            this.salario = Salario;
        }

        public Trabajador(string Nombre, string Apellido, double Salario, ETipo Tipo)
            : this(Nombre, Apellido, Salario)
        {
            this.tipo = Tipo;
        }

        protected abstract void RealizarTarea();

        public virtual string MostrarDatos()
        {
            return $"{Nombre} {Apellido} - {Tipo} - {Salario}$";
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
            return this.nombre == otroTrabajador.Nombre && this.apellido == otroTrabajador.Apellido;
        }

    }
}