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
    public partial class FormAgregarPotrero : Form
    {
        public FormAgregarPotrero()
        {
            InitializeComponent();
            Panel borderPanel = new Panel();
            borderPanel.BringToFront();
            borderPanel.BackColor = Color.Black;
            borderPanel.Height = 1;
            borderPanel.Dock = DockStyle.Bottom;
            txtNombrePotrero.Controls.Add(borderPanel);

            Panel borderPanel2 = new Panel();
            borderPanel2.BringToFront();
            borderPanel2.BackColor = Color.Black;
            borderPanel2.Height = 1;
            borderPanel2.Dock = DockStyle.Bottom;
            numHectareasPotrero.Controls.Add(borderPanel2);

        }

        private void btnAgregarPotrero_Click(object sender, EventArgs e)
        {
            string nombre = txtNombrePotrero.Text;
            int hectareas = (int)numHectareasPotrero.Value;
            AgregarPotreroSQL.agregarPotrero(nombre, hectareas);
            txtNombrePotrero.Text = "NOMBRE";
            numHectareasPotrero.Value = 0;
        }

        private void txtNombrePotrero_Click(object sender, EventArgs e)
        {
            if (txtNombrePotrero.Text == "NOMBRE")
            {
                txtNombrePotrero.Text = "";
                txtNombrePotrero.ForeColor = Color.DimGray;
            }
        }

        private void txtNombrePotrero_Leave(object sender, EventArgs e)
        {
            if (txtNombrePotrero.Text == "")
            {
                txtNombrePotrero.Text = "NOMBRE";
                txtNombrePotrero.ForeColor = Color.Black;
            }
        }
    }
}
