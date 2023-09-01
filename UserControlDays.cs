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
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
            
            
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            mostrarEvento();
        }
        public void days(int numday)
        {
            lblNumDays.Text = numday.ToString();
        }
        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lblNumDays.Text;

            tmrTarea.Start();
            
            
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }
        public bool escrito = false;
        public void mostrarEvento()
        {

            MySqlConnection connection = Conexion.GetConnection();
            string query = "SELECT * FROM calendario where fecha = @fecha";
            string fecha = formMenu.static_year + "-" + formMenu.static_month + "-" + lblNumDays.Text;
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@fecha", fecha);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblTarea.Text = reader["tarea"].ToString();
                escrito = true;
            }
            reader.Dispose();
            cmd.Dispose();
            connection.Close();
            
        }



        private void lblTarea_Click(object sender, EventArgs e)
        {

        }

        private void tmrTarea_Tick(object sender, EventArgs e)
        {
            if (escrito != true)
            {
                mostrarEvento();
            }
            if (escrito == true)
            {
                tmrTarea.Stop();
            }
            Console.WriteLine("Timer en uso");
        }
    }
}
