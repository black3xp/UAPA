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
    public partial class frmConversorFCSelect : Form
    {
        public frmConversorFCSelect()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string tipo;
            float grados, resultado;

            tipo = sltTipoConversion.Text;
            grados = Convert.ToInt32(txtGrados.Text);

            switch (tipo)
            {
                case "Celsius a Fahrenheit":
                    resultado = (grados * 9 / 5) + 32;

                    txtResultado.Text = resultado.ToString();
                    break;
                case "Fahrenheit a Celsius":
                    resultado = (grados - 32) * 5 / 9;

                    txtResultado.Text = resultado.ToString();
                    break;
            }
        }
    }
}
