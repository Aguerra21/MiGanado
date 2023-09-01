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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LogInDiseño
{
    public partial class FormAgregarAnimal : Form
    {
        private List<string> categoriasMostradas; // Lista de categorías mostradas
        public FormAgregarAnimal()
        {
            InitializeComponent();
            rdBtnBovino.Checked = true;
            categoriasMostradas = new List<string>();
            dateTimeNacimiento.Format = DateTimePickerFormat.Custom;
            dateTimeNacimiento.CustomFormat = "yyyy-MM-dd";
        }
        ///ELEGIR CATEGORIA
        private void cargarCategorias(string tipoCateogira)
        {
            MySqlConnection connection = Conexion.GetConnection();
            string query = $"SELECT nombre FROM categoria WHERE tipo = '{tipoCateogira}'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    cmbBoxCategorias.Items.Clear();
                    while (reader.Read())
                    {
                        cmbBoxCategorias.Items.Add(reader["nombre"].ToString());
                    }
                }
                Application.DoEvents(); // Actualizar la interfaz gráfica
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorias: " + ex.Message);

            }
        }
        private void radioButtonTipo_CheckedChanged(object sender, EventArgs e)
        {
            cmbBoxCategorias.Text = "";
            if (rdBtnBovino.Checked)
            {
                cargarCategorias("Bovinos");
            }
            else if (rdBtnOvino.Checked)
            {
                cargarCategorias("Ovinos");
            }
            else if (rdBtnEquino.Checked)
            {
                cargarCategorias("Equinos");
            }

        }
        private string GetSelectedTipoCategoria()
        {
            if (rdBtnBovino.Checked)
            {
                return "Bovinos";
            }
            else if (rdBtnOvino.Checked)
            {
                return "Ovinos";
            }
            else if (rdBtnEquino.Checked)
            {
                return "Equinos";
            }

            return string.Empty;
        }
        private void cmbBoxCategorias_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true; // Evitar que las teclas de flecha hacia arriba y hacia abajo seleccionen un elemento
            }
        }

        private void cmbBoxCategorias_TextChanged(object sender, EventArgs e)
        {
            string userInput = cmbBoxCategorias.Text;


            // Realizar una consulta SQL para obtener las categorías que coinciden
            List<string> categoriasMatched = obtenerCategoriasMatched(userInput, GetSelectedTipoCategoria());
            if (categoriasMatched.Count > 0)
            {
                List<object> itemsToRemove = new List<object>();

                foreach (object item in cmbBoxCategorias.Items)
                {
                    if (!categoriasMatched.Contains(item))
                    {
                        itemsToRemove.Add(item);
                    }
                }

                // Remueve los elementos diferentes
                foreach (object item in itemsToRemove)
                {
                    cmbBoxCategorias.Items.Remove(item);
                }

                // Agrega los elementos de categoriasMatched que no estén en cmbBoxCategorias
                foreach (object item in categoriasMatched)
                {
                    if (!cmbBoxCategorias.Items.Contains(item))
                    {
                        cmbBoxCategorias.Items.Add(item);
                    }
                }

                cmbBoxCategorias.DroppedDown = true;
            }
            else
            {
                cmbBoxCategorias.DroppedDown = false;
            }
        }
        private List<string> obtenerCategoriasMatched(string userInput, string nombreCateogoria)
        {
            List<string> categoriasMatched = new List<string>();

            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"
               SELECT c.nombre 
               FROM categoria c
               WHERE c.tipo = @nombreCategoria AND c.nombre LIKE CONCAT(@userInput, '%')";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userInput", userInput);
                command.Parameters.AddWithValue("@nombreCategoria", nombreCateogoria);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categoriasMatched.Add(reader["nombre"].ToString());
                    }
                }
            }
            return categoriasMatched;
        }
        ///ELEGIR POTRERO
        private void cargarPotreros()
        {
            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"SELECT nombre 
            FROM potrero";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    cmbBoxPotreros.Items.Clear();
                    while (reader.Read())
                    {
                        cmbBoxPotreros.Items.Add(reader["nombre"].ToString());
                    }
                }
                Application.DoEvents(); // Actualizar la interfaz gráfica
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar potreros: " + ex.Message);
            }
        }

        private void cmbBoxPotreros_Click(object sender, EventArgs e)
        {
            cargarPotreros();
        }
        private void cmbBoxPotreros_TextChanged(object sender, EventArgs e)
        {
            string userInput = cmbBoxPotreros.Text;


            // Realizar una consulta SQL para obtener las categorías que coinciden
            List<string> potrerosMatched = obtenerPotrerosMatched(userInput);
            if (potrerosMatched.Count > 0)
            {
                List<object> itemsToRemove = new List<object>();

                foreach (object item in cmbBoxPotreros.Items)
                {
                    if (!potrerosMatched.Contains(item))
                    {
                        itemsToRemove.Add(item);
                    }
                }

                foreach (object item in itemsToRemove)
                {
                    cmbBoxPotreros.Items.Remove(item);
                }

                foreach (object item in potrerosMatched)
                {
                    if (!cmbBoxPotreros.Items.Contains(item))
                    {
                        cmbBoxPotreros.Items.Add(item);
                    }
                }

                cmbBoxPotreros.DroppedDown = true;
            }
            else
            {
                cmbBoxPotreros.DroppedDown = false;
            }
        }
        private List<string> obtenerPotrerosMatched(string userInput)
        {
            List<string> potrerosMatched = new List<string>();

            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"
               SELECT nombre 
               FROM potrero
               WHERE nombre LIKE CONCAT(@userInput, '%')";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userInput", userInput);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        potrerosMatched.Add(reader["nombre"].ToString());
                    }
                }
            }
            return potrerosMatched;
        }
        private void cmbBoxPotreros_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true; // Evitar que las teclas de flecha hacia arriba y hacia abajo seleccionen un elemento

            }
        }
        ///AGREGAR A LA BASE DE DATOS EL REGISTRO
        private void btnAgregarAnimal_Click(object sender, EventArgs e)
        {
            bool datosCorrectos = true;
            string tipo = GetSelectedTipoCategoria();
            string categoria = cmbBoxCategorias.Text;
            if (string.IsNullOrEmpty(categoria)) 
            {
                MessageBox.Show("Ingrese una categoria por favor.", MessageBoxIcon.Warning.ToString());
                datosCorrectos = false;
            }
            string potrero = cmbBoxPotreros.Text;
            if (string.IsNullOrEmpty(potrero))
            {
                MessageBox.Show("Ingrese un potrero por favor.", MessageBoxIcon.Warning.ToString());
                datosCorrectos = false;
            }
            int cantidad = (int)numCantidadAnimales.Value;
            DateTime fechaNacimiento = dateTimeNacimiento.Value;

            if (datosCorrectos)
            {
                agregarAnimal(fechaNacimiento, categoria, potrero, cantidad);
                MessageBox.Show("Se han cargado los animales correctamente");
            }
        }
        private void agregarAnimal(DateTime fechaNacimiento, string categoria, string potrero, int cantidad) //agrega animal por animal
        {
            MySqlConnection connection = Conexion.GetConnection();
            string query = $@"
                INSERT INTO animal (fecha_nacimiento, ID_categoria, ID_potrero) 
                VALUES (@fechaNacimiento, (SELECT ID_categoria from categoria c where c.nombre = @categoria),
                (SELECT ID_potrero from potrero p where p.nombre = @potrero))";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                for (int i = 0; i < cantidad; i++)
                {
                    try
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                            cmd.Parameters.AddWithValue("@categoria", categoria);
                            cmd.Parameters.AddWithValue("@potrero", potrero);

                            cmd.ExecuteNonQuery();
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("Error al cargar los animales: " + ex.Message);
                    }
                   
                }
            }
        }
    }
}
