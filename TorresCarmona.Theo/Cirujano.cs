namespace Laburos
{

    [Serializable]
    public class Cirujano:Trabajador
    {
        protected double cirugias;
        protected string especialidad;
        protected EHospitales hospital;

        public double Cirugias
        { 
            get { return cirugias; } 
            set { cirugias = value; }
        }

        public EHospitales Hospital
        { 
            get { return hospital; } 
            set { hospital = value; }        
        }

        public string Especialidad
        { 
            get { return especialidad; }
            set { especialidad = value; }
        }
        public Cirujano()
        {

        }

        public Cirujano(string Nombre, string Apellido, double Salario,ETipo Tipo, string Especialidad)
            : base(Nombre, Apellido, Salario, Tipo)
        {
            this.especialidad = Especialidad;
        }

        public Cirujano(string Nombre, string Apellido, double Salario,ETipo Tipo ,string Especialidad, EHospitales Hospital)
            : this(Nombre, Apellido , Salario, Tipo, Especialidad)
        {
            this.hospital = Hospital;
        }

        public Cirujano(string Nombre, string Apellido, double Salario,ETipo Tipo ,string Especialidad, EHospitales Hospital, double Cirugias)
            : this(Nombre, Apellido, Salario, Tipo, Especialidad, Hospital)
        {
            this.cirugias = Cirugias;
        }

        protected override void RealizarTarea()
        {
            Console.WriteLine("Realizando cirugia a un paciente");
        }

        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + $" - Cirujano {Especialidad} - Cirugías realizadas: {Cirugias} - Hospital {Hospital}";
        }


        public static bool operator ==(Cirujano cirujano1, Cirujano cirujano2)
        {

            return cirujano1.Nombre == cirujano2.Nombre && cirujano1.Apellido == cirujano2.Apellido;
        }

        public static bool operator !=(Cirujano cirujano1, Cirujano cirujano2)
        {
            return !(cirujano1 == cirujano2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Cirujano otroCirujano = (Cirujano)obj;
            return this.nombre == otroCirujano.Nombre && this.apellido == otroCirujano.Apellido;
        }
    }
}
