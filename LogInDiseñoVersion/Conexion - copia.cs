using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInDiseño
{
    
    internal class Conexion
    {
        private static MySqlConnection conexion;
        public static MySqlConnection GetConnection()
        {
            
            conexion = null;
            try
            {
                string connectionString = "Server=localhost; Database=proyecto; Uid=root; Pwd= Sqlporsiempre!.ñ;"; //hay que cambiar pwd desde pc
                conexion = new MySqlConnection(connectionString);
                conexion.Open();
                //MessageBox.Show("Se conecto");
            } catch (MySqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return conexion;
        }
    }
}
