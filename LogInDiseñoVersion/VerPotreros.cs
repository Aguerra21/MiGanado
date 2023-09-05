using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInDiseño
{
    public partial class FormVerPotreros : Form
    {
        public FormVerPotreros()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerPotreros_Load(object sender, EventArgs e)
        {
            string criterioOrden = "p.ID_potrero";
            if (rdBtnHectáreas.Checked)
            {
                criterioOrden = "p.hectareas";
            }
            if (rdBtnAnimales.Checked)
            {
                criterioOrden = "Animales";
            }
            if (rdBtnLimpiarFiltros.Checked)
            {
                criterioOrden = "p.ID_potrero";
            }
            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"
                SELECT p.nombre AS Nombre, p.hectareas AS Hectáreas, COUNT(a.ID_animal) AS Animales
                FROM potrero p
                LEFT JOIN animal a ON p.ID_potrero = a.ID_potrero
                GROUP BY p.ID_potrero
                ORDER BY {criterioOrden} DESC;";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                   dataGridViewPotreros.DataSource = dataTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al ingresar potrero" + ex.Message);
                }
                connection.Close();
            }
        }

        private void rdBtnHectáreas_CheckedChanged(object sender, EventArgs e)
        {
            VerPotreros_Load(this, EventArgs.Empty);
        }

        private void rdBtnAnimales_CheckedChanged(object sender, EventArgs e)
        {
            VerPotreros_Load(this, EventArgs.Empty);
        }

        private void rdBtnUnidadGanadera_CheckedChanged(object sender, EventArgs e)
        {
            VerPotreros_Load(this, EventArgs.Empty);
        }

        private void rdBtnLimpiarFiltros_CheckedChanged(object sender, EventArgs e)
        {
            VerPotreros_Load(this, EventArgs.Empty);
        }
    }
}
