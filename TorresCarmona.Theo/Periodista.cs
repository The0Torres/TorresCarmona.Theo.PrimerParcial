namespace Laburos
{
    public class Periodista : Trabajador
    {
        public double credibilidad;
        public EMedios medio;
        public string especializacion;

        public Periodista(string nombre, string apellido, double salario, ETipo tipo, string especializacion) 
            :base(nombre, apellido, salario, tipo)
        {
            this.especializacion = especializacion;
        }

        public Periodista(string nombre, string apellido, double salario, ETipo tipo,string especializacion, double credibilidad) 
            :this(nombre, apellido, salario, tipo, especializacion)
        {
            this.credibilidad = credibilidad;
        }

        public Periodista(string nombre, string apellido, double salario, ETipo tipo, string especializacion, double credibilidad, EMedios medio) 
            :this(nombre, apellido, salario, tipo, especializacion, credibilidad)
        {
            this.medio = medio;
        }

        protected override void RealizarTarea()
        {
            Console.WriteLine("Informandose de la actualidad");
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $"Periodista {especializacion} - Medio: {medio} - Credibilidad: {credibilidad}%";
        }


        public static bool operator ==(Periodista periodista1, Periodista periodista2)
        {

            return periodista1.nombre == periodista2.nombre && periodista1.apellido == periodista2.apellido;
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
            return this.nombre == otroperiodista.nombre && this.apellido == otroperiodista.apellido;
        }

    }
}

