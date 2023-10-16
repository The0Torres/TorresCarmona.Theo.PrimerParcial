using Laburos;
using System.Collections.Generic;

namespace FrmPrincipal
{
    public partial class FrmSindicato : Form
    {

        private Sindicato sindicato;

        public Sindicato Sindicato
        {
            get { return sindicato; }
            set { sindicato = value; }
        }

        public FrmSindicato()
        {
            InitializeComponent();
            Sindicato = new Sindicato();
        }

        public FrmSindicato(Usuario usuario) : this()
        {
            MessageBox.Show($"Bienvenido/a {usuario.nombre}");
        }

        private void ActualizarVisor()
        {
            this.lstSindicato.Items.Clear();
            foreach (Trabajador trabajador in Sindicato.Trabajadores)
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
            }
            else
            {
                object trabajador = Sindicato.Trabajadores[indice];

                DialogResult resultado;
                if (trabajador is Periodista)
                {
                    FrmPeriodista frmperiodista = new FrmPeriodista((Periodista)trabajador);

                    resultado = frmperiodista.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        Sindicato.Trabajadores[indice] = frmperiodista.Periodista;
                    }
                }

                else if (trabajador is Cirujano)
                {
                    FrmCirujano frmcirujano = new FrmCirujano((Cirujano)trabajador);

                    resultado = frmcirujano.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        Sindicato.Trabajadores[indice] = frmcirujano.Cirujano;
                    }
                }

                else if (trabajador is Deportista)
                {
                    FrmDeportista frmdeportista = new FrmDeportista((Deportista)trabajador);

                    resultado = frmdeportista.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        Sindicato.Trabajadores[indice] = frmdeportista.Deportista;
                    }
                }

                this.ActualizarVisor();

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            FrmProfesion frm1 = new FrmProfesion();
            DialogResult resultado = frm1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Trabajador nuevoTrabajador = frm1.Trabajador;
                Sindicato += nuevoTrabajador;
                this.ActualizarVisor();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.lstSindicato.SelectedIndex;

            if (indice == -1)
            {
                MessageBox.Show("Por favor, selecciona un elemento para eliminar.", "Elemento no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Trabajador trabajador = Sindicato.Trabajadores[indice];
                Sindicato -= trabajador;
                this.ActualizarVisor();

            }

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Sindicato.OrdenarPorSalarioAscendente();

            this.ActualizarVisor();
        }
    }
}