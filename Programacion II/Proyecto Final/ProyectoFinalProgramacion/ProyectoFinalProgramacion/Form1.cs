using System.Diagnostics.Metrics;

namespace ProyectoFinalProgramacion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cacularSueldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcularSueldo formulario = new frmCalcularSueldo();
            formulario.Show()
;        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturacion formulario = new frmFacturacion();
            formulario.Show();
        }
    }
}