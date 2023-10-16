using Laburos;
using System.Collections.Generic;

namespace FrmPrincipal
{
    public partial class FrmSindicato : Form
    {

        private List<Trabajador> Trabajadores { get; set; }

        public void ActualizarLista()
        {
            this.lstSindicato.Items.Clear();
            foreach (Trabajador trabajador in Trabajadores)
            {
                lstSindicato.Items.Add(trabajador.MostrarDatos());
            }
        }

        public FrmSindicato()
        {
            InitializeComponent();
            this.Trabajadores = new List<Trabajador>();
        }

        public FrmSindicato(Usuario usuario) : this()
        {
            MessageBox.Show($"Bienvenido/a {usuario.nombre}");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProfesion frm1 = new FrmProfesion();
            frm1.ShowDialog();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}