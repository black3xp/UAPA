namespace ConversionMonedas
{
    public partial class frmCalcular : Form
    {
        public frmCalcular()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float cantidad, tasa, totalAPagar;
            cantidad = float.Parse(txtCantidad.Text);
            tasa = float.Parse(txtTasa.Text);

            totalAPagar = cantidad * tasa;

            txtCantidadAPagar.Text = $"{totalAPagar} Pesos";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMoneda.Text = "";
            txtCantidad.Text = "";
            txtCantidadAPagar.Text = "";
            txtTasa.Text = "";
        }
    }
}