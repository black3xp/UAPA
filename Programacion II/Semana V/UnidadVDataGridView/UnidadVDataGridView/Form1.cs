namespace UnidadVDataGridView
{
    public partial class frmEntradaDiario : Form
    {
        public frmEntradaDiario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            float totalDebito, totalCredito;
            totalCredito = 0;
            totalDebito = 0;

            if(txtCuenta.Text == "" || txtMonto.Text == "" || txtNombreCuenta.Text == "" || sltTipo.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }
            
            if(sltTipo.Text == "Debito")
            {
                totalDebito = float.Parse(txtTotalDebito.Text) + float.Parse(txtMonto.Text);
                dgvEntradas.Rows.Add(txtCuenta.Text, txtNombreCuenta.Text, txtMonto.Text, "");
                txtTotalDebito.Text = totalDebito.ToString();
            }

            if (sltTipo.Text == "Credito")
            {
                totalCredito = float.Parse(txtTotalCredito.Text) + float.Parse(txtMonto.Text);
                dgvEntradas.Rows.Add(txtCuenta.Text, txtNombreCuenta.Text, "", txtMonto.Text);
                txtTotalCredito.Text = totalCredito.ToString();
            }

            txtMonto.Clear();
            txtCuenta.Clear();
            txtNombreCuenta.Clear();
            sltTipo.Text = "";
            txtCuenta.Focus();

        }

        private void btnEliminarFila_Click(object sender, EventArgs e)
        {
            int sumaCredito, sumaDebito;
            var debito = Convert.ToInt32(dgvEntradas.Rows[dgvEntradas.CurrentCell.RowIndex].Cells[2].Value != "" ? dgvEntradas.Rows[dgvEntradas.CurrentCell.RowIndex].Cells[2].Value : 0);
            var credito = Convert.ToInt32(dgvEntradas.Rows[dgvEntradas.CurrentCell.RowIndex].Cells[3].Value != "" ? dgvEntradas.Rows[dgvEntradas.CurrentCell.RowIndex].Cells[3].Value : 0);

            sumaCredito = int.Parse(txtTotalCredito.Text) - credito;
            sumaDebito = int.Parse(txtTotalDebito.Text) - debito;

            txtTotalDebito.Text = sumaDebito.ToString();
            txtTotalCredito.Text = sumaCredito.ToString();
            dgvEntradas.Rows.RemoveAt(dgvEntradas.CurrentCell.RowIndex);
        }
    }
}