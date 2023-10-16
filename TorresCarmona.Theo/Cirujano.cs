namespace Laburos
{
    public class Cirujano:Trabajador
    {
        protected int cirugias;
        protected string especialidad;
        protected EHospitales hospital;

        public int Cirugias
        { get { return cirugias; } }

        public EHospitales Hospital
        { get { return hospital; } }

        public string Especialidad
        { get { return especialidad; } }


        public Cirujano(string nombre, string apellido, double salario,ETipo tipo, string especialidad)
            : base(nombre, apellido, salario, tipo)
        {
            this.especialidad = especialidad;
        }

        public Cirujano(string nombre, string apellido, double salario,ETipo tipo ,string especialidad, EHospitales hospital)
            : this(nombre, apellido , salario, tipo, especialidad)
        {
            this.hospital = hospital;
        }

        public Cirujano(string nombre, string apellido, double salario,ETipo tipo ,string especialidad, EHospitales hospital, int cirugias)
            : this(nombre, apellido, salario, tipo, especialidad, hospital)
        {
            this.cirugias = cirugias;
        }

        protected override void RealizarTarea()
        {
            Console.WriteLine("Realizando cirugia a un paciente");
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $" - Cirujano {especialidad} - Cirugías realizadas: {cirugias} - Hospital {Hospital}";
        }


        public static bool operator ==(Cirujano cirujano1, Cirujano cirujano2)
        {

            return cirujano1.nombre == cirujano2.nombre && cirujano1.apellido == cirujano2.apellido;
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
            return this.nombre == otroCirujano.nombre && this.apellido == otroCirujano.apellido;
        }
    }
}
