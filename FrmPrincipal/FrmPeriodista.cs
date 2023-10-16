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
    public partial class FrmPeriodista : FrmPrincipal.FrmTrabajador
    {
        public Laburos.Periodista periodista;


        public FrmPeriodista(Laburos.Periodista perod) : this()
        {
            this.txtNombre.Text = perod.Nombre;
            this.txtApellido.Text = perod.Apellido;
            this.txtSalario.Text = perod.Salario.ToString();
            //this.cmbTipo.Items = perod.Tipo;
            this.txtCredibilidad.Text = perod.Credibilidad.ToString();
            this.txtEspecializacion.Text = perod.Especializacion;
        }

        public FrmPeriodista()
        {
            InitializeComponent();
        }

        private void FrmPeriodista_Load(object sender, EventArgs e)
        {
            cmbMedio.Items.AddRange(Enum.GetNames(typeof(EMedios)));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
