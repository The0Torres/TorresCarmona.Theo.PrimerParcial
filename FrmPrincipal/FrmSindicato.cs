namespace FrmPrincipal
{
    public partial class FrmSindicato : Form
    {
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
            FrmTrabajador frm1 = new FrmTrabajador();
            frm1.ShowDialog();
        }
    }
}