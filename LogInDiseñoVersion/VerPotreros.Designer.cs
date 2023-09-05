namespace LogInDiseño
{
    partial class FormVerPotreros
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
            this.pnlVerPotreros = new System.Windows.Forms.Panel();
            this.pnlPotreros = new System.Windows.Forms.Panel();
            this.dataGridViewPotreros = new System.Windows.Forms.DataGridView();
            this.grpBoxFiltrar = new System.Windows.Forms.GroupBox();
            this.rdBtnHectáreas = new System.Windows.Forms.RadioButton();
            this.rdBtnAnimales = new System.Windows.Forms.RadioButton();
            this.rdBtnUnidadGanadera = new System.Windows.Forms.RadioButton();
            this.lblVerPotreros = new System.Windows.Forms.Label();
            this.rdBtnLimpiarFiltros = new System.Windows.Forms.RadioButton();
            this.pnlVerPotreros.SuspendLayout();
            this.pnlPotreros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPotreros)).BeginInit();
            this.grpBoxFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVerPotreros
            // 
            this.pnlVerPotreros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.pnlVerPotreros.Controls.Add(this.lblVerPotreros);
            this.pnlVerPotreros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVerPotreros.Location = new System.Drawing.Point(0, 0);
            this.pnlVerPotreros.Name = "pnlVerPotreros";
            this.pnlVerPotreros.Size = new System.Drawing.Size(811, 108);
            this.pnlVerPotreros.TabIndex = 0;
            // 
            // pnlPotreros
            // 
            this.pnlPotreros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.pnlPotreros.Controls.Add(this.grpBoxFiltrar);
            this.pnlPotreros.Controls.Add(this.dataGridViewPotreros);
            this.pnlPotreros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPotreros.Location = new System.Drawing.Point(0, 108);
            this.pnlPotreros.Name = "pnlPotreros";
            this.pnlPotreros.Size = new System.Drawing.Size(811, 294);
            this.pnlPotreros.TabIndex = 0;
            // 
            // dataGridViewPotreros
            // 
            this.dataGridViewPotreros.AllowUserToAddRows = false;
            this.dataGridViewPotreros.AllowUserToDeleteRows = false;
            this.dataGridViewPotreros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPotreros.Location = new System.Drawing.Point(13, 14);
            this.dataGridViewPotreros.Name = "dataGridViewPotreros";
            this.dataGridViewPotreros.ReadOnly = true;
            this.dataGridViewPotreros.RowHeadersWidth = 51;
            this.dataGridViewPotreros.RowTemplate.Height = 24;
            this.dataGridViewPotreros.Size = new System.Drawing.Size(553, 220);
            this.dataGridViewPotreros.TabIndex = 0;
            this.dataGridViewPotreros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grpBoxFiltrar
            // 
            this.grpBoxFiltrar.Controls.Add(this.rdBtnLimpiarFiltros);
            this.grpBoxFiltrar.Controls.Add(this.rdBtnUnidadGanadera);
            this.grpBoxFiltrar.Controls.Add(this.rdBtnAnimales);
            this.grpBoxFiltrar.Controls.Add(this.rdBtnHectáreas);
            this.grpBoxFiltrar.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.grpBoxFiltrar.Location = new System.Drawing.Point(572, 14);
            this.grpBoxFiltrar.Name = "grpBoxFiltrar";
            this.grpBoxFiltrar.Size = new System.Drawing.Size(200, 145);
            this.grpBoxFiltrar.TabIndex = 1;
            this.grpBoxFiltrar.TabStop = false;
            this.grpBoxFiltrar.Text = "Filtrar por:";
            // 
            // rdBtnHectáreas
            // 
            this.rdBtnHectáreas.AutoSize = true;
            this.rdBtnHectáreas.Location = new System.Drawing.Point(6, 31);
            this.rdBtnHectáreas.Name = "rdBtnHectáreas";
            this.rdBtnHectáreas.Size = new System.Drawing.Size(94, 21);
            this.rdBtnHectáreas.TabIndex = 0;
            this.rdBtnHectáreas.TabStop = true;
            this.rdBtnHectáreas.Text = "Hectáreas";
            this.rdBtnHectáreas.UseVisualStyleBackColor = true;
            this.rdBtnHectáreas.CheckedChanged += new System.EventHandler(this.rdBtnHectáreas_CheckedChanged);
            // 
            // rdBtnAnimales
            // 
            this.rdBtnAnimales.AutoSize = true;
            this.rdBtnAnimales.Location = new System.Drawing.Point(6, 57);
            this.rdBtnAnimales.Name = "rdBtnAnimales";
            this.rdBtnAnimales.Size = new System.Drawing.Size(87, 21);
            this.rdBtnAnimales.TabIndex = 1;
            this.rdBtnAnimales.TabStop = true;
            this.rdBtnAnimales.Text = "Animales";
            this.rdBtnAnimales.UseVisualStyleBackColor = true;
            this.rdBtnAnimales.CheckedChanged += new System.EventHandler(this.rdBtnAnimales_CheckedChanged);
            // 
            // rdBtnUnidadGanadera
            // 
            this.rdBtnUnidadGanadera.AutoSize = true;
            this.rdBtnUnidadGanadera.Location = new System.Drawing.Point(6, 83);
            this.rdBtnUnidadGanadera.Name = "rdBtnUnidadGanadera";
            this.rdBtnUnidadGanadera.Size = new System.Drawing.Size(146, 21);
            this.rdBtnUnidadGanadera.TabIndex = 2;
            this.rdBtnUnidadGanadera.TabStop = true;
            this.rdBtnUnidadGanadera.Text = "Unidad Ganadera";
            this.rdBtnUnidadGanadera.UseVisualStyleBackColor = true;
            this.rdBtnUnidadGanadera.CheckedChanged += new System.EventHandler(this.rdBtnUnidadGanadera_CheckedChanged);
            // 
            // lblVerPotreros
            // 
            this.lblVerPotreros.AutoSize = true;
            this.lblVerPotreros.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lblVerPotreros.Location = new System.Drawing.Point(312, 46);
            this.lblVerPotreros.Name = "lblVerPotreros";
            this.lblVerPotreros.Size = new System.Drawing.Size(177, 27);
            this.lblVerPotreros.TabIndex = 2;
            this.lblVerPotreros.Text = "VER POTREROS";
            // 
            // rdBtnLimpiarFiltros
            // 
            this.rdBtnLimpiarFiltros.AutoSize = true;
            this.rdBtnLimpiarFiltros.Location = new System.Drawing.Point(6, 110);
            this.rdBtnLimpiarFiltros.Name = "rdBtnLimpiarFiltros";
            this.rdBtnLimpiarFiltros.Size = new System.Drawing.Size(115, 21);
            this.rdBtnLimpiarFiltros.TabIndex = 3;
            this.rdBtnLimpiarFiltros.TabStop = true;
            this.rdBtnLimpiarFiltros.Text = "Limpiar Filtros";
            this.rdBtnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.rdBtnLimpiarFiltros.CheckedChanged += new System.EventHandler(this.rdBtnLimpiarFiltros_CheckedChanged);
            // 
            // FormVerPotreros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 402);
            this.Controls.Add(this.pnlPotreros);
            this.Controls.Add(this.pnlVerPotreros);
            this.MinimumSize = new System.Drawing.Size(823, 446);
            this.Name = "FormVerPotreros";
            this.Text = "VerPotreros";
            this.Load += new System.EventHandler(this.VerPotreros_Load);
            this.pnlVerPotreros.ResumeLayout(false);
            this.pnlVerPotreros.PerformLayout();
            this.pnlPotreros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPotreros)).EndInit();
            this.grpBoxFiltrar.ResumeLayout(false);
            this.grpBoxFiltrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVerPotreros;
        private System.Windows.Forms.Panel pnlPotreros;
        private System.Windows.Forms.DataGridView dataGridViewPotreros;
        private System.Windows.Forms.GroupBox grpBoxFiltrar;
        private System.Windows.Forms.RadioButton rdBtnUnidadGanadera;
        private System.Windows.Forms.RadioButton rdBtnAnimales;
        private System.Windows.Forms.RadioButton rdBtnHectáreas;
        private System.Windows.Forms.Label lblVerPotreros;
        private System.Windows.Forms.RadioButton rdBtnLimpiarFiltros;
    }
}