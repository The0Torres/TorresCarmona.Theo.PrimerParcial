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
            MessageBox.Show($"Bienvenido {usuario.nombre}");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}