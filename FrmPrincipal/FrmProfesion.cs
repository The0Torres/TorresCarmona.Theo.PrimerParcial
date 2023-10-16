using Laburos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmProfesion : Form
    {

        private Trabajador trabajador;

        public Trabajador Trabajador
        {
            get { return trabajador; }
        }

        public FrmProfesion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.rbtnPeriodista.Checked)
            {
                FrmPeriodista frmperiodista = new FrmPeriodista();
                DialogResult resultado = frmperiodista.ShowDialog();
                if(resultado == DialogResult.OK)
                {
                    trabajador =  frmperiodista.Periodista;
                    this.DialogResult = DialogResult.OK;
                }
                this.Hide();
            }
            else if (this.rbtnCirujano.Checked)
            {
                FrmCirujano frmcirujano = new FrmCirujano();
                DialogResult resultado = frmcirujano.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    trabajador = frmcirujano.Cirujano;
                    this.DialogResult = DialogResult.OK;
                }
                this.Hide();
            }
            else if (this.rbtnDeportista.Checked)
            {
                FrmDeportista frmdeportista = new FrmDeportista();
                DialogResult resultado = frmdeportista.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    trabajador = frmdeportista.Deportista;
                    this.DialogResult = DialogResult.OK;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un vehiculo",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning
                                        );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
