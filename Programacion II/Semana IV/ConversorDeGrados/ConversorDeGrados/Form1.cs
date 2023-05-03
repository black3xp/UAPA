namespace ConversorDeGrados
{
    public partial class frmCalcularCF : Form
    {
        public frmCalcularCF()
        {
            InitializeComponent();
        }

        private void frmCalcularCF_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            float celcius, fahrenheit;
            celcius = Convert.ToInt32(txtCelcius.Text);

            fahrenheit = (celcius * 9 / 5) + 32;

            txtFahrenheit.Text = fahrenheit.ToString();
        }
    }
}