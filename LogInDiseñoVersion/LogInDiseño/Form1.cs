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

namespace LogInDiseño
{
    public partial class FormLogIn : Form
    {
        
        public FormLogIn()
        {
            InitializeComponent();

            Panel borderPanel = new Panel();
            borderPanel.BackColor = Color.Black;
            borderPanel.Height = 1;
            borderPanel.Dock = DockStyle.Bottom;

            txtUsuario.Controls.Add(borderPanel);

            Panel borderPanel2 = new Panel();
            borderPanel2.BackColor = Color.Black;
            borderPanel2.Height = 1;
            borderPanel2.Dock = DockStyle.Bottom;

            txtContraseña.Controls.Add(borderPanel2);

            
        }
        
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void picBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picBoxRestaurar.Visible = false;
            picBoxMaximizar.Visible = true;
        }

        private void picBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBoxMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            picBoxMaximizar.Visible = false;
            picBoxRestaurar.Visible = true;
        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text =="USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = SystemColors.ActiveCaptionText;
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
            if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = SystemColors.ActiveCaptionText;
                txtContraseña.UseSystemPasswordChar = false;
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

        

        private void picBoxLogoS_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picBoxLogoFondo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.Show();
            this.Hide();
        }

        private void btnIngerar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;


        }
    }
}
