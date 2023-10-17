namespace Laburos
{
    [Serializable]
    public class Deportista:Trabajador
    {
        protected string deporte;
        protected int trofeos;
        protected int rankingMundial;

        public int RankingMundial
        { 
            get { return rankingMundial; }
            set { rankingMundial = value; }
        }

        public int Trofeos
        {
            get { return trofeos; }
            set { trofeos = value;}
        }

        public string Deporte
        { 
            get { return deporte; }
            set { deporte = value; }
        }

        public Deportista()
        {

        }

        public Deportista(string Nombre, string Apellido, double Salario, ETipo Tipo, string Deporte) 
            : base(Nombre, Apellido, Salario, Tipo)
        {
            this.deporte = Deporte;
        }

        public Deportista(string Nombre, string Apellido, double Salario, ETipo Tipo, string Deporte, int Trofeos) 
            : this(Nombre, Apellido, Salario, Tipo, Deporte)
        {
            this.trofeos = Trofeos;
        }

        public Deportista(string Nombre, string Apellido, double Salario, ETipo Tipo, string Deporte, int Trofeos, int RankingMundial) 
            : this(Nombre, Apellido, Salario, Tipo, Deporte,Trofeos)
        {
            this.rankingMundial = RankingMundial;
        }

        protected override void RealizarTarea()
        {
            Console.WriteLine("Entrenando para la competicion");
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $" - Deporte: {Deporte} - Trofeos: {Trofeos} - Ranking deportistas: {RankingMundial}";
        }


        public static bool operator ==(Deportista deportista1, Deportista deportista2)
        {
            return deportista1.Nombre == deportista2.Nombre && deportista1.Apellido == deportista2.Apellido;
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
            return this.Nombre == otroDeportista.Nombre && this.Apellido == otroDeportista.Apellido;
        }
    }
}
