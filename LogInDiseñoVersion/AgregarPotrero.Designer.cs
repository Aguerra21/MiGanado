namespace LogInDiseño
{
    partial class FormAgregarPotrero
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
            this.txtNombrePotrero = new System.Windows.Forms.TextBox();
            this.btnAgregarPotrero = new System.Windows.Forms.Button();
            this.lblAgregarPotrero = new System.Windows.Forms.Label();
            this.numHectareasPotrero = new System.Windows.Forms.NumericUpDown();
            this.pnlAgregarPotrero = new System.Windows.Forms.Panel();
            this.lblHectareas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numHectareasPotrero)).BeginInit();
            this.pnlAgregarPotrero.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombrePotrero
            // 
            this.txtNombrePotrero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.txtNombrePotrero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombrePotrero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePotrero.Location = new System.Drawing.Point(198, 98);
            this.txtNombrePotrero.Name = "txtNombrePotrero";
            this.txtNombrePotrero.Size = new System.Drawing.Size(125, 19);
            this.txtNombrePotrero.TabIndex = 0;
            this.txtNombrePotrero.Text = "NOMBRE";
            this.txtNombrePotrero.Click += new System.EventHandler(this.txtNombrePotrero_Click);
            this.txtNombrePotrero.Leave += new System.EventHandler(this.txtNombrePotrero_Leave);
            // 
            // btnAgregarPotrero
            // 
            this.btnAgregarPotrero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(168)))), ((int)(((byte)(99)))));
            this.btnAgregarPotrero.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPotrero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPotrero.Location = new System.Drawing.Point(194, 169);
            this.btnAgregarPotrero.Name = "btnAgregarPotrero";
            this.btnAgregarPotrero.Size = new System.Drawing.Size(401, 46);
            this.btnAgregarPotrero.TabIndex = 1;
            this.btnAgregarPotrero.Text = "AGREGAR";
            this.btnAgregarPotrero.UseVisualStyleBackColor = false;
            this.btnAgregarPotrero.Click += new System.EventHandler(this.btnAgregarPotrero_Click);
            // 
            // lblAgregarPotrero
            // 
            this.lblAgregarPotrero.AutoSize = true;
            this.lblAgregarPotrero.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarPotrero.Location = new System.Drawing.Point(210, 35);
            this.lblAgregarPotrero.Name = "lblAgregarPotrero";
            this.lblAgregarPotrero.Size = new System.Drawing.Size(399, 27);
            this.lblAgregarPotrero.TabIndex = 2;
            this.lblAgregarPotrero.Text = "AGREGA LOS DATOS DEL POTRERO";
            // 
            // numHectareasPotrero
            // 
            this.numHectareasPotrero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.numHectareasPotrero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numHectareasPotrero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHectareasPotrero.Location = new System.Drawing.Point(532, 98);
            this.numHectareasPotrero.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numHectareasPotrero.Name = "numHectareasPotrero";
            this.numHectareasPotrero.Size = new System.Drawing.Size(63, 22);
            this.numHectareasPotrero.TabIndex = 4;
            // 
            // pnlAgregarPotrero
            // 
            this.pnlAgregarPotrero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAgregarPotrero.Controls.Add(this.lblHectareas);
            this.pnlAgregarPotrero.Controls.Add(this.numHectareasPotrero);
            this.pnlAgregarPotrero.Controls.Add(this.btnAgregarPotrero);
            this.pnlAgregarPotrero.Controls.Add(this.txtNombrePotrero);
            this.pnlAgregarPotrero.Location = new System.Drawing.Point(12, 92);
            this.pnlAgregarPotrero.Name = "pnlAgregarPotrero";
            this.pnlAgregarPotrero.Size = new System.Drawing.Size(785, 295);
            this.pnlAgregarPotrero.TabIndex = 5;
            // 
            // lblHectareas
            // 
            this.lblHectareas.AutoSize = true;
            this.lblHectareas.Location = new System.Drawing.Point(413, 101);
            this.lblHectareas.Name = "lblHectareas";
            this.lblHectareas.Size = new System.Drawing.Size(90, 16);
            this.lblHectareas.TabIndex = 5;
            this.lblHectareas.Text = "HECTÁREAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.lblAgregarPotrero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 86);
            this.panel1.TabIndex = 6;
            // 
            // FormAgregarPotrero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(809, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAgregarPotrero);
            this.MinimumSize = new System.Drawing.Size(823, 446);
            this.Name = "FormAgregarPotrero";
            this.Text = "AgregarPotrero";
            ((System.ComponentModel.ISupportInitialize)(this.numHectareasPotrero)).EndInit();
            this.pnlAgregarPotrero.ResumeLayout(false);
            this.pnlAgregarPotrero.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombrePotrero;
        private System.Windows.Forms.Button btnAgregarPotrero;
        private System.Windows.Forms.Label lblAgregarPotrero;
        private System.Windows.Forms.NumericUpDown numHectareasPotrero;
        private System.Windows.Forms.Panel pnlAgregarPotrero;
        private System.Windows.Forms.Label lblHectareas;
        private System.Windows.Forms.Panel panel1;
    }
}