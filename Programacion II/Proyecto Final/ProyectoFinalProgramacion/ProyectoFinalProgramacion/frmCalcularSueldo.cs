using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinalProgramacion
{
    public partial class frmCalcularSueldo : Form
    {
        public frmCalcularSueldo()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAfp.Clear();
            txtArs.Clear();
            txtCooperativa.Clear();
            txtIsr.Clear();
            txtSueldoBruto.Clear();
            txtSueldoNeto.Clear();
            txtTotalDescuentos.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCalcularSueldo_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSueldoBruto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSueldoBruto.Text))
            {
                decimal number;
                bool result = decimal.TryParse(txtSueldoBruto.Text, out number);

                if (result)
                {
                    txtSueldoBruto.Text = number.ToString("N0");
                    txtSueldoBruto.SelectionStart = txtSueldoBruto.Text.Length;
                    txtSueldoBruto.SelectionLength = 0;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            const float afp = 0.07F;
            const float ars = 0.03F;
            const float cooperativa = 0.02F;
            float isr = 0.00F, totalAFP, totalARS, totalCooperativa, totalISR, totalDescuentos;

            if (!string.IsNullOrEmpty(txtSueldoBruto.Text))
            {
                decimal number;
                bool isNumber = decimal.TryParse(txtSueldoBruto.Text, out number);

                if (isNumber)
                {
                    float sueldoBruto = float.Parse(txtSueldoBruto.Text);
                    if(sueldoBruto <= 34334)
                    {
                        isr = 0.00F;
                    }
                    if(sueldoBruto >= 34334 && sueldoBruto <= 50000)
                    {
                        isr = 0.15F;
                    }
                    if(sueldoBruto >= 51000 && sueldoBruto <= 100000)
                    {
                        isr = 0.20F;
                    }
                    if(sueldoBruto > 100000)
                    {
                        isr = 0.25F;
                    }
                    totalAFP = sueldoBruto * afp;
                    totalARS = sueldoBruto * ars;
                    totalCooperativa = sueldoBruto * cooperativa;
                    totalISR = sueldoBruto * isr;
                    totalDescuentos = totalAFP + totalARS + totalCooperativa + totalISR;

                    txtAfp.Text = totalAFP.ToString();
                    txtArs.Text = totalARS.ToString();
                    txtCooperativa.Text = totalCooperativa.ToString();
                    txtIsr.Text = totalISR.ToString();
                    txtTotalDescuentos.Text = totalDescuentos.ToString();
                    txtSueldoNeto.Text = (sueldoBruto - totalDescuentos).ToString();
                }

                if (!isNumber)
                {
                    MessageBox.Show("Ingrese un numero valido");
                }
            }
        }

        private void txtAfp_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAfp.Text))
            {
                decimal number;
                bool result = decimal.TryParse(txtAfp.Text, out number);

                if (result)
                {
                    txtAfp.Text = number.ToString("N0");
                    txtAfp.SelectionStart = txtAfp.Text.Length;
                    txtAfp.SelectionLength = 0;
                }
            }
        }

        private void txtArs_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArs.Text))
            {
                decimal number;
                bool result = decimal.TryParse(txtArs.Text, out number);

                if (result)
                {
                    txtArs.Text = number.ToString("N0");
                    txtArs.SelectionStart = txtArs.Text.Length;
                    txtArs.SelectionLength = 0;
                }
            }
        }

        private void txtCooperativa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCooperativa.Text))
            {
                decimal number;
                bool result = decimal.TryParse(txtCooperativa.Text, out number);

                if (result)
                {
                    txtCooperativa.Text = number.ToString("N0");
                    txtCooperativa.SelectionStart = txtCooperativa.Text.Length;
                    txtCooperativa.SelectionLength = 0;
                }
            }
        }

        private void txtIsr_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIsr.Text))
            {
                decimal number;
                bool result = decimal.TryParse(txtIsr.Text, out number);

                if (result)
                {
                    txtIsr.Text = number.ToString("N0");
                    txtIsr.SelectionStart = txtIsr.Text.Length;
                    txtIsr.SelectionLength = 0;
                }
            }
        }

        private void txtSueldoNeto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSueldoNeto.Text))
            {
                decimal number;
                bool result = decimal.TryParse(txtSueldoNeto.Text, out number);

                if (result)
                {
                    txtSueldoNeto.Text = number.ToString("N0");
                    txtSueldoNeto.SelectionStart = txtSueldoNeto.Text.Length;
                    txtSueldoNeto.SelectionLength = 0;
                }
            }
        }

        private void txtTotalDescuentos_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotalDescuentos.Text))
            {
                decimal number;
                bool result = decimal.TryParse(txtTotalDescuentos.Text, out number);

                if (result)
                {
                    txtTotalDescuentos.Text = number.ToString("N0");
                    txtTotalDescuentos.SelectionStart = txtTotalDescuentos.Text.Length;
                    txtTotalDescuentos.SelectionLength = 0;
                }
            }
        }
    }
}
