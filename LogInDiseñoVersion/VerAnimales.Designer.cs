namespace LogInDiseño
{
    partial class FormVerAnimales
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVerAnimales = new System.Windows.Forms.Label();
            this.dataGridViewAnimales = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.lblVerAnimales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 125);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.dataGridViewAnimales);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 276);
            this.panel2.TabIndex = 1;
            // 
            // lblVerAnimales
            // 
            this.lblVerAnimales.AutoSize = true;
            this.lblVerAnimales.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lblVerAnimales.Location = new System.Drawing.Point(309, 51);
            this.lblVerAnimales.Name = "lblVerAnimales";
            this.lblVerAnimales.Size = new System.Drawing.Size(175, 27);
            this.lblVerAnimales.TabIndex = 0;
            this.lblVerAnimales.Text = "VER ANIMALES";
            // 
            // dataGridViewAnimales
            // 
            this.dataGridViewAnimales.AllowUserToAddRows = false;
            this.dataGridViewAnimales.AllowUserToDeleteRows = false;
            this.dataGridViewAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimales.Location = new System.Drawing.Point(24, 19);
            this.dataGridViewAnimales.Name = "dataGridViewAnimales";
            this.dataGridViewAnimales.ReadOnly = true;
            this.dataGridViewAnimales.RowHeadersWidth = 51;
            this.dataGridViewAnimales.RowTemplate.Height = 24;
            this.dataGridViewAnimales.Size = new System.Drawing.Size(485, 245);
            this.dataGridViewAnimales.TabIndex = 0;
            // 
            // FormVerAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(823, 446);
            this.Name = "FormVerAnimales";
            this.Text = "VerAnimales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblVerAnimales;
        private System.Windows.Forms.DataGridView dataGridViewAnimales;
    }
}