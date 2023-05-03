namespace IdiomasTarea
{
    public partial class frmIdioma : Form
    {
        public frmIdioma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnIdiomas.Text == "Ingles")
            {
                lblCodigo.Text = "ID";
                lblNombre.Text = "Name";
                lblApellido.Text = "Last Name";
                lblTelefono.Text = "Phone";

                btnIdiomas.Text = "Español";
            }
            else
            {
                lblCodigo.Text = "Codigo";
                lblNombre.Text = "Nombre";
                lblApellido.Text = "Apellido";
                lblTelefono.Text = "Telefono";

                btnIdiomas.Text = "Ingles";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblCodigo.Text = "Codigo";
            lblNombre.Text = "Nombre";
            lblApellido.Text = "Apellido";
            lblTelefono.Text = "Telefono";
        }
    }
}