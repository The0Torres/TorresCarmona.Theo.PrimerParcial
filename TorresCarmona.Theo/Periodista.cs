namespace Laburos
{
    [Serializable]
    public class Periodista : Trabajador
    {
        protected double credibilidad;
        protected EMedios medio;
        protected string especializacion;

        public double Credibilidad
        { 
            get { return credibilidad; } 
            set { credibilidad = value;}
        }

        public EMedios Medio
        { 
            get { return medio; }
            set { medio = value; }
        }

        public string Especializacion
        { 
            get { return especializacion; }
            set { especializacion = value;}
        }
        public Periodista()
        {

        }

        public Periodista(string Nombre, string Apellido, double Salario, ETipo Tipo, string Especializacion) 
            :base(Nombre, Apellido, Salario, Tipo)
        {
            this.especializacion = Especializacion;
        }

        public Periodista(string Nombre, string Apellido, double Salario, ETipo Tipo,string Especializacion, double Credibilidad) 
            :this(Nombre, Apellido, Salario, Tipo, Especializacion)
        {
            this.credibilidad = Credibilidad;
        }

        public Periodista(string Nombre, string Apellido, double Salario, ETipo Tipo, string Especializacion, double Credibilidad, EMedios Medio) 
            :this(Nombre, Apellido, Salario, Tipo, Especializacion, Credibilidad)
        {
            this.medio = Medio;
        }

        protected override void RealizarTarea()
        {
            Console.WriteLine("Informandose de la actualidad");
        }

        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + $" - Periodista {Especializacion} - Medio: {Medio} - Credibilidad: {Credibilidad}%";
        }


        public static bool operator ==(Periodista periodista1, Periodista periodista2)
        {

            return periodista1.Nombre == periodista2.Nombre && periodista1.Apellido == periodista2.Apellido;
        }

        public static bool operator !=(Periodista periodista1, Periodista periodista2)
        {
            return !(periodista1 == periodista2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Periodista otroperiodista = (Periodista)obj;
            return this.Nombre == otroperiodista.Nombre && this.Apellido == otroperiodista.Apellido;
        }

    }
}

