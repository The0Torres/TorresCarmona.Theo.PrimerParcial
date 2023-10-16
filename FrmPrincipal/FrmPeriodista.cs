using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laburos;

namespace FrmPrincipal
{
    public partial class FrmPeriodista : FrmPrincipal.FrmTrabajador
    {

        public string especializacion;
        public EMedios medio;

        private Periodista periodista;

        public Periodista Periodista
        {
            get { return this.periodista; }
        }


        public FrmPeriodista()
        {
            InitializeComponent();
            Array arrayMedio = Enum.GetValues(typeof(EMedios));
            foreach (EMedios medioElegido in arrayMedio)
            {
                this.cmbMedio.Items.Add(medioElegido);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            if (!double.TryParse(this.txtCredibilidad.Text, out double credibilidad))
            {
                MessageBox.Show("Ingrese un porcentaje de credibilidad.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEspecializacion.Text))
            {
                MessageBox.Show("Ingrese una especializacion.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                return;
            }

            if (cmbMedio.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un medio.",
                "Advertencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            }
            else
            {

                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                salario = double.Parse(txtSalario.Text);
                tipo = (ETipo)cmbTipo.SelectedItem;
                especializacion = txtEspecializacion.Text;
                medio = (EMedios)cmbMedio.SelectedItem;
                periodista = new Periodista(nombre, apellido, salario, tipo, especializacion, credibilidad, medio);

                DialogResult = DialogResult.OK;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
