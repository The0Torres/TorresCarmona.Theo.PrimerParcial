namespace Laburos
{
    public class Deportista:Trabajador
    {
        protected string deporte;
        protected int trofeos;
        protected int rankingMundial;

        public int RankingMundial
        { get { return rankingMundial; } }

        public int Trofeos
        { get { return trofeos; } }

        public string Deporte
        { get { return deporte; } }

        public Deportista(string nombre, string apellido, double salario, ETipo tipo, string deporte) 
            : base(nombre, apellido, salario, tipo)
        {
            this.deporte = deporte;
        }

        public Deportista(string nombre, string apellido, double salario, ETipo tipo, string deporte, int trofeos) 
            : this(nombre, apellido, salario, tipo, deporte)
        {
            this.trofeos = trofeos;
        }

        public Deportista(string nombre, string apellido, double salario, ETipo tipo, string deporte, int trofeos, int rankingMundial) 
            : this(nombre, apellido, salario, tipo, deporte,trofeos)
        {
            this.rankingMundial = rankingMundial;
        }

        protected override void RealizarTarea()
        {
            Console.WriteLine("Entrenando para la competicion");
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $" - Deporte: {deporte} - Trofeos: {trofeos} - Ranking deportistas: {rankingMundial}";
        }


        public static bool operator ==(Deportista deportista1, Deportista deportista2)
        {

            return deportista1.nombre == deportista2.nombre && deportista1.apellido == deportista2.apellido;
        }

        public static bool operator !=(Deportista deportista1, Deportista deportista2)
        {
            return !(deportista1 == deportista2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Deportista otroDeportista = (Deportista)obj;
            return this.nombre == otroDeportista.nombre && this.apellido == otroDeportista.apellido;
        }
    }
}
