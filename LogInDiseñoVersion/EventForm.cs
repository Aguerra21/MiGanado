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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LogInDiseño
{
    public partial class EventForm : Form 
    {
        public EventForm()
        {
            InitializeComponent();
            Panel borderPanel = new Panel();
            borderPanel.BackColor = Color.Black;
            borderPanel.Height = 1;
            borderPanel.Dock = DockStyle.Bottom;

            txtFecha.Controls.Add(borderPanel);

            Panel borderPanel2 = new Panel();
            borderPanel2.BackColor = Color.Black;
            borderPanel2.Height = 1;
            borderPanel2.Dock = DockStyle.Bottom;

            txtTarea.Controls.Add(borderPanel2);
        }



        private void EventForm_Load(object sender, EventArgs e)
        {
            txtFecha.Text = formMenu.static_year + "-" + formMenu.static_month + "-" + UserControlDays.static_day;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string tarea = txtTarea.Text;
            string fecha = txtFecha.Text;
            MySqlConnection connection = Conexion.GetConnection();
            string insertQuery = "INSERT INTO calendario(tarea, fecha) VALUES(@tarea, @fecha)";

            using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@tarea", tarea);
                command.Parameters.AddWithValue("@fecha", fecha);
                try
                {
                    command.ExecuteNonQuery();
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al ingresar usuario" + ex.Message);
                }
                command.Dispose();
                connection.Close();
            }
            this.Dispose();
        }
    }
}
