namespace LogInDiseño
{
    partial class formLogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogIn));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.picBoxOcultarContraseña = new System.Windows.Forms.PictureBox();
            this.picBoxMostrarContraseña = new System.Windows.Forms.PictureBox();
            this.picBoxContraseña = new System.Windows.Forms.PictureBox();
            this.picBoxUsuario = new System.Windows.Forms.PictureBox();
            this.linkLblRegistrarse = new System.Windows.Forms.LinkLabel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOcultarContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMostrarContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.panelLogo.Controls.Add(this.picBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panelLogo.Location = new System.Drawing.Point(520, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 350);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(50, 100);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(160, 160);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 9;
            this.picBoxLogo.TabStop = false;
            // 
            // panelUsuario
            // 
            this.panelUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.panelUsuario.Controls.Add(this.picBoxOcultarContraseña);
            this.panelUsuario.Controls.Add(this.picBoxMostrarContraseña);
            this.panelUsuario.Controls.Add(this.picBoxContraseña);
            this.panelUsuario.Controls.Add(this.picBoxUsuario);
            this.panelUsuario.Controls.Add(this.linkLblRegistrarse);
            this.panelUsuario.Controls.Add(this.txtContraseña);
            this.panelUsuario.Controls.Add(this.txtCedula);
            this.panelUsuario.Controls.Add(this.btnIngresar);
            this.panelUsuario.Controls.Add(this.lblIniciarSesion);
            this.panelUsuario.Location = new System.Drawing.Point(12, 12);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(493, 326);
            this.panelUsuario.TabIndex = 1;
            // 
            // picBoxOcultarContraseña
            // 
            this.picBoxOcultarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxOcultarContraseña.Image = ((System.Drawing.Image)(resources.GetObject("picBoxOcultarContraseña.Image")));
            this.picBoxOcultarContraseña.Location = new System.Drawing.Point(435, 148);
            this.picBoxOcultarContraseña.Name = "picBoxOcultarContraseña";
            this.picBoxOcultarContraseña.Size = new System.Drawing.Size(28, 22);
            this.picBoxOcultarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxOcultarContraseña.TabIndex = 18;
            this.picBoxOcultarContraseña.TabStop = false;
            this.picBoxOcultarContraseña.Visible = false;
            this.picBoxOcultarContraseña.Click += new System.EventHandler(this.picBoxOcultarContraseña_Click);
            // 
            // picBoxMostrarContraseña
            // 
            this.picBoxMostrarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMostrarContraseña.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMostrarContraseña.Image")));
            this.picBoxMostrarContraseña.Location = new System.Drawing.Point(435, 148);
            this.picBoxMostrarContraseña.Name = "picBoxMostrarContraseña";
            this.picBoxMostrarContraseña.Size = new System.Drawing.Size(28, 22);
            this.picBoxMostrarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMostrarContraseña.TabIndex = 17;
            this.picBoxMostrarContraseña.TabStop = false;
            this.picBoxMostrarContraseña.Click += new System.EventHandler(this.picBoxMostrarContraseña_Click);
            // 
            // picBoxContraseña
            // 
            this.picBoxContraseña.Image = ((System.Drawing.Image)(resources.GetObject("picBoxContraseña.Image")));
            this.picBoxContraseña.Location = new System.Drawing.Point(61, 147);
            this.picBoxContraseña.Name = "picBoxContraseña";
            this.picBoxContraseña.Size = new System.Drawing.Size(28, 25);
            this.picBoxContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxContraseña.TabIndex = 16;
            this.picBoxContraseña.TabStop = false;
            // 
            // picBoxUsuario
            // 
            this.picBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUsuario.Image")));
            this.picBoxUsuario.Location = new System.Drawing.Point(61, 79);
            this.picBoxUsuario.Name = "picBoxUsuario";
            this.picBoxUsuario.Size = new System.Drawing.Size(28, 25);
            this.picBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUsuario.TabIndex = 15;
            this.picBoxUsuario.TabStop = false;
            // 
            // linkLblRegistrarse
            // 
            this.linkLblRegistrarse.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(54)))));
            this.linkLblRegistrarse.AutoSize = true;
            this.linkLblRegistrarse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblRegistrarse.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLblRegistrarse.Location = new System.Drawing.Point(122, 298);
            this.linkLblRegistrarse.Name = "linkLblRegistrarse";
            this.linkLblRegistrarse.Size = new System.Drawing.Size(255, 20);
            this.linkLblRegistrarse.TabIndex = 14;
            this.linkLblRegistrarse.TabStop = true;
            this.linkLblRegistrarse.Text = "¿No tiene una cuenta? Registrate";
            this.linkLblRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblRegistrarse_LinkClicked);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtContraseña.Location = new System.Drawing.Point(102, 147);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(361, 25);
            this.txtContraseña.TabIndex = 11;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyDown);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCedula.Location = new System.Drawing.Point(102, 79);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(361, 25);
            this.txtCedula.TabIndex = 10;
            this.txtCedula.Text = "CÉDULA";
            this.txtCedula.Click += new System.EventHandler(this.txtCedula_Click);
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(168)))), ((int)(((byte)(99)))));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(54)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngresar.Location = new System.Drawing.Point(61, 241);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(402, 40);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Location = new System.Drawing.Point(58, 32);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(107, 16);
            this.lblIniciarSesion.TabIndex = 13;
            this.lblIniciarSesion.Text = "INICIAR SESIÓN";
            // 
            // formLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(780, 350);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.panelLogo);
            this.MinimumSize = new System.Drawing.Size(798, 397);
            this.Name = "formLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formLogIn_MouseDown);
            this.Resize += new System.EventHandler(this.formLogIn_Resize);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOcultarContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMostrarContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.PictureBox picBoxOcultarContraseña;
        private System.Windows.Forms.PictureBox picBoxMostrarContraseña;
        private System.Windows.Forms.PictureBox picBoxContraseña;
        private System.Windows.Forms.PictureBox picBoxUsuario;
        private System.Windows.Forms.LinkLabel linkLblRegistrarse;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblIniciarSesion;
    }
}

