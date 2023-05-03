using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeGrados
{
    public partial class frmConvertirFC : Form
    {
        public frmConvertirFC()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            float fahrenheit, celcius;
            fahrenheit = Convert.ToInt32(txtFahrenheit.Text);
            celcius = (fahrenheit - 32) * 5 / 9;

            txtCelsius.Text = celcius.ToString();
        }
    }
}
