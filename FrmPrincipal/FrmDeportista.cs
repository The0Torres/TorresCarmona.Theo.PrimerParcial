using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laburos;
using Microsoft.VisualBasic.Devices;

namespace FrmPrincipal
{
    public partial class FrmDeportista : FrmPrincipal.FrmTrabajador
    {
        protected string deporte;

        private Deportista deportista;

        public Deportista Deportista
        {
            get { return deportista; }
        }

        public FrmDeportista()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            if (!int.TryParse(this.txtTrofeos.Text, out int trofeos))
            {
                MessageBox.Show("Ingrese una cantidad de trofeos.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(this.txtRanking.Text, out int ranking))
            {
                MessageBox.Show("Ingrese un ranking mundial.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDeporte.Text))
            {
                MessageBox.Show("Ingrese una especializacion.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                return;
            }

            else
            {

                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                salario = double.Parse(txtSalario.Text);
                tipo = (ETipo)cmbTipo.SelectedItem;
                deporte = txtDeporte.Text;
                deportista = new Deportista(nombre, apellido, salario, tipo, deporte, trofeos, ranking);

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
