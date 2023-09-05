using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInDiseño
{
    public partial class FormEditarPotreros : Form
    {
        public FormEditarPotreros()
        {
            InitializeComponent();
            Panel borderPanel = new Panel();
            borderPanel.BringToFront();
            borderPanel.BackColor = Color.Black;
            borderPanel.Height = 1;
            borderPanel.Dock = DockStyle.Bottom;
            txtNombreBuscar.Controls.Add(borderPanel);

            Panel borderPanel1 = new Panel();
            borderPanel1.BringToFront();
            borderPanel1.BackColor = Color.Black;
            borderPanel1.Height = 1;
            borderPanel1.Dock = DockStyle.Bottom;
            txtNombreDatos.Controls.Add(borderPanel1);

            Panel borderPanel2 = new Panel();
            borderPanel2.BringToFront();
            borderPanel2.BackColor = Color.Black;
            borderPanel2.Height = 1;
            borderPanel2.Dock = DockStyle.Bottom;
            //txtHectareasDatos.Controls.Add(borderPanel2);


        }

        private void EditarPotreros_Load(object sender, EventArgs e)
        {
            txtNombreDatos.Enabled = false;
            numUpDownHectareas.Enabled = false; 
            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"
                SELECT p.ID_potrero AS Id, p.nombre AS Nombre, p.hectareas AS Hectáreas, COUNT(a.ID_animal) AS Animales
                FROM potrero p
                LEFT JOIN animal a ON p.ID_potrero = a.ID_potrero
                GROUP BY p.ID_potrero;";

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

        private void txtNombreBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombreBuscar.Text == "Nombre")
            {
                txtNombreBuscar.Text = "";
                txtNombreBuscar.ForeColor = Color.DimGray;
            }
        }

        private void txtNombreBuscar_Leave(object sender, EventArgs e)
        {
            if (txtNombreBuscar.Text == "")
            {
                txtNombreBuscar.Text = "Nombre";
                txtNombreBuscar.ForeColor = Color.Black;

            }
        }

        private void txtNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreBuscar.Text) || txtNombreBuscar.Text == "Nombre") // si vuelve a quedar en blanco muestra todos los potreros
            {
                EditarPotreros_Load(this, EventArgs.Empty);
                return;
            }
            buscarPotreros(txtNombreBuscar.Text); // si cambia el texto llama la funcion
        }

        private void buscarPotreros(string nombreBuscado)
        {
            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"
                SELECT p.ID_potrero AS Id, p.nombre AS Nombre, p.hectareas AS Hectáreas, COUNT(a.ID_animal) AS Animales
                FROM potrero p
                LEFT JOIN animal a ON p.ID_potrero = a.ID_potrero
                WHERE p.nombre LIKE CONCAT(@nombreBuscado, '%')
                GROUP BY p.ID_potrero";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nombreBuscado", nombreBuscado);
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

        private void dataGridViewPotreros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegura que se haya hecho clic en una fila válida
            {
                DataGridViewRow row = dataGridViewPotreros.Rows[e.RowIndex];
                string nombre = row.Cells["Nombre"].Value.ToString();
                string hectareas = row.Cells["Hectáreas"].Value.ToString();
                txtNombreDatos.Enabled = true;
                numUpDownHectareas.Enabled = true;  
                // Llenar los TextBox con los datos
                txtNombreDatos.Text = nombre;
                numUpDownHectareas.Value = int.Parse(hectareas);
            }
        }
        private void txtNombreDatos_Leave(object sender, EventArgs e)
        {
            if (txtNombreDatos.Text == "")
            {
                txtNombreDatos.Text = "Nombre";
                txtNombreDatos.ForeColor = Color.Black;

            }
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPotreros.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPotreros.SelectedRows[0];
                int idPotrero = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nombreNuevo = txtNombreDatos.Text;
                int hectareasNuevo = (int)numUpDownHectareas.Value;
                
                try
                {
                    actualizarEnBaseDeDatosPotrero(idPotrero, nombreNuevo, hectareasNuevo);

                    dataGridViewPotreros.SelectedRows[0].Cells["Nombre"].Value = nombreNuevo;
                    dataGridViewPotreros.SelectedRows[0].Cells["Hectáreas"].Value = hectareasNuevo;
                    EditarPotreros_Load(this, EventArgs.Empty);
                    txtNombreBuscar.Text = "Nombre";
                    txtNombreDatos.Text = "Nombre";
                    numUpDownHectareas.Value = 0;
                    MessageBox.Show("Se guardaron los cambios!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios: " + ex.Message, MessageBoxIcon.Error.ToString());
                }
                   
                
            }
        }
        private void actualizarEnBaseDeDatosPotrero(int idPotrero, string nombreNuevo, int hectareasNuevo)
        {
            MySqlConnection connection = Conexion.GetConnection();
            string query = @"
                        UPDATE potrero
                        SET nombre = @nombreNuevo, hectareas = @hectareasNuevo
                        WHERE ID_potrero = @idPotrero";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nombreNuevo", nombreNuevo);
                command.Parameters.AddWithValue("@hectareasNuevo", hectareasNuevo);
                command.Parameters.AddWithValue("@idPotrero", idPotrero);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPotreros.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPotreros.SelectedRows[0];
                int idPotrero = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                try
                {
                    eliminarPotreroEnBaseDeDatos(idPotrero);
                    dataGridViewPotreros.Rows.Remove(selectedRow);
                    MessageBox.Show("Se ha eliminado correctamente.");
                } catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar el registro" +  ex.Message);
                }
            }
        }

        private void eliminarPotreroEnBaseDeDatos(int idPotrero)
        {
            MySqlConnection connection = Conexion.GetConnection();
            string query = @"
                DELETE FROM potrero
                WHERE ID_potrero = @idPotrero";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idPotrero", idPotrero);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        
    }
}
