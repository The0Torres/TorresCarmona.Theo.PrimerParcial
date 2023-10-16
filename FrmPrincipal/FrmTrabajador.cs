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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmPrincipal
{
    public partial class FrmTrabajador : Form
    {
        public FrmTrabajador()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTrabajador_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.AddRange(Enum.GetNames(typeof(ETipo)));
        }
    }
}
