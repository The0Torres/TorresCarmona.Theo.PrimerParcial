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

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbTipo.SelectedItem.ToString();
        }

        private void FrmTrabajador_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.AddRange(Enum.GetNames(typeof(ETipo)));
        }
    }
}
