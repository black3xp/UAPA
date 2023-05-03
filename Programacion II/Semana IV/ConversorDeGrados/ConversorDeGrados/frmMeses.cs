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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {
            lblMes.Text = "";
            for(int i = 1; i <= 12; i++)
            {
                sltNumeroMes.Items.Add(i);
            }
        }

        private void sltNumeroMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mes;
            mes = sltNumeroMes.Text;

            switch (mes)
            {
                case "1":
                    lblMes.Text = "Enero";
                    break;
                case "2":
                    lblMes.Text = "Febrero";
                    break;
                case "3":
                    lblMes.Text = "Marzo";
                    break;
                case "4":
                    lblMes.Text = "Abril";
                    break;
                case "5":
                    lblMes.Text = "Mayo";
                    break;
                case "6":
                    lblMes.Text = "Junio";
                    break;
                case "7":
                    lblMes.Text = "Julio";
                    break;
                case "8":
                    lblMes.Text = "Agosto";
                    break;
                case "9":
                    lblMes.Text = "Septiembre";
                    break;
                case "10":
                    lblMes.Text = "Octubre";
                    break;
                case "11":
                    lblMes.Text = "Noviembre";
                    break;
                case "12":
                    lblMes.Text = "Diciembre";
                    break;
            }
        }
    }
}
