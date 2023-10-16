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

namespace FrmPrincipal
{
    public partial class FrmCirujano : FrmPrincipal.FrmTrabajador
    {
        private Cirujano cirujano;

        public Cirujano Cirujano
        {
            get { return cirujano; }
        }

        public FrmCirujano()
        {
            InitializeComponent();
        }
    }
}
