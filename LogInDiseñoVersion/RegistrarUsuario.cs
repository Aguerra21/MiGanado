using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInDiseño
{
    internal class RegistrarUsuario
    {
        public static string GetSHA256Hash(string input) //metodo para encriptar la contraseña
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        //meotodo para insertar usuario con su contraseña encriptada
        public static void insertarUsuario(string nombre, string apellido, int cedula, string email, string contraseña)
        {
            MySqlConnection connection = Conexion.GetConnection();
            string insertQuery = "INSERT INTO usuarios (nombre, apellido, cedula, email, contraseña) VALUES (@nombre, @apellido,@cedula, @email, @contraseña);";

            using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@cedula", cedula);
                command.Parameters.AddWithValue("@email", email);

                string contraseñaEncriptada = GetSHA256Hash(contraseña);
                command.Parameters.AddWithValue("@contraseña", contraseñaEncriptada);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error al ingresar usuario" + e.Message);
                }
                connection.Close();
            }
        }
    }
}
