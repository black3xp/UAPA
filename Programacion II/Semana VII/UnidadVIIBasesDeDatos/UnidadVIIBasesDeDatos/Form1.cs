using System.Data;
using System.Data.SqlClient;
namespace UnidadVIIBasesDeDatos
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"server=BLACK3XP; database=Ventas; integrated security =true");
            string query = $"select * from Productos where NombreProd like '%{txtNombreProducto.Text}%'";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dgvProductos.DataSource = dataTable;

            connection.Close();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"server=BLACK3XP; database=Ventas; integrated security =true");
            string query = $"select * from Productos";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dgvProductos.DataSource = dataTable;

            connection.Close();
        }
    }
}