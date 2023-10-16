using Laburos;
using System.Collections.Generic;

namespace FrmPrincipal
{
    public partial class FrmSindicato : Form
    {

        Sindicato sindicato = new Sindicato();


        public FrmSindicato()
        {
            InitializeComponent();
        }

        public FrmSindicato(Usuario usuario) : this()
        {
            MessageBox.Show($"Bienvenido/a {usuario.nombre}");
        }

        private void ActualizarVisor()
        {
            this.lstSindicato.Items.Clear();
            foreach (Trabajador trabajador in sindicato.Trabajadores)
            {
                this.lstSindicato.Items.Add(trabajador.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstSindicato.SelectedIndex;

            if (indice == -1)
            {
                MessageBox.Show("Por favor, selecciona un elemento para modificar.", "Elemento no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            FrmProfesion frm1 = new FrmProfesion();
            DialogResult resultado = frm1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Trabajador nuevoTrabajador = frm1.Trabajador;
                sindicato += nuevoTrabajador;
                this.ActualizarVisor();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.lstSindicato.SelectedIndex;

            if (indice == -1)
            {
                MessageBox.Show("Por favor, selecciona un elemento para eliminar.", "Elemento no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Trabajador trabajador = sindicato.Trabajadores[indice];
            sindicato -= trabajador;
            this.ActualizarVisor();

        }
    }
}