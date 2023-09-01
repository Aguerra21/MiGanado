using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Drawing.Text;

namespace LogInDiseño
{
    public partial class formLogIn : Form
    {
        private FormRegistro formRegistro;
        int widthPanelLogoDefault;
        int widthPanelUsuarioDefault;
        int heightPanelUsuarioDefault;
        int panelUsuarioLeftDefault;
        int panelUsuarioTopDefault;
        int widthLogoDefault;
        int locationXLogo = 43;
        int locationYLogo = 83;
        bool maximizado = false;
        public formLogIn()
        {

            InitializeComponent();
            CenterToScreen();
            Panel borderPanel = new Panel();
            borderPanel.BackColor = Color.Black;
            borderPanel.Height = 1;
            borderPanel.Dock = DockStyle.Bottom;

            txtCedula.Controls.Add(borderPanel);

            Panel borderPanel2 = new Panel();
            borderPanel2.BackColor = Color.Black;
            borderPanel2.Height = 1;
            borderPanel2.Dock = DockStyle.Bottom;

            txtContraseña.Controls.Add(borderPanel2);

            widthPanelLogoDefault = this.panelLogo.Width;
            widthPanelUsuarioDefault = this.panelUsuario.Width;
            widthLogoDefault = this.picBoxLogo.Width;
            heightPanelUsuarioDefault = this.panelUsuario.Height;
            panelUsuarioTopDefault = this.panelUsuario.Top;
            panelUsuarioLeftDefault = this.panelUsuario.Left;

            this.WindowState = FormWindowState.Maximized;   
        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void txtCedula_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "CÉDULA")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.DimGray;
            }
        }
        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "CÉDULA";
                txtCedula.ForeColor = SystemColors.ActiveCaptionText;
            }
        }
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = SystemColors.ActiveCaptionText;
                txtContraseña.UseSystemPasswordChar = false;
                picBoxOcultarContraseña.Visible = false;
                picBoxMostrarContraseña.Visible = true;
            }
        }
        private void formLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void linkLblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //comprueba si no hay un registro abierto
            if (formRegistro == null || formRegistro.IsDisposed)
            {
                formRegistro = new FormRegistro();
                formRegistro.FormClosed += FormRegistro_FormClosed;
            }
            formRegistro.Show(); //muestra el form registro
            this.Hide(); //oculta el login
        }
        private void FormRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            formRegistro = null; //vuelve null el registro
            this.Show(); //muestra el log in
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int cedula;
            int.TryParse(txtCedula.Text, out cedula);
            string contraseña = txtContraseña.Text;
            MySqlConnection connection = Conexion.GetConnection();

            string query = "SELECT COUNT(*) FROM usuarios WHERE cedula = @cedula AND contraseña = @contraseña"; //consulta para ver si existe una fila con eso datos
            //devuelve valor numerico
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@cedula", cedula);
                string contraseñaEncriptada = RegistrarUsuario.GetSHA256Hash(contraseña);//encriptar lo que ingrese para comparar
                command.Parameters.AddWithValue("@contraseña", contraseñaEncriptada);

                try
                {

                    int count = Convert.ToInt32(command.ExecuteScalar()); //obtinene el resutlado de la consulta y los pasa a int como count
                    if (count > 0) //si es mayor que 0, el registro existe
                    {
                        //abre form menu
                        formMenu formMenu = new formMenu();
                        formMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al iniciar sesion: " + ex.Message);
                }
            }
            connection.Close();

        }
        private void picBoxMostrarContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "CONTRASEÑA" && txtContraseña.Text != "")
            {
                txtContraseña.UseSystemPasswordChar = false;
                picBoxOcultarContraseña.Visible = true;
                picBoxMostrarContraseña.Visible = false;
            }
        }
        private void picBoxOcultarContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "CONTRASEÑA" && txtContraseña.Text != "")
            {
                txtContraseña.UseSystemPasswordChar = true;
                picBoxMostrarContraseña.Visible = true;
                picBoxOcultarContraseña.Visible = false;
            }
        }
        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.Handled = true;
            }
        }

        
        private Dictionary<Control, Size> tamañosOriginales = new Dictionary<Control, Size>();
        private Dictionary<Control, Point> posicionesOriginales = new Dictionary<Control, Point>();
        private Dictionary<Control, Font> fuentesOriginales = new Dictionary<Control, Font>();

        private void formLogIn_Resize(object sender, EventArgs e)
        {
            if (maximizado)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    RestaurarTamañoElementos(panelUsuario);
                    RestaurarTextoElementos(panelUsuario);

                    panelLogo.Width = widthPanelLogoDefault;
                    panelUsuario.Width = widthPanelUsuarioDefault;
                    panelUsuario.Top = panelUsuarioTopDefault;
                    panelUsuario.Left = panelUsuarioLeftDefault;

                    picBoxLogo.Width = widthLogoDefault;
                    picBoxLogo.Height = widthLogoDefault;
                    picBoxLogo.Location = new Point(locationXLogo, locationYLogo);
                }
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizado = true;
                AjustarTamañoElementos(panelUsuario, 2);
                AjustarTextoElementos(panelUsuario, 2);

                panelUsuario.Height = heightPanelUsuarioDefault * 2;
                panelUsuario.Width = widthPanelUsuarioDefault * 2;
                panelUsuario.Left = panelUsuarioLeftDefault * 2 + panelLogo.Width;
                panelUsuario.Top = picBoxLogo.Top;

                panelLogo.Width = widthPanelLogoDefault * 2;
                picBoxLogo.Width = widthLogoDefault * 2;
                picBoxLogo.Height = widthLogoDefault * 2;
                picBoxLogo.Location = new Point(locationXLogo * 2, locationYLogo * 3);
            }
        }
        private void AjustarTamañoElementos(Control control, int factor)
        {
            foreach (Control subControl in control.Controls)
            {
                // Guardar el tamaño original y la posición original del control si aún no se han guardado
                if (!tamañosOriginales.ContainsKey(subControl))
                {
                    tamañosOriginales[subControl] = subControl.Size;
                }
                if (!posicionesOriginales.ContainsKey(subControl))
                {
                    posicionesOriginales[subControl] = subControl.Location;
                }

                // Ajustar el tamaño del control según el factor especificado
                subControl.Width = tamañosOriginales[subControl].Width * factor;
                subControl.Height = tamañosOriginales[subControl].Height * factor;

                subControl.Left = posicionesOriginales[subControl].X * factor;
                subControl.Top = posicionesOriginales[subControl].Y * factor;

                // Si el control tiene controles secundarios, ajustar su tamaño recursivamente
                if (subControl.Controls.Count > 0)
                {
                    AjustarTamañoElementos(subControl, factor);
                }
            }
        }
        private void RestaurarTamañoElementos(Control control)
        {
            foreach (Control subControl in control.Controls)
            {
                // Restaurar el tamaño y la posición original del control si se guardaron previamente
                if (tamañosOriginales.ContainsKey(subControl))
                {
                    subControl.Size = tamañosOriginales[subControl];
                }
                if (posicionesOriginales.ContainsKey(subControl))
                {
                    subControl.Location = posicionesOriginales[subControl];
                }

                // Restaurar el tamaño de fuente original del control si se guardó previamente
                if (fuentesOriginales.ContainsKey(subControl))
                {
                    subControl.Font = fuentesOriginales[subControl];
                }

                // Si el control tiene controles secundarios, restaurar su tamaño recursivamente
                if (subControl.Controls.Count > 0)
                {
                    RestaurarTamañoElementos(subControl);
                }
            }
        }
        private void AjustarTextoElementos(Control control, int factor)
        {
            foreach (Control subControl in control.Controls)
            {
                // Guardar la fuente original del control si aún no se ha guardado
                if (!fuentesOriginales.ContainsKey(subControl))
                {
                    fuentesOriginales[subControl] = subControl.Font;
                }

                // Ajustar el tamaño de fuente del control según el factor especificado
                subControl.Font = new Font(subControl.Font.FontFamily, subControl.Font.Size * factor, subControl.Font.Style);

                // Si el control tiene controles secundarios, ajustar su tamaño de fuente recursivamente
                if (subControl.Controls.Count > 0)
                {
                    AjustarTextoElementos(subControl, factor);
                }
            }
        }

        private void RestaurarTextoElementos(Control control)
        {
            foreach (Control subControl in control.Controls)
            {
                // Restaurar el tamaño de fuente original del control si se guardó previamente
                if (fuentesOriginales.ContainsKey(subControl))
                {
                    subControl.Font = fuentesOriginales[subControl];
                }

                // Si el control tiene controles secundarios, restaurar su tamaño de fuente recursivamente
                if (subControl.Controls.Count > 0)
                {
                    RestaurarTextoElementos(subControl);
                }
            }
        }

        
    }
}