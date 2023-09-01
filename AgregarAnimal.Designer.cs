namespace LogInDiseño
{
    partial class FormAgregarAnimal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarAnimal = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidadAnimales = new System.Windows.Forms.NumericUpDown();
            this.lblPotrero = new System.Windows.Forms.Label();
            this.cmbBoxPotreros = new System.Windows.Forms.ComboBox();
            this.grpBoxTipo = new System.Windows.Forms.GroupBox();
            this.rdBtnOvino = new System.Windows.Forms.RadioButton();
            this.rdBtnBovino = new System.Windows.Forms.RadioButton();
            this.rdBtnEquino = new System.Windows.Forms.RadioButton();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbBoxCategorias = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAnimales)).BeginInit();
            this.grpBoxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.lblAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 104);
            this.panel1.TabIndex = 0;
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lblAgregar.Location = new System.Drawing.Point(247, 43);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(280, 27);
            this.lblAgregar.TabIndex = 0;
            this.lblAgregar.Text = "AGREGA LOS ANIMALES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.dateTimeNacimiento);
            this.panel2.Controls.Add(this.btnAgregarAnimal);
            this.panel2.Controls.Add(this.lblCantidad);
            this.panel2.Controls.Add(this.numCantidadAnimales);
            this.panel2.Controls.Add(this.lblPotrero);
            this.panel2.Controls.Add(this.cmbBoxPotreros);
            this.panel2.Controls.Add(this.grpBoxTipo);
            this.panel2.Controls.Add(this.lblCategoria);
            this.panel2.Controls.Add(this.cmbBoxCategorias);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 295);
            this.panel2.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.lblFecha.Location = new System.Drawing.Point(326, 190);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(164, 17);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha de Nacimimiento";
            // 
            // dateTimeNacimiento
            // 
            this.dateTimeNacimiento.Location = new System.Drawing.Point(500, 190);
            this.dateTimeNacimiento.Name = "dateTimeNacimiento";
            this.dateTimeNacimiento.Size = new System.Drawing.Size(207, 23);
            this.dateTimeNacimiento.TabIndex = 7;
            // 
            // btnAgregarAnimal
            // 
            this.btnAgregarAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(168)))), ((int)(((byte)(99)))));
            this.btnAgregarAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAnimal.Location = new System.Drawing.Point(133, 243);
            this.btnAgregarAnimal.Name = "btnAgregarAnimal";
            this.btnAgregarAnimal.Size = new System.Drawing.Size(574, 40);
            this.btnAgregarAnimal.TabIndex = 3;
            this.btnAgregarAnimal.Text = "AGREGAR";
            this.btnAgregarAnimal.UseVisualStyleBackColor = false;
            this.btnAgregarAnimal.Click += new System.EventHandler(this.btnAgregarAnimal_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.lblCantidad.Location = new System.Drawing.Point(326, 146);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(71, 17);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // numCantidadAnimales
            // 
            this.numCantidadAnimales.Location = new System.Drawing.Point(500, 146);
            this.numCantidadAnimales.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCantidadAnimales.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidadAnimales.Name = "numCantidadAnimales";
            this.numCantidadAnimales.Size = new System.Drawing.Size(207, 23);
            this.numCantidadAnimales.TabIndex = 5;
            this.numCantidadAnimales.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPotrero
            // 
            this.lblPotrero.AutoSize = true;
            this.lblPotrero.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.lblPotrero.Location = new System.Drawing.Point(326, 78);
            this.lblPotrero.Name = "lblPotrero";
            this.lblPotrero.Size = new System.Drawing.Size(55, 17);
            this.lblPotrero.TabIndex = 4;
            this.lblPotrero.Text = "Potrero";
            // 
            // cmbBoxPotreros
            // 
            this.cmbBoxPotreros.FormattingEnabled = true;
            this.cmbBoxPotreros.Location = new System.Drawing.Point(329, 98);
            this.cmbBoxPotreros.Name = "cmbBoxPotreros";
            this.cmbBoxPotreros.Size = new System.Drawing.Size(378, 25);
            this.cmbBoxPotreros.TabIndex = 3;
            this.cmbBoxPotreros.TextChanged += new System.EventHandler(this.cmbBoxPotreros_TextChanged);
            this.cmbBoxPotreros.Click += new System.EventHandler(this.cmbBoxPotreros_Click);
            this.cmbBoxPotreros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBoxPotreros_KeyDown);
            // 
            // grpBoxTipo
            // 
            this.grpBoxTipo.Controls.Add(this.rdBtnOvino);
            this.grpBoxTipo.Controls.Add(this.rdBtnBovino);
            this.grpBoxTipo.Controls.Add(this.rdBtnEquino);
            this.grpBoxTipo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.grpBoxTipo.Location = new System.Drawing.Point(133, 25);
            this.grpBoxTipo.Name = "grpBoxTipo";
            this.grpBoxTipo.Size = new System.Drawing.Size(167, 199);
            this.grpBoxTipo.TabIndex = 2;
            this.grpBoxTipo.TabStop = false;
            this.grpBoxTipo.Text = "Tipo";
            // 
            // rdBtnOvino
            // 
            this.rdBtnOvino.AutoSize = true;
            this.rdBtnOvino.Location = new System.Drawing.Point(6, 88);
            this.rdBtnOvino.Name = "rdBtnOvino";
            this.rdBtnOvino.Size = new System.Drawing.Size(75, 24);
            this.rdBtnOvino.TabIndex = 1;
            this.rdBtnOvino.TabStop = true;
            this.rdBtnOvino.Text = "Ovino";
            this.rdBtnOvino.UseVisualStyleBackColor = true;
            this.rdBtnOvino.CheckedChanged += new System.EventHandler(this.radioButtonTipo_CheckedChanged);
            // 
            // rdBtnBovino
            // 
            this.rdBtnBovino.AutoSize = true;
            this.rdBtnBovino.Location = new System.Drawing.Point(6, 34);
            this.rdBtnBovino.Name = "rdBtnBovino";
            this.rdBtnBovino.Size = new System.Drawing.Size(81, 24);
            this.rdBtnBovino.TabIndex = 0;
            this.rdBtnBovino.Text = "Bovino";
            this.rdBtnBovino.UseVisualStyleBackColor = true;
            this.rdBtnBovino.CheckedChanged += new System.EventHandler(this.radioButtonTipo_CheckedChanged);
            // 
            // rdBtnEquino
            // 
            this.rdBtnEquino.AutoSize = true;
            this.rdBtnEquino.Location = new System.Drawing.Point(6, 143);
            this.rdBtnEquino.Name = "rdBtnEquino";
            this.rdBtnEquino.Size = new System.Drawing.Size(79, 24);
            this.rdBtnEquino.TabIndex = 2;
            this.rdBtnEquino.TabStop = true;
            this.rdBtnEquino.Text = "Equino";
            this.rdBtnEquino.UseVisualStyleBackColor = true;
            this.rdBtnEquino.CheckedChanged += new System.EventHandler(this.radioButtonTipo_CheckedChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.lblCategoria.Location = new System.Drawing.Point(326, 20);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 17);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoría";
            // 
            // cmbBoxCategorias
            // 
            this.cmbBoxCategorias.FormattingEnabled = true;
            this.cmbBoxCategorias.Location = new System.Drawing.Point(329, 40);
            this.cmbBoxCategorias.Name = "cmbBoxCategorias";
            this.cmbBoxCategorias.Size = new System.Drawing.Size(378, 25);
            this.cmbBoxCategorias.TabIndex = 0;
            this.cmbBoxCategorias.TextChanged += new System.EventHandler(this.cmbBoxCategorias_TextChanged);
            this.cmbBoxCategorias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBoxCategorias_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormAgregarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 399);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(823, 446);
            this.Name = "FormAgregarAnimal";
            this.Text = "AgregarAnimal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAnimales)).EndInit();
            this.grpBoxTipo.ResumeLayout(false);
            this.grpBoxTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.RadioButton rdBtnEquino;
        private System.Windows.Forms.GroupBox grpBoxTipo;
        private System.Windows.Forms.RadioButton rdBtnOvino;
        private System.Windows.Forms.RadioButton rdBtnBovino;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbBoxCategorias;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblPotrero;
        private System.Windows.Forms.ComboBox cmbBoxPotreros;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidadAnimales;
        private System.Windows.Forms.Button btnAgregarAnimal;
        private System.Windows.Forms.DateTimePicker dateTimeNacimiento;
        private System.Windows.Forms.Label lblFecha;
    }
}