using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace LogInDiseño
{
    internal class AgregarPotreroSQL
    {
        public static void agregarPotrero(string nombre, int hectareas)
        {
            MySqlConnection connection = Conexion.GetConnection();
            string insertQuery = "INSERT INTO potrero(nombre, hectareas) values (@nombre, @hectareas);";

            using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@hectareas", hectareas);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error al ingresar potrero" + e.Message);
                }
                connection.Close();
            }
        }
    }
}
