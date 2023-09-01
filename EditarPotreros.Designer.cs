namespace LogInDiseño
{
    partial class FormEditarPotreros
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEditarPotrero = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dataGridViewPotreros = new System.Windows.Forms.DataGridView();
            this.grpBoxDatos = new System.Windows.Forms.GroupBox();
            this.lblHectareas = new System.Windows.Forms.Label();
            this.numUpDownHectareas = new System.Windows.Forms.NumericUpDown();
            this.txtNombreDatos = new System.Windows.Forms.TextBox();
            this.grpBoxBuscar = new System.Windows.Forms.GroupBox();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPotreros)).BeginInit();
            this.grpBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHectareas)).BeginInit();
            this.grpBoxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.lblEditarPotrero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 110);
            this.panel1.TabIndex = 0;
            // 
            // lblEditarPotrero
            // 
            this.lblEditarPotrero.AutoSize = true;
            this.lblEditarPotrero.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lblEditarPotrero.Location = new System.Drawing.Point(249, 41);
            this.lblEditarPotrero.Name = "lblEditarPotrero";
            this.lblEditarPotrero.Size = new System.Drawing.Size(321, 27);
            this.lblEditarPotrero.TabIndex = 0;
            this.lblEditarPotrero.Text = "EDTAR/ELIMINAR POTREROS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.dataGridViewPotreros);
            this.panel2.Controls.Add(this.grpBoxDatos);
            this.panel2.Controls.Add(this.grpBoxBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 289);
            this.panel2.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(168)))), ((int)(((byte)(99)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(116, 236);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 30);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(168)))), ((int)(((byte)(99)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(18, 236);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 30);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dataGridViewPotreros
            // 
            this.dataGridViewPotreros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPotreros.Location = new System.Drawing.Point(254, 26);
            this.dataGridViewPotreros.Name = "dataGridViewPotreros";
            this.dataGridViewPotreros.ReadOnly = true;
            this.dataGridViewPotreros.RowHeadersWidth = 51;
            this.dataGridViewPotreros.RowTemplate.Height = 24;
            this.dataGridViewPotreros.Size = new System.Drawing.Size(528, 240);
            this.dataGridViewPotreros.TabIndex = 2;
            this.dataGridViewPotreros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPotreros_CellClick);
            // 
            // grpBoxDatos
            // 
            this.grpBoxDatos.Controls.Add(this.lblHectareas);
            this.grpBoxDatos.Controls.Add(this.numUpDownHectareas);
            this.grpBoxDatos.Controls.Add(this.txtNombreDatos);
            this.grpBoxDatos.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.grpBoxDatos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grpBoxDatos.Location = new System.Drawing.Point(12, 82);
            this.grpBoxDatos.Name = "grpBoxDatos";
            this.grpBoxDatos.Size = new System.Drawing.Size(210, 97);
            this.grpBoxDatos.TabIndex = 1;
            this.grpBoxDatos.TabStop = false;
            this.grpBoxDatos.Text = "DATOS";
            // 
            // lblHectareas
            // 
            this.lblHectareas.AutoSize = true;
            this.lblHectareas.Location = new System.Drawing.Point(3, 61);
            this.lblHectareas.Name = "lblHectareas";
            this.lblHectareas.Size = new System.Drawing.Size(73, 17);
            this.lblHectareas.TabIndex = 5;
            this.lblHectareas.Text = "Hectáreas";
            // 
            // numUpDownHectareas
            // 
            this.numUpDownHectareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.numUpDownHectareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUpDownHectareas.Location = new System.Drawing.Point(104, 59);
            this.numUpDownHectareas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDownHectareas.Name = "numUpDownHectareas";
            this.numUpDownHectareas.Size = new System.Drawing.Size(99, 19);
            this.numUpDownHectareas.TabIndex = 2;
            // 
            // txtNombreDatos
            // 
            this.txtNombreDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.txtNombreDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreDatos.Location = new System.Drawing.Point(6, 28);
            this.txtNombreDatos.Name = "txtNombreDatos";
            this.txtNombreDatos.Size = new System.Drawing.Size(197, 16);
            this.txtNombreDatos.TabIndex = 1;
            this.txtNombreDatos.Text = "Nombre";
            this.txtNombreDatos.Leave += new System.EventHandler(this.txtNombreDatos_Leave);
            // 
            // grpBoxBuscar
            // 
            this.grpBoxBuscar.Controls.Add(this.txtNombreBuscar);
            this.grpBoxBuscar.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.grpBoxBuscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grpBoxBuscar.Location = new System.Drawing.Point(12, 16);
            this.grpBoxBuscar.Name = "grpBoxBuscar";
            this.grpBoxBuscar.Size = new System.Drawing.Size(210, 60);
            this.grpBoxBuscar.TabIndex = 0;
            this.grpBoxBuscar.TabStop = false;
            this.grpBoxBuscar.Text = "BUSCAR";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.txtNombreBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreBuscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombreBuscar.Location = new System.Drawing.Point(7, 27);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(197, 16);
            this.txtNombreBuscar.TabIndex = 0;
            this.txtNombreBuscar.Text = "Nombre";
            this.txtNombreBuscar.Click += new System.EventHandler(this.txtNombreBuscar_Click);
            this.txtNombreBuscar.TextChanged += new System.EventHandler(this.txtNombreBuscar_TextChanged);
            this.txtNombreBuscar.Leave += new System.EventHandler(this.txtNombreBuscar_Leave);
            // 
            // FormEditarPotreros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 399);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(823, 446);
            this.Name = "FormEditarPotreros";
            this.Text = "EditarPotreros";
            this.Load += new System.EventHandler(this.EditarPotreros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPotreros)).EndInit();
            this.grpBoxDatos.ResumeLayout(false);
            this.grpBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHectareas)).EndInit();
            this.grpBoxBuscar.ResumeLayout(false);
            this.grpBoxBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEditarPotrero;
        private System.Windows.Forms.GroupBox grpBoxBuscar;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.GroupBox grpBoxDatos;
        private System.Windows.Forms.TextBox txtNombreDatos;
        private System.Windows.Forms.DataGridView dataGridViewPotreros;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblHectareas;
        private System.Windows.Forms.NumericUpDown numUpDownHectareas;
    }
}