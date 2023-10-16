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

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProfesion frm1 = new FrmProfesion();
            DialogResult resultado = frm1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                this.lstSindicato.Items.Add(frm1.Trabajador.ToString());
                sindicato += frm1.Trabajador;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}