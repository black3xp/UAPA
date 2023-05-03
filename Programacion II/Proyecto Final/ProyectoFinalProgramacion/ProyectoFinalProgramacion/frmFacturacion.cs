using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProgramacion
{
    public partial class frmFacturacion : Form
    {
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            float totalFactura, totalPrecio;
            totalFactura = 0;

            if (txtCantidad.Text == "" || txtCodigo.Text == "" || txtPrecio.Text == "" || txtProducto.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            decimal number;
            bool isCantidadNumber = decimal.TryParse(txtCantidad.Text, out number);
            bool isPrecioNumber = decimal.TryParse(txtPrecio.Text, out number);

            if (isCantidadNumber && isPrecioNumber)
            {
                totalPrecio = float.Parse(txtCantidad.Text) * float.Parse(txtPrecio.Text);
                totalFactura = totalPrecio;
                dgvProductos.Rows.Add(txtCodigo.Text, txtProducto.Text, txtPrecio.Text, txtCantidad.Text, totalPrecio);
                txtTotalFactura.Text = (float.Parse(txtTotalFactura.Text) + totalFactura).ToString();

                txtCantidad.Clear();
                txtCodigo.Clear();
                txtPrecio.Clear();
                txtProducto.Clear();
            }
            else
            {
                MessageBox.Show("La cantidad y el precio deben ser un numero");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarFila_Click(object sender, EventArgs e)
        {
            float sumaTotalProducto;
            var totalProducto = Convert.ToInt32(dgvProductos.Rows[dgvProductos.CurrentCell.RowIndex].Cells[4].Value != "" ? dgvProductos.Rows[dgvProductos.CurrentCell.RowIndex].Cells[4].Value : 0);

            sumaTotalProducto = float.Parse(txtTotalFactura.Text) - totalProducto;

            txtTotalFactura.Text = sumaTotalProducto.ToString();
            dgvProductos.Rows.RemoveAt(dgvProductos.CurrentCell.RowIndex);
        }
    }
}
